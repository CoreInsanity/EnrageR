namespace EnrageR
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExitImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.MarqueeLabel = new System.Windows.Forms.Label();
            this.MarqueeTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TeleportButton = new System.Windows.Forms.Button();
            this.TeleportBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HealthTrackbar = new System.Windows.Forms.TrackBar();
            this.AutoHealTextbox = new System.Windows.Forms.TextBox();
            this.ExtremeGodmodeCheckbox = new System.Windows.Forms.CheckBox();
            this.AutoHealCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            this.VehicleGroupBox = new System.Windows.Forms.GroupBox();
            this.DestroyLastUsedButton = new System.Windows.Forms.Button();
            this.VehicleHealthTrackbar = new System.Windows.Forms.TrackBar();
            this.EngineDamageCheckbox = new System.Windows.Forms.CheckBox();
            this.CollisionDamageCheckbox = new System.Windows.Forms.CheckBox();
            this.WeaponDamageCheckbox = new System.Windows.Forms.CheckBox();
            this.VehicleAccelerationTrackbar = new System.Windows.Forms.TrackBar();
            this.VehicleGravityTrackbar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.ExitImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealthTrackbar)).BeginInit();
            this.VehicleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleHealthTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleAccelerationTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGravityTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitImage
            // 
            this.ExitImage.BackColor = System.Drawing.Color.Salmon;
            this.ExitImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitImage.Image = global::EnrageR.Properties.Resources.close;
            this.ExitImage.Location = new System.Drawing.Point(308, 9);
            this.ExitImage.Name = "ExitImage";
            this.ExitImage.Size = new System.Drawing.Size(47, 47);
            this.ExitImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitImage.TabIndex = 0;
            this.ExitImage.TabStop = false;
            this.ExitImage.Click += new System.EventHandler(this.ExitImage_Click);
            this.ExitImage.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Controls.Add(this.ExitImage);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 60);
            this.panel1.TabIndex = 2;
            this.panel1.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerLabel.Location = new System.Drawing.Point(-4, 4);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(253, 52);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "EnrageR";
            this.headerLabel.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // MarqueeLabel
            // 
            this.MarqueeLabel.AutoSize = true;
            this.MarqueeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarqueeLabel.Location = new System.Drawing.Point(213, 494);
            this.MarqueeLabel.Name = "MarqueeLabel";
            this.MarqueeLabel.Size = new System.Drawing.Size(211, 13);
            this.MarqueeLabel.TabIndex = 3;
            this.MarqueeLabel.Text = "RageMP Cheats by MushtarioPepperoni";
            this.MarqueeLabel.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // MarqueeTimer
            // 
            this.MarqueeTimer.Tick += new System.EventHandler(this.MarqueeTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TeleportButton);
            this.groupBox1.Controls.Add(this.TeleportBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 81);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teleport";
            this.groupBox1.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // TeleportButton
            // 
            this.TeleportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeleportButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeleportButton.Location = new System.Drawing.Point(167, 29);
            this.TeleportButton.Name = "TeleportButton";
            this.TeleportButton.Size = new System.Drawing.Size(69, 23);
            this.TeleportButton.TabIndex = 1;
            this.TeleportButton.Text = "Teleport";
            this.TeleportButton.UseVisualStyleBackColor = true;
            this.TeleportButton.Click += new System.EventHandler(this.TeleportButton_Click);
            this.TeleportButton.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // TeleportBox
            // 
            this.TeleportBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeleportBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TeleportBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeleportBox.FormattingEnabled = true;
            this.TeleportBox.Location = new System.Drawing.Point(23, 30);
            this.TeleportBox.Name = "TeleportBox";
            this.TeleportBox.Size = new System.Drawing.Size(121, 21);
            this.TeleportBox.TabIndex = 0;
            this.TeleportBox.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HealthTrackbar);
            this.groupBox2.Controls.Add(this.AutoHealTextbox);
            this.groupBox2.Controls.Add(this.ExtremeGodmodeCheckbox);
            this.groupBox2.Controls.Add(this.AutoHealCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 118);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Health";
            this.groupBox2.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // HealthTrackbar
            // 
            this.HealthTrackbar.Location = new System.Drawing.Point(23, 21);
            this.HealthTrackbar.Name = "HealthTrackbar";
            this.HealthTrackbar.Size = new System.Drawing.Size(287, 45);
            this.HealthTrackbar.TabIndex = 9;
            this.HealthTrackbar.Scroll += new System.EventHandler(this.HealthTrackbar_Scroll);
            this.HealthTrackbar.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // AutoHealTextbox
            // 
            this.AutoHealTextbox.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoHealTextbox.Location = new System.Drawing.Point(128, 64);
            this.AutoHealTextbox.Name = "AutoHealTextbox";
            this.AutoHealTextbox.Size = new System.Drawing.Size(31, 19);
            this.AutoHealTextbox.TabIndex = 2;
            this.AutoHealTextbox.Text = "100";
            this.AutoHealTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AutoHealTextbox.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // ExtremeGodmodeCheckbox
            // 
            this.ExtremeGodmodeCheckbox.AutoSize = true;
            this.ExtremeGodmodeCheckbox.Location = new System.Drawing.Point(23, 88);
            this.ExtremeGodmodeCheckbox.Name = "ExtremeGodmodeCheckbox";
            this.ExtremeGodmodeCheckbox.Size = new System.Drawing.Size(155, 17);
            this.ExtremeGodmodeCheckbox.TabIndex = 1;
            this.ExtremeGodmodeCheckbox.Text = "Extreme godmode (RISKY)";
            this.ExtremeGodmodeCheckbox.UseVisualStyleBackColor = true;
            this.ExtremeGodmodeCheckbox.CheckedChanged += new System.EventHandler(this.ExtremeGodmode_CheckedChanged);
            this.ExtremeGodmodeCheckbox.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // AutoHealCheckBox
            // 
            this.AutoHealCheckBox.AutoSize = true;
            this.AutoHealCheckBox.Location = new System.Drawing.Point(23, 65);
            this.AutoHealCheckBox.Name = "AutoHealCheckBox";
            this.AutoHealCheckBox.Size = new System.Drawing.Size(165, 17);
            this.AutoHealCheckBox.TabIndex = 0;
            this.AutoHealCheckBox.Text = "Auto-heal every               ms";
            this.AutoHealCheckBox.UseVisualStyleBackColor = true;
            this.AutoHealCheckBox.CheckedChanged += new System.EventHandler(this.AutoHeal_CheckedChanged);
            this.AutoHealCheckBox.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // CloseTimer
            // 
            this.CloseTimer.Interval = 1000;
            this.CloseTimer.Tick += new System.EventHandler(this.CloseTimer_Tick);
            // 
            // VehicleGroupBox
            // 
            this.VehicleGroupBox.Controls.Add(this.VehicleGravityTrackbar);
            this.VehicleGroupBox.Controls.Add(this.VehicleAccelerationTrackbar);
            this.VehicleGroupBox.Controls.Add(this.WeaponDamageCheckbox);
            this.VehicleGroupBox.Controls.Add(this.CollisionDamageCheckbox);
            this.VehicleGroupBox.Controls.Add(this.DestroyLastUsedButton);
            this.VehicleGroupBox.Controls.Add(this.VehicleHealthTrackbar);
            this.VehicleGroupBox.Controls.Add(this.EngineDamageCheckbox);
            this.VehicleGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleGroupBox.Location = new System.Drawing.Point(12, 286);
            this.VehicleGroupBox.Name = "VehicleGroupBox";
            this.VehicleGroupBox.Size = new System.Drawing.Size(336, 204);
            this.VehicleGroupBox.TabIndex = 6;
            this.VehicleGroupBox.TabStop = false;
            this.VehicleGroupBox.Text = "Vehicle";
            this.VehicleGroupBox.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // DestroyLastUsedButton
            // 
            this.DestroyLastUsedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DestroyLastUsedButton.Location = new System.Drawing.Point(235, 168);
            this.DestroyLastUsedButton.Name = "DestroyLastUsedButton";
            this.DestroyLastUsedButton.Size = new System.Drawing.Size(75, 23);
            this.DestroyLastUsedButton.TabIndex = 8;
            this.DestroyLastUsedButton.Text = "Destroy";
            this.DestroyLastUsedButton.UseVisualStyleBackColor = true;
            this.DestroyLastUsedButton.Click += new System.EventHandler(this.DestroyLastUsedButton_Click);
            this.DestroyLastUsedButton.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // VehicleHealthTrackbar
            // 
            this.VehicleHealthTrackbar.Location = new System.Drawing.Point(23, 21);
            this.VehicleHealthTrackbar.Name = "VehicleHealthTrackbar";
            this.VehicleHealthTrackbar.Size = new System.Drawing.Size(287, 45);
            this.VehicleHealthTrackbar.TabIndex = 7;
            this.VehicleHealthTrackbar.Scroll += new System.EventHandler(this.VehicleHealthTrackbar_Scroll);
            this.VehicleHealthTrackbar.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // EngineDamageCheckbox
            // 
            this.EngineDamageCheckbox.AutoSize = true;
            this.EngineDamageCheckbox.Location = new System.Drawing.Point(23, 134);
            this.EngineDamageCheckbox.Name = "EngineDamageCheckbox";
            this.EngineDamageCheckbox.Size = new System.Drawing.Size(124, 17);
            this.EngineDamageCheckbox.TabIndex = 0;
            this.EngineDamageCheckbox.Text = "No engine damage";
            this.EngineDamageCheckbox.UseVisualStyleBackColor = true;
            this.EngineDamageCheckbox.CheckedChanged += new System.EventHandler(this.EngineDamageCheckbox_CheckedChanged);
            this.EngineDamageCheckbox.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // CollisionDamageCheckbox
            // 
            this.CollisionDamageCheckbox.AutoSize = true;
            this.CollisionDamageCheckbox.Location = new System.Drawing.Point(23, 155);
            this.CollisionDamageCheckbox.Name = "CollisionDamageCheckbox";
            this.CollisionDamageCheckbox.Size = new System.Drawing.Size(131, 17);
            this.CollisionDamageCheckbox.TabIndex = 9;
            this.CollisionDamageCheckbox.Text = "No collision damage";
            this.CollisionDamageCheckbox.UseVisualStyleBackColor = true;
            this.CollisionDamageCheckbox.CheckedChanged += new System.EventHandler(this.CollisionDamageCheckbox_CheckedChanged);
            this.CollisionDamageCheckbox.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // WeaponDamageCheckbox
            // 
            this.WeaponDamageCheckbox.AutoSize = true;
            this.WeaponDamageCheckbox.Location = new System.Drawing.Point(23, 176);
            this.WeaponDamageCheckbox.Name = "WeaponDamageCheckbox";
            this.WeaponDamageCheckbox.Size = new System.Drawing.Size(130, 17);
            this.WeaponDamageCheckbox.TabIndex = 10;
            this.WeaponDamageCheckbox.Text = "No weapon damage";
            this.WeaponDamageCheckbox.UseVisualStyleBackColor = true;
            this.WeaponDamageCheckbox.CheckedChanged += new System.EventHandler(this.WeaponDamageCheckbox_CheckedChanged);
            this.WeaponDamageCheckbox.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // VehicleAccelerationTrackbar
            // 
            this.VehicleAccelerationTrackbar.Location = new System.Drawing.Point(23, 52);
            this.VehicleAccelerationTrackbar.Minimum = 1;
            this.VehicleAccelerationTrackbar.Name = "VehicleAccelerationTrackbar";
            this.VehicleAccelerationTrackbar.Size = new System.Drawing.Size(287, 45);
            this.VehicleAccelerationTrackbar.TabIndex = 11;
            this.VehicleAccelerationTrackbar.Value = 1;
            this.VehicleAccelerationTrackbar.Scroll += new System.EventHandler(this.VehicleAccelerationTrackbar_Scroll);
            this.VehicleAccelerationTrackbar.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // VehicleGravityTrackbar
            // 
            this.VehicleGravityTrackbar.Location = new System.Drawing.Point(23, 84);
            this.VehicleGravityTrackbar.Name = "VehicleGravityTrackbar";
            this.VehicleGravityTrackbar.Size = new System.Drawing.Size(287, 45);
            this.VehicleGravityTrackbar.TabIndex = 12;
            this.VehicleGravityTrackbar.Scroll += new System.EventHandler(this.VehicleGravityTrackbar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(360, 513);
            this.Controls.Add(this.VehicleGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MarqueeLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnrageR | Pre-Release BUILD 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseHover += new System.EventHandler(this.OnHover);
            ((System.ComponentModel.ISupportInitialize)(this.ExitImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealthTrackbar)).EndInit();
            this.VehicleGroupBox.ResumeLayout(false);
            this.VehicleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleHealthTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleAccelerationTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGravityTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label MarqueeLabel;
        private System.Windows.Forms.Timer MarqueeTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TeleportButton;
        private System.Windows.Forms.ComboBox TeleportBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer CloseTimer;
        private System.Windows.Forms.CheckBox AutoHealCheckBox;
        private System.Windows.Forms.TextBox AutoHealTextbox;
        private System.Windows.Forms.CheckBox ExtremeGodmodeCheckbox;
        private System.Windows.Forms.GroupBox VehicleGroupBox;
        private System.Windows.Forms.CheckBox EngineDamageCheckbox;
        private System.Windows.Forms.TrackBar VehicleHealthTrackbar;
        private System.Windows.Forms.Button DestroyLastUsedButton;
        private System.Windows.Forms.TrackBar HealthTrackbar;
        private System.Windows.Forms.CheckBox WeaponDamageCheckbox;
        private System.Windows.Forms.CheckBox CollisionDamageCheckbox;
        private System.Windows.Forms.TrackBar VehicleAccelerationTrackbar;
        private System.Windows.Forms.TrackBar VehicleGravityTrackbar;
    }
}

