﻿namespace EnrageR
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
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            this.GodModeCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AutoHealTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.MarqueeLabel.Location = new System.Drawing.Point(212, 460);
            this.MarqueeLabel.Name = "MarqueeLabel";
            this.MarqueeLabel.Size = new System.Drawing.Size(196, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teleport";
            this.groupBox1.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // TeleportButton
            // 
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
            this.groupBox2.Controls.Add(this.AutoHealTextbox);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.GodModeCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 71);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Health";
            this.groupBox2.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // CloseTimer
            // 
            this.CloseTimer.Interval = 1000;
            this.CloseTimer.Tick += new System.EventHandler(this.CloseTimer_Tick);
            // 
            // GodModeCheckBox
            // 
            this.GodModeCheckBox.AutoSize = true;
            this.GodModeCheckBox.Location = new System.Drawing.Point(23, 21);
            this.GodModeCheckBox.Name = "GodModeCheckBox";
            this.GodModeCheckBox.Size = new System.Drawing.Size(165, 17);
            this.GodModeCheckBox.TabIndex = 0;
            this.GodModeCheckBox.Text = "Auto-heal every               ms";
            this.GodModeCheckBox.UseVisualStyleBackColor = true;
            this.GodModeCheckBox.CheckedChanged += new System.EventHandler(this.GodModeCheckBox_CheckedChanged);
            this.GodModeCheckBox.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Extreme godmode (RISKY)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AutoHealTextbox
            // 
            this.AutoHealTextbox.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoHealTextbox.Location = new System.Drawing.Point(128, 20);
            this.AutoHealTextbox.Name = "AutoHealTextbox";
            this.AutoHealTextbox.Size = new System.Drawing.Size(31, 19);
            this.AutoHealTextbox.TabIndex = 2;
            this.AutoHealTextbox.Text = "100";
            this.AutoHealTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AutoHealTextbox.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(360, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MarqueeLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnrageR | Pre-Release BUILD 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseHover += new System.EventHandler(this.OnHover);
            ((System.ComponentModel.ISupportInitialize)(this.ExitImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.CheckBox GodModeCheckBox;
        private System.Windows.Forms.TextBox AutoHealTextbox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

