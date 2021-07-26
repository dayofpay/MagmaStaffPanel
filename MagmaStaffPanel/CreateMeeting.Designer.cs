namespace MagmaStaffPanel
{
    partial class CreateMeeting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateMeeting));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dateTimepick = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.statusBox = new System.Windows.Forms.Label();
            this.continueButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.povod = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hour1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hour2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // dateTimepick
            // 
            this.dateTimepick.BackColor = System.Drawing.Color.Transparent;
            this.dateTimepick.CheckedState.Parent = this.dateTimepick;
            this.dateTimepick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimepick.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimepick.HoverState.Parent = this.dateTimepick;
            this.dateTimepick.Location = new System.Drawing.Point(94, 108);
            this.dateTimepick.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimepick.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimepick.Name = "dateTimepick";
            this.dateTimepick.ShadowDecoration.Parent = this.dateTimepick;
            this.dateTimepick.Size = new System.Drawing.Size(200, 34);
            this.dateTimepick.TabIndex = 0;
            this.dateTimepick.Value = new System.DateTime(2021, 7, 27, 1, 14, 13, 244);
            // 
            // statusBox
            // 
            this.statusBox.AutoSize = true;
            this.statusBox.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.statusBox.ForeColor = System.Drawing.Color.Green;
            this.statusBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusBox.Location = new System.Drawing.Point(393, 108);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(0, 18);
            this.statusBox.TabIndex = 177;
            // 
            // continueButton
            // 
            this.continueButton.CheckedState.Parent = this.continueButton;
            this.continueButton.CustomImages.Parent = this.continueButton;
            this.continueButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.continueButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.continueButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.continueButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.continueButton.DisabledState.Parent = this.continueButton;
            this.continueButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.HoverState.Parent = this.continueButton;
            this.continueButton.Location = new System.Drawing.Point(15, 175);
            this.continueButton.Name = "continueButton";
            this.continueButton.ShadowDecoration.Parent = this.continueButton;
            this.continueButton.Size = new System.Drawing.Size(433, 45);
            this.continueButton.TabIndex = 176;
            this.continueButton.Text = "Продължи";
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 174;
            this.label2.Text = "Дата";
            // 
            // povod
            // 
            this.povod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.povod.DefaultText = "";
            this.povod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.povod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.povod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.povod.DisabledState.Parent = this.povod;
            this.povod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.povod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.povod.FocusedState.Parent = this.povod;
            this.povod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.povod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.povod.HoverState.Parent = this.povod;
            this.povod.Location = new System.Drawing.Point(166, 57);
            this.povod.Name = "povod";
            this.povod.PasswordChar = '\0';
            this.povod.PlaceholderText = "";
            this.povod.SelectedText = "";
            this.povod.ShadowDecoration.Parent = this.povod;
            this.povod.Size = new System.Drawing.Size(200, 18);
            this.povod.TabIndex = 173;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 172;
            this.label1.Text = "Повод на събрание";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusLabel.Location = new System.Drawing.Point(172, 295);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 18);
            this.statusLabel.TabIndex = 178;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(743, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 185;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 186;
            this.label3.Text = "Час";
            // 
            // hour1
            // 
            this.hour1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hour1.DefaultText = "";
            this.hour1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hour1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hour1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hour1.DisabledState.Parent = this.hour1;
            this.hour1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hour1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hour1.FocusedState.Parent = this.hour1;
            this.hour1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hour1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hour1.HoverState.Parent = this.hour1;
            this.hour1.Location = new System.Drawing.Point(166, 154);
            this.hour1.MaxLength = 2;
            this.hour1.Name = "hour1";
            this.hour1.PasswordChar = '\0';
            this.hour1.PlaceholderText = "";
            this.hour1.SelectedText = "";
            this.hour1.ShadowDecoration.Parent = this.hour1;
            this.hour1.Size = new System.Drawing.Size(36, 18);
            this.hour1.TabIndex = 187;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(208, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 18);
            this.label4.TabIndex = 188;
            this.label4.Text = ":";
            // 
            // hour2
            // 
            this.hour2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hour2.DefaultText = "";
            this.hour2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hour2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hour2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hour2.DisabledState.Parent = this.hour2;
            this.hour2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hour2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hour2.FocusedState.Parent = this.hour2;
            this.hour2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hour2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hour2.HoverState.Parent = this.hour2;
            this.hour2.Location = new System.Drawing.Point(226, 154);
            this.hour2.MaxLength = 2;
            this.hour2.Name = "hour2";
            this.hour2.PasswordChar = '\0';
            this.hour2.PlaceholderText = "";
            this.hour2.SelectedText = "";
            this.hour2.ShadowDecoration.Parent = this.hour2;
            this.hour2.Size = new System.Drawing.Size(40, 18);
            this.hour2.TabIndex = 189;
            // 
            // CreateMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hour2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hour1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.povod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimepick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateMeeting";
            this.Text = "CreateMeeting";
            this.Load += new System.EventHandler(this.CreateMeeting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimepick;
        private System.Windows.Forms.Label statusBox;
        private Guna.UI2.WinForms.Guna2Button continueButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox povod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusLabel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox hour2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox hour1;
        private System.Windows.Forms.Label label3;
    }
}