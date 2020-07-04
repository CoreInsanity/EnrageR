using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using EnrageR.Helpers;
using EnrageR.Models;
using System.Diagnostics;
using FMUtils.KeyboardHook;

namespace EnrageR
{
    public partial class Enrager : Form
    {
        private Player Player;
        private Hook KeyboardHook;
        private GTA Gta;
        private Thread UIUpdaterThread;

        public Enrager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var login = new Login();
            login.ShowDialog();

            Gta = new GTA();
            Player = new Player(Gta);
            UIUpdaterThread = new Thread(new ThreadStart(UpdateUIElements));
            UIUpdaterThread.Start();
            foreach (var scrn in Screen.AllScreens)
                if (scrn.Bounds.Contains(this.Location)) this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top);
            WindowState = FormWindowState.Minimized;

            KeyboardHook = new Hook("Keyboard hook");
            KeyboardHook.KeyUpEvent += KeyPress;

            MarqueeTimer.Start();
            InitializeTooltips();

            TeleportBox.Items.Add("Waypoint");
            foreach (var location in Models.Location.GetLocations())
                TeleportBox.Items.Add(location.Name);
            TeleportBox.SelectedIndex = 0;
        }
        private void InitializeTooltips()
        {
            new ToolTip().SetToolTip(VehicleHealthTrackbar, "Vehicle engine health");
            new ToolTip().SetToolTip(VehicleAccelerationTrackbar, "Vehicle acceleration");
            new ToolTip().SetToolTip(DestroyLastUsedButton, "Destroy current/last used vehicle");
            new ToolTip().SetToolTip(SpaceButton, "Transform current/last used vehicle into a falcon heavy");
            new ToolTip().SetToolTip(VehicleGravityTrackbar, "Set gravity of vehicle");
            new ToolTip().SetToolTip(IncreaseGravityCheckbox, "Increase gravity for easier driving");
            new ToolTip().SetToolTip(EngineDamageCheckbox, "Toggle engine damage on this vehicle");
            new ToolTip().SetToolTip(CollisionDamageCheckbox, "Toggle collision damage on this vehicle");
            new ToolTip().SetToolTip(WeaponDamageCheckbox, "Toggle weapon damage on this vehicle");
            new ToolTip().SetToolTip(ExitImage, "Close the cheat");
        }

        #region events
        #region UI
        /// <summary>
        /// Mouse drag moves form
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void KeyPress(KeyboardHookEventArgs e)
        {
            if (e.isAltPressed) Player.Health = 200;

            else if (e.isRCtrlPressed) TeleportButton_Click(new object(), new EventArgs());

            else if (e.Key == Keys.F10)
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    WindowState = FormWindowState.Normal;
                    this.Activate();
                    this.Opacity = 1;
                }
                else WindowState = FormWindowState.Minimized;
            }
            else if (e.Key == Keys.NumPad0)
            {
                if (Player.VehicleStatus == VehicleStatus.IN || Player.VehicleStatus == VehicleStatus.TRANS)
                {
                    var gravity = Player.CurrentVehicle.Gravity;
                    if (gravity == 0 && IncreaseGravityCheckbox.Checked) Player.CurrentVehicle.Gravity = 17f;
                    else if (gravity == 0) Player.CurrentVehicle.Gravity = 9.8f;
                    else Player.CurrentVehicle.Gravity = 0f;
                }
            }
        }

        private int xPos = -196;
        private void MarqueeTimer_Tick(object sender, EventArgs e)
        {
            if (xPos >= this.Width)
            {
                this.MarqueeLabel.Location = new System.Drawing.Point(-196, this.MarqueeLabel.Location.Y);
                xPos = -196;
                return;
            }
            this.MarqueeLabel.Location = new System.Drawing.Point(xPos, this.MarqueeLabel.Location.Y);
            xPos++;
        }

        private void ExitImage_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res.ToString() == "Yes")
            {
                Environment.Exit(0);
            }
        }
        private void OnHover(object sender, EventArgs e)
        {
            if (!CloseTimer.Enabled) CloseTimer.Start();
            sec = 0;
            Opacity = 1;
        }

        private void OnLeave()
        {
            sec = 0;
            Opacity = 0.8;
            //for (double i = Opacity * 100; i >= 80; i--)
            //{
            //    Opacity = i / 100.0;
            //    Thread.Sleep(75);
            //}
        }
        int sec = 0;
        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec >= 10) OnLeave();
        }
        #endregion
        #region Teleport
        private void TeleportButton_Click(object sender, EventArgs e)
        {
            if (TeleportBox.Text == "Waypoint") Player.Location = Player.Waypoint;
            else
            {
                var loc = Models.Location.GetLocations().FirstOrDefault(l => l.Name.ToString().Equals(TeleportBox.Text));
                if (loc != null) Player.Location = loc;
            }
            WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Health
        private void HealthTrackbar_Scroll(object sender, EventArgs e)
        {
            Player.Health = HealthTrackbar.Value * 10 + 100;
        }
        private void ExtremeGodmode_CheckedChanged(object sender, EventArgs e)
        {
            //if (ExtremeGodmodeCheckbox.Checked) Player.EnableAutoHeal(100, 10000);
            //else Player.DisableAutoHeal();
        }
        private void AutoHeal_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoHealCheckBox.Checked)
            {
                Player.EnableAutoHeal(Convert.ToInt32(AutoHealTextbox.Text));
                HealthTrackbar.Enabled = false;
            }
            else
            {
                Player.DisableAutoHeal();
                HealthTrackbar.Enabled = true;
            }
        }
        #endregion
        #region Vehicle
        private void EngineDamageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Player.VehicleStatus == VehicleStatus.IN || Player.VehicleStatus == VehicleStatus.TRANS)
            {
                if (EngineDamageCheckbox.Checked) Player.CurrentVehicle.EngineDamage = 0;
                else Player.CurrentVehicle.EngineDamage = 1;
            }
        }
        private void WeaponDamageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Player.VehicleStatus == VehicleStatus.IN || Player.VehicleStatus == VehicleStatus.TRANS)
            {
                if (WeaponDamageCheckbox.Checked) Player.CurrentVehicle.WeaponDamage = 0;
                else Player.CurrentVehicle.WeaponDamage = 1;
            }
        }
        private void CollisionDamageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Player.VehicleStatus == VehicleStatus.IN || Player.VehicleStatus == VehicleStatus.TRANS)
            {
                if (CollisionDamageCheckbox.Checked) Player.CurrentVehicle.CollisionDamage = 0;
                else Player.CurrentVehicle.CollisionDamage = 1;
            }
        }
        private void IncreaseGravityCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Player.VehicleStatus == VehicleStatus.IN || Player.VehicleStatus == VehicleStatus.TRANS)
            {
                if (IncreaseGravityCheckbox.Checked) Player.CurrentVehicle.Gravity = 17f;
                else Player.CurrentVehicle.Gravity = 9.8f;
            }
        }
        private void VehicleHealthTrackbar_Scroll(object sender, EventArgs e)
        {
            if (Player.VehicleStatus == VehicleStatus.IN || Player.VehicleStatus == VehicleStatus.TRANS) Player.CurrentVehicle.EngineHealth = VehicleHealthTrackbar.Value * 100;
        }
        private void VehicleAccelerationTrackbar_Scroll(object sender, EventArgs e)
        {
            if (Player.VehicleStatus == VehicleStatus.IN || Player.VehicleStatus == VehicleStatus.TRANS) Player.CurrentVehicle.Acceleration = VehicleAccelerationTrackbar.Value;
        }
        private void VehicleGravityTrackbar_Scroll(object sender, EventArgs e)
        {
            var gravity = (float)VehicleGravityTrackbar.Value;
            if (gravity == 10) gravity = 9.8f;
            if (Player.VehicleStatus == VehicleStatus.IN || Player.VehicleStatus == VehicleStatus.TRANS) Player.CurrentVehicle.Gravity = gravity;
        }
        private void DestroyLastUsedButton_Click(object sender, EventArgs e)
        {
            Player.LastVehicle.EngineHealth = -1;
        }
        private void SpaceButton_Click(object sender, EventArgs e)
        {
            if (Player.LastVehicle == null) return;
            Player.LastVehicle.Gravity = -9.8f;
        }
        #endregion
        #region Weapon
        private void NoRecoilCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (NoRecoilCheckbox.Checked) Player.Weapon.Recoil = 0;
            else Player.Weapon.Recoil = Player.Weapon.Backup.Recoil;
        }
        private void NoSpreadCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (NoSpreadCheckbox.Checked) Player.Weapon.Spread = 0;
            else Player.Weapon.Spread = Player.Weapon.Backup.Spread;
        }
        private void FastReloadCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (FastReloadCheckbox.Checked) Player.Weapon.ReloadMultiplier = 20;
            else Player.Weapon.ReloadMultiplier = Player.Weapon.Backup.ReloadMultiplier;
        }
        #endregion
        #endregion

        #region threads
        private long LastClearedAddy;
        private void UpdateUIElements()
        {
            while (true)
            {
                Thread.Sleep(1000);

                //Update Player health
                if (Player.Health > 200 || Player.Health < 100)
                    HealthTrackbar.Invoke(new Action(() => HealthTrackbar.Enabled = false));
                else
                    HealthTrackbar.Invoke(new Action(() =>
                    {
                        if(!AutoHealCheckBox.Checked) HealthTrackbar.Enabled = true;
                        HealthTrackbar.Value = (int)Math.Floor((Player.Health - 100.0) / 10.0);
                    }));

                //Update Vehicle
                if (Player.VehicleStatus == VehicleStatus.IN)
                {
                    var vehicle = Player.CurrentVehicle;
                    if (vehicle == null) continue;

                    var vehHealth = vehicle.EngineHealth;
                    if (vehHealth < 0) vehHealth = 0;
                    if (vehHealth > 1000) vehHealth = 1000;

                    var vehAcceleration = vehicle.Acceleration;
                    if (vehAcceleration < 1) vehAcceleration = 1;
                    if (vehAcceleration > 10) vehAcceleration = 10;

                    var vehGravity = vehicle.Gravity;
                    if (vehGravity < 0) vehGravity = 0;
                    if (vehGravity > 10) vehGravity = 10;

                    VehicleGroupBox.Invoke(new Action(() =>
                    {
                        LastClearedAddy = 0;
                        VehicleHealthTrackbar.Enabled = true;
                        VehicleAccelerationTrackbar.Enabled = true;
                        if (!IncreaseGravityCheckbox.Checked) VehicleGravityTrackbar.Enabled = true;
                        else VehicleGravityTrackbar.Enabled = false;

                        CollisionDamageCheckbox.Enabled = true;
                        EngineDamageCheckbox.Enabled = true;
                        WeaponDamageCheckbox.Enabled = true;
                        IncreaseGravityCheckbox.Enabled = true;

                        VehicleHealthTrackbar.Value = (int)Math.Floor(vehHealth / 100.0);
                        VehicleAccelerationTrackbar.Value = (int)Math.Floor(vehAcceleration);
                        VehicleGravityTrackbar.Value = (int)Math.Ceiling(vehGravity);
                    }));
                }
                else if (Player.VehicleStatus == VehicleStatus.OUT)
                {
                    VehicleGroupBox.Invoke(new Action(() =>
                    {
                        VehicleHealthTrackbar.Enabled = false;
                        VehicleAccelerationTrackbar.Enabled = false;
                        VehicleGravityTrackbar.Enabled = false;

                        CollisionDamageCheckbox.Checked = false;
                        EngineDamageCheckbox.Checked = false;
                        WeaponDamageCheckbox.Checked = false;
                        IncreaseGravityCheckbox.Checked = false;

                        CollisionDamageCheckbox.Enabled = false;
                        EngineDamageCheckbox.Enabled = false;
                        WeaponDamageCheckbox.Enabled = false;
                        IncreaseGravityCheckbox.Enabled = false;
                    }));
                    if (Player.LastVehicle != null && Player.LastVehicle.VehicleAddy != LastClearedAddy)
                    {
                        Player.LastVehicle.Reset();
                        LastClearedAddy = Player.LastVehicle.VehicleAddy; //Ensure we only clear this once
                    }
                }

                //Update Weapon
                if (Player.Weapon.Update())
                {
                    if (NoRecoilCheckbox.Checked) Player.Weapon.Recoil = 0;
                    if (NoSpreadCheckbox.Checked) Player.Weapon.Spread = 0;
                    if (FastReloadCheckbox.Checked) Player.Weapon.ReloadMultiplier = 20;
                }
            }
        }
        #endregion
    }
}
