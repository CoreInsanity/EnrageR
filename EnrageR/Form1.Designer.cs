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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.EngineDamageCheckbox = new System.Windows.Forms.CheckBox();
            this.CollisionDamageCheckbox = new System.Windows.Forms.CheckBox();
            this.WeaponDamageCheckbox = new System.Windows.Forms.CheckBox();
            this.IncreaseGravityCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VehicleGravityTrackbar = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VehicleAccelerationTrackbar = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VehicleHealthTrackbar = new System.Windows.Forms.TrackBar();
            this.SpaceButton = new System.Windows.Forms.Button();
            this.DestroyLastUsedButton = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealthTrackbar)).BeginInit();
            this.VehicleGroupBox.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGravityTrackbar)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleAccelerationTrackbar)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleHealthTrackbar)).BeginInit();
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
            this.MarqueeLabel.Location = new System.Drawing.Point(213, 1049);
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
            this.groupBox1.Size = new System.Drawing.Size(336, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teleport";
            this.groupBox1.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // TeleportButton
            // 
            this.TeleportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeleportButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeleportButton.Location = new System.Drawing.Point(167, 26);
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
            this.TeleportBox.Location = new System.Drawing.Point(23, 27);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
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
            this.VehicleGroupBox.Controls.Add(this.groupBox6);
            this.VehicleGroupBox.Controls.Add(this.groupBox5);
            this.VehicleGroupBox.Controls.Add(this.groupBox4);
            this.VehicleGroupBox.Controls.Add(this.groupBox3);
            this.VehicleGroupBox.Controls.Add(this.SpaceButton);
            this.VehicleGroupBox.Controls.Add(this.DestroyLastUsedButton);
            this.VehicleGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleGroupBox.Location = new System.Drawing.Point(12, 272);
            this.VehicleGroupBox.Name = "VehicleGroupBox";
            this.VehicleGroupBox.Size = new System.Drawing.Size(336, 395);
            this.VehicleGroupBox.TabIndex = 6;
            this.VehicleGroupBox.TabStop = false;
            this.VehicleGroupBox.Text = "Vehicle";
            this.VehicleGroupBox.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.EngineDamageCheckbox);
            this.groupBox6.Controls.Add(this.CollisionDamageCheckbox);
            this.groupBox6.Controls.Add(this.WeaponDamageCheckbox);
            this.groupBox6.Controls.Add(this.IncreaseGravityCheckbox);
            this.groupBox6.Location = new System.Drawing.Point(23, 265);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(155, 107);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Toggles";
            this.groupBox6.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // EngineDamageCheckbox
            // 
            this.EngineDamageCheckbox.AutoSize = true;
            this.EngineDamageCheckbox.Location = new System.Drawing.Point(12, 42);
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
            this.CollisionDamageCheckbox.Location = new System.Drawing.Point(12, 63);
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
            this.WeaponDamageCheckbox.Location = new System.Drawing.Point(12, 84);
            this.WeaponDamageCheckbox.Name = "WeaponDamageCheckbox";
            this.WeaponDamageCheckbox.Size = new System.Drawing.Size(130, 17);
            this.WeaponDamageCheckbox.TabIndex = 10;
            this.WeaponDamageCheckbox.Text = "No weapon damage";
            this.WeaponDamageCheckbox.UseVisualStyleBackColor = true;
            this.WeaponDamageCheckbox.CheckedChanged += new System.EventHandler(this.WeaponDamageCheckbox_CheckedChanged);
            this.WeaponDamageCheckbox.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // IncreaseGravityCheckbox
            // 
            this.IncreaseGravityCheckbox.AutoSize = true;
            this.IncreaseGravityCheckbox.Location = new System.Drawing.Point(12, 20);
            this.IncreaseGravityCheckbox.Name = "IncreaseGravityCheckbox";
            this.IncreaseGravityCheckbox.Size = new System.Drawing.Size(105, 17);
            this.IncreaseGravityCheckbox.TabIndex = 13;
            this.IncreaseGravityCheckbox.Text = "Increase gravity";
            this.IncreaseGravityCheckbox.UseVisualStyleBackColor = true;
            this.IncreaseGravityCheckbox.CheckedChanged += new System.EventHandler(this.IncreaseGravityCheckbox_CheckedChanged);
            this.IncreaseGravityCheckbox.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.VehicleGravityTrackbar);
            this.groupBox5.Location = new System.Drawing.Point(23, 171);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(293, 69);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gravity";
            this.groupBox5.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "9.8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "0";
            // 
            // VehicleGravityTrackbar
            // 
            this.VehicleGravityTrackbar.LargeChange = 1;
            this.VehicleGravityTrackbar.Location = new System.Drawing.Point(6, 20);
            this.VehicleGravityTrackbar.Name = "VehicleGravityTrackbar";
            this.VehicleGravityTrackbar.Size = new System.Drawing.Size(281, 45);
            this.VehicleGravityTrackbar.TabIndex = 12;
            this.VehicleGravityTrackbar.Scroll += new System.EventHandler(this.VehicleGravityTrackbar_Scroll);
            this.VehicleGravityTrackbar.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.VehicleAccelerationTrackbar);
            this.groupBox4.Location = new System.Drawing.Point(23, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 69);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acceleration";
            this.groupBox4.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "1";
            // 
            // VehicleAccelerationTrackbar
            // 
            this.VehicleAccelerationTrackbar.LargeChange = 1;
            this.VehicleAccelerationTrackbar.Location = new System.Drawing.Point(6, 20);
            this.VehicleAccelerationTrackbar.Minimum = 1;
            this.VehicleAccelerationTrackbar.Name = "VehicleAccelerationTrackbar";
            this.VehicleAccelerationTrackbar.Size = new System.Drawing.Size(281, 45);
            this.VehicleAccelerationTrackbar.TabIndex = 11;
            this.VehicleAccelerationTrackbar.Value = 1;
            this.VehicleAccelerationTrackbar.Scroll += new System.EventHandler(this.VehicleAccelerationTrackbar_Scroll);
            this.VehicleAccelerationTrackbar.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.VehicleHealthTrackbar);
            this.groupBox3.Location = new System.Drawing.Point(23, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 69);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Engine";
            this.groupBox3.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "0";
            // 
            // VehicleHealthTrackbar
            // 
            this.VehicleHealthTrackbar.LargeChange = 1;
            this.VehicleHealthTrackbar.Location = new System.Drawing.Point(6, 20);
            this.VehicleHealthTrackbar.Name = "VehicleHealthTrackbar";
            this.VehicleHealthTrackbar.Size = new System.Drawing.Size(281, 45);
            this.VehicleHealthTrackbar.TabIndex = 7;
            this.VehicleHealthTrackbar.Scroll += new System.EventHandler(this.VehicleHealthTrackbar_Scroll);
            this.VehicleHealthTrackbar.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // SpaceButton
            // 
            this.SpaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpaceButton.Location = new System.Drawing.Point(219, 280);
            this.SpaceButton.Name = "SpaceButton";
            this.SpaceButton.Size = new System.Drawing.Size(75, 23);
            this.SpaceButton.TabIndex = 14;
            this.SpaceButton.Text = "Space";
            this.SpaceButton.UseVisualStyleBackColor = true;
            this.SpaceButton.Click += new System.EventHandler(this.SpaceButton_Click);
            this.SpaceButton.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // DestroyLastUsedButton
            // 
            this.DestroyLastUsedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DestroyLastUsedButton.Location = new System.Drawing.Point(219, 342);
            this.DestroyLastUsedButton.Name = "DestroyLastUsedButton";
            this.DestroyLastUsedButton.Size = new System.Drawing.Size(75, 23);
            this.DestroyLastUsedButton.TabIndex = 8;
            this.DestroyLastUsedButton.Text = "Destroy";
            this.DestroyLastUsedButton.UseVisualStyleBackColor = true;
            this.DestroyLastUsedButton.Click += new System.EventHandler(this.DestroyLastUsedButton_Click);
            this.DestroyLastUsedButton.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(12, 673);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(336, 322);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(360, 1071);
            this.Controls.Add(this.groupBox7);
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGravityTrackbar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleAccelerationTrackbar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleHealthTrackbar)).EndInit();
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
        private System.Windows.Forms.CheckBox IncreaseGravityCheckbox;
        private System.Windows.Forms.Button SpaceButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

