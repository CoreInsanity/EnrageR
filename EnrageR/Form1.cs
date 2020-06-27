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
    public partial class Form1 : Form
    {
        private Player Player;
        private Vehicle Vehicle;
        private Hook KeyboardHook;
        private GTA Gta;
        private Thread UIUpdaterThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

            foreach (var location in Models.Location.GetLocations())
                TeleportBox.Items.Add(location.Name);
            TeleportBox.SelectedIndex = 0;
        }
        private void InitializeTooltips()
        {
            new ToolTip().SetToolTip(VehicleHealthTrackbar, "Vehicle engine health");
            new ToolTip().SetToolTip(VehicleAccelerationTrackbar, "Vehicle acceleration");
            new ToolTip().SetToolTip(DestroyLastUsedButton, "Destroy current/last used vehicle");
            new ToolTip().SetToolTip(VehicleGravityTrackbar, "Set gravity of vehicle");
        }
        #region events
        private void KeyPress(KeyboardHookEventArgs e)
        {
            if (e.isAltPressed)
            {
                Trace.WriteLine("Healing...");
                Player.Health = 200;
                return;
            }

            if (e.isRCtrlPressed)
            {
                var loc = Models.Location.GetLocations().FirstOrDefault(l => l.Name.ToString().Equals(TeleportBox.Text));
                if (loc == null) return;
                Player.Location = loc;
            }

            if (e.Key == Keys.F10)
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    WindowState = FormWindowState.Normal;
                    this.Activate();
                }
                else WindowState = FormWindowState.Minimized;
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

        private void TeleportButton_Click(object sender, EventArgs e)
        {
            var loc = Models.Location.GetLocations().FirstOrDefault(l => l.Name.ToString().Equals(TeleportBox.Text));
            if (loc == null) return;
            Player.Location = loc;

            WindowState = FormWindowState.Minimized;
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
            Opacity = 1;
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
        private void ExtremeGodmode_CheckedChanged(object sender, EventArgs e)
        {
            if (ExtremeGodmodeCheckbox.Checked) Player.EnableAutoHeal(100, 10000);
            else Player.DisableAutoHeal();
        }
        private void AutoHeal_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoHealCheckBox.Checked) Player.EnableAutoHeal(Convert.ToInt32(AutoHealTextbox.Text), 200);
            else Player.DisableAutoHeal();
        }

        private void EngineDamageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!Player.IsInVehicle) return;
            if (EngineDamageCheckbox.Checked) Player.CurrentVehicle.EngineDamage = 0;
            else Player.CurrentVehicle.EngineDamage = 1;
        }
        private void WeaponDamageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!Player.IsInVehicle) return;
            if (WeaponDamageCheckbox.Checked) Player.CurrentVehicle.WeaponDamage = 0;
            else Player.CurrentVehicle.WeaponDamage = 1;
        }
        private void CollisionDamageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!Player.IsInVehicle) return;
            if (CollisionDamageCheckbox.Checked) Player.CurrentVehicle.CollisionDamage = 0;
            else Player.CurrentVehicle.CollisionDamage = 1;
        }
        private void VehicleHealthTrackbar_Scroll(object sender, EventArgs e)
        {
            if (Player.IsInVehicle) Player.CurrentVehicle.EngineHealth = VehicleHealthTrackbar.Value * 100;
        }
        private void VehicleAccelerationTrackbar_Scroll(object sender, EventArgs e)
        {
            if (Player.IsInVehicle) Player.CurrentVehicle.Acceleration = VehicleAccelerationTrackbar.Value;
        }
        private void VehicleGravityTrackbar_Scroll(object sender, EventArgs e)
        {
            var gravity = Player.CurrentVehicle.Gravity;
            if (gravity == 10) gravity = 9.8f;
            if (Player.IsInVehicle) Player.CurrentVehicle.Gravity = VehicleGravityTrackbar.Value;
        }
        private void HealthTrackbar_Scroll(object sender, EventArgs e)
        {
            Player.Health = HealthTrackbar.Value * 10 + 100;
        }
        private void DestroyLastUsedButton_Click(object sender, EventArgs e)
        {
            Player.LastVehicle.EngineHealth = -1;
        }

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
        #endregion
        #region threads
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
                        HealthTrackbar.Enabled = true;
                        HealthTrackbar.Value = (int)Math.Floor((Player.Health - 100.0) / 10.0);
                    }));

                //Update Vehicle Health
                if (Player.IsInVehicle)
                {
                    var vehicle = Player.CurrentVehicle;
                    if (vehicle == null) return; //Workaround for a weird bug that I'm too tired to care about
                    var vehHealth = vehicle.EngineHealth;
                    if (vehHealth < 1) vehHealth = 0;

                    VehicleGroupBox.Invoke(new Action(() =>
                    {
                        VehicleHealthTrackbar.Enabled = true;
                        VehicleAccelerationTrackbar.Enabled = true;
                        VehicleGravityTrackbar.Enabled = true;

                        CollisionDamageCheckbox.Enabled = true;
                        EngineDamageCheckbox.Enabled = true;
                        WeaponDamageCheckbox.Enabled = true;

                        try
                        {
                            VehicleHealthTrackbar.Value = (int)Math.Floor(vehHealth / 100.0);
                            VehicleAccelerationTrackbar.Value = (int)Math.Floor(vehicle.Acceleration);
                            VehicleGravityTrackbar.Value = (int)Math.Ceiling(vehicle.Gravity);
                        }
                        catch (Exception ex)
                        {
                            Trace.WriteLine(ex.Message);
                        }
                    }));
                }
                else
                {
                    VehicleGroupBox.Invoke(new Action(() =>
                    {
                        VehicleHealthTrackbar.Enabled = false;
                        VehicleAccelerationTrackbar.Enabled = false;
                        VehicleGravityTrackbar.Enabled = false;

                        CollisionDamageCheckbox.Checked = false;
                        EngineDamageCheckbox.Checked = false;
                        WeaponDamageCheckbox.Checked = false;

                        CollisionDamageCheckbox.Enabled = false;
                        EngineDamageCheckbox.Enabled = false;
                        WeaponDamageCheckbox.Enabled = false;
                    }));
                    if (Player.LastVehicle != null) Player.LastVehicle.Reset();
                }
            }
        }
        #endregion
    }
}
