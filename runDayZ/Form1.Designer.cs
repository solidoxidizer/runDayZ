namespace runDayZ
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusLabel = new System.Windows.Forms.Label();
            this.checkisActive = new System.Windows.Forms.CheckBox();
            this.labelHotkey = new System.Windows.Forms.Label();
            this.labelDelay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusLabel.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statusLabel.Location = new System.Drawing.Point(0, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusLabel.Size = new System.Drawing.Size(274, 37);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Inactive";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkisActive
            // 
            this.checkisActive.AutoSize = true;
            this.checkisActive.Checked = true;
            this.checkisActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkisActive.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkisActive.Location = new System.Drawing.Point(12, 49);
            this.checkisActive.Name = "checkisActive";
            this.checkisActive.Size = new System.Drawing.Size(85, 30);
            this.checkisActive.TabIndex = 1;
            this.checkisActive.Text = "Active";
            this.checkisActive.UseVisualStyleBackColor = true;
            this.checkisActive.CheckedChanged += new System.EventHandler(this.checkisActive_CheckedChanged);
            // 
            // labelHotkey
            // 
            this.labelHotkey.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotkey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHotkey.Location = new System.Drawing.Point(103, 46);
            this.labelHotkey.Name = "labelHotkey";
            this.labelHotkey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelHotkey.Size = new System.Drawing.Size(136, 24);
            this.labelHotkey.TabIndex = 2;
            this.labelHotkey.Text = "Hotkey : R";
            this.labelHotkey.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDelay
            // 
            this.labelDelay.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDelay.Location = new System.Drawing.Point(103, 70);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelDelay.Size = new System.Drawing.Size(136, 24);
            this.labelDelay.TabIndex = 3;
            this.labelDelay.Text = "Delay : 16ms";
            this.labelDelay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 91);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.labelHotkey);
            this.Controls.Add(this.checkisActive);
            this.Controls.Add(this.statusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DayZ Run";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox checkisActive;
        private System.Windows.Forms.Label labelHotkey;
        private System.Windows.Forms.Label labelDelay;
    }
}

