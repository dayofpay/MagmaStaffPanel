namespace MagmaStaffPanel
{
    partial class checkPoints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkPoints));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.statusBox = new System.Windows.Forms.Label();
            this.continueButton = new Guna.UI2.WinForms.Guna2Button();
            this.label25 = new System.Windows.Forms.Label();
            this.userBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.staff = new System.Windows.Forms.ListBox();
            this.status = new System.Windows.Forms.Label();
            this.date_removed = new System.Windows.Forms.ListBox();
            this.remove_reason = new System.Windows.Forms.ListBox();
            this.removed_by = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.staffLabel = new System.Windows.Forms.Label();
            this.removeDateLabel = new System.Windows.Forms.Label();
            this.removeReasonlabel = new System.Windows.Forms.Label();
            this.removedBylabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // statusBox
            // 
            this.statusBox.AutoSize = true;
            this.statusBox.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.statusBox.ForeColor = System.Drawing.Color.Green;
            this.statusBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusBox.Location = new System.Drawing.Point(392, 107);
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
            this.continueButton.Location = new System.Drawing.Point(14, 107);
            this.continueButton.Name = "continueButton";
            this.continueButton.ShadowDecoration.Parent = this.continueButton;
            this.continueButton.Size = new System.Drawing.Size(433, 45);
            this.continueButton.TabIndex = 176;
            this.continueButton.Text = "Продължи";
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label25.Location = new System.Drawing.Point(11, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 18);
            this.label25.TabIndex = 171;
            this.label25.Text = "ЕКИП:";
            // 
            // userBox
            // 
            this.userBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userBox.DefaultText = "";
            this.userBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userBox.DisabledState.Parent = this.userBox;
            this.userBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userBox.FocusedState.Parent = this.userBox;
            this.userBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userBox.HoverState.Parent = this.userBox;
            this.userBox.Location = new System.Drawing.Point(79, 12);
            this.userBox.Name = "userBox";
            this.userBox.PasswordChar = '\0';
            this.userBox.PlaceholderText = "";
            this.userBox.SelectedText = "";
            this.userBox.ShadowDecoration.Parent = this.userBox;
            this.userBox.Size = new System.Drawing.Size(200, 18);
            this.userBox.TabIndex = 170;
            // 
            // staff
            // 
            this.staff.BackColor = System.Drawing.Color.Turquoise;
            this.staff.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff.ForeColor = System.Drawing.Color.Blue;
            this.staff.FormattingEnabled = true;
            this.staff.ItemHeight = 24;
            this.staff.Location = new System.Drawing.Point(14, 247);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(268, 124);
            this.staff.TabIndex = 178;
            this.staff.Visible = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.status.Location = new System.Drawing.Point(39, 86);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 18);
            this.status.TabIndex = 179;
            // 
            // date_removed
            // 
            this.date_removed.BackColor = System.Drawing.Color.Turquoise;
            this.date_removed.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_removed.ForeColor = System.Drawing.Color.Blue;
            this.date_removed.FormattingEnabled = true;
            this.date_removed.ItemHeight = 24;
            this.date_removed.Location = new System.Drawing.Point(310, 247);
            this.date_removed.Name = "date_removed";
            this.date_removed.Size = new System.Drawing.Size(268, 124);
            this.date_removed.TabIndex = 180;
            this.date_removed.Visible = false;
            // 
            // remove_reason
            // 
            this.remove_reason.BackColor = System.Drawing.Color.Turquoise;
            this.remove_reason.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_reason.ForeColor = System.Drawing.Color.Blue;
            this.remove_reason.FormattingEnabled = true;
            this.remove_reason.ItemHeight = 24;
            this.remove_reason.Location = new System.Drawing.Point(603, 247);
            this.remove_reason.Name = "remove_reason";
            this.remove_reason.Size = new System.Drawing.Size(268, 124);
            this.remove_reason.TabIndex = 181;
            this.remove_reason.Visible = false;
            // 
            // removed_by
            // 
            this.removed_by.BackColor = System.Drawing.Color.Turquoise;
            this.removed_by.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removed_by.ForeColor = System.Drawing.Color.Blue;
            this.removed_by.FormattingEnabled = true;
            this.removed_by.ItemHeight = 24;
            this.removed_by.Location = new System.Drawing.Point(877, 247);
            this.removed_by.Name = "removed_by";
            this.removed_by.Size = new System.Drawing.Size(268, 124);
            this.removed_by.TabIndex = 182;
            this.removed_by.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(555, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 183;
            this.label1.Text = "LOGS: ";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1012, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 184;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // staffLabel
            // 
            this.staffLabel.AutoSize = true;
            this.staffLabel.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.staffLabel.ForeColor = System.Drawing.Color.Red;
            this.staffLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.staffLabel.Location = new System.Drawing.Point(23, 211);
            this.staffLabel.Name = "staffLabel";
            this.staffLabel.Size = new System.Drawing.Size(45, 18);
            this.staffLabel.TabIndex = 185;
            this.staffLabel.Text = "Staff:";
            this.staffLabel.Visible = false;
            // 
            // removeDateLabel
            // 
            this.removeDateLabel.AutoSize = true;
            this.removeDateLabel.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.removeDateLabel.ForeColor = System.Drawing.Color.Red;
            this.removeDateLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.removeDateLabel.Location = new System.Drawing.Point(322, 211);
            this.removeDateLabel.Name = "removeDateLabel";
            this.removeDateLabel.Size = new System.Drawing.Size(163, 18);
            this.removeDateLabel.TabIndex = 186;
            this.removeDateLabel.Text = "Дата на премахване";
            this.removeDateLabel.Visible = false;
            // 
            // removeReasonlabel
            // 
            this.removeReasonlabel.AutoSize = true;
            this.removeReasonlabel.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.removeReasonlabel.ForeColor = System.Drawing.Color.Red;
            this.removeReasonlabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.removeReasonlabel.Location = new System.Drawing.Point(680, 211);
            this.removeReasonlabel.Name = "removeReasonlabel";
            this.removeReasonlabel.Size = new System.Drawing.Size(74, 18);
            this.removeReasonlabel.TabIndex = 187;
            this.removeReasonlabel.Text = "Причина";
            this.removeReasonlabel.Visible = false;
            // 
            // removedBylabel
            // 
            this.removedBylabel.AutoSize = true;
            this.removedBylabel.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.removedBylabel.ForeColor = System.Drawing.Color.Red;
            this.removedBylabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.removedBylabel.Location = new System.Drawing.Point(935, 211);
            this.removedBylabel.Name = "removedBylabel";
            this.removedBylabel.Size = new System.Drawing.Size(132, 18);
            this.removedBylabel.TabIndex = 188;
            this.removedBylabel.Text = "Премахната от";
            this.removedBylabel.Visible = false;
            // 
            // checkPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1189, 602);
            this.Controls.Add(this.removedBylabel);
            this.Controls.Add(this.removeReasonlabel);
            this.Controls.Add(this.removeDateLabel);
            this.Controls.Add(this.staffLabel);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removed_by);
            this.Controls.Add(this.remove_reason);
            this.Controls.Add(this.date_removed);
            this.Controls.Add(this.status);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.userBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "checkPoints";
            this.Text = "checkPoints";
            this.Load += new System.EventHandler(this.checkPoints_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label statusBox;
        private Guna.UI2.WinForms.Guna2Button continueButton;
        private System.Windows.Forms.Label label25;
        private Guna.UI2.WinForms.Guna2TextBox userBox;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ListBox staff;
        private System.Windows.Forms.ListBox removed_by;
        private System.Windows.Forms.ListBox remove_reason;
        private System.Windows.Forms.ListBox date_removed;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label removedBylabel;
        private System.Windows.Forms.Label removeReasonlabel;
        private System.Windows.Forms.Label removeDateLabel;
        private System.Windows.Forms.Label staffLabel;
    }
}