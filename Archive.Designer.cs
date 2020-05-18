namespace assignment_club_
{
    partial class Archive
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
            this.lstarchive = new System.Windows.Forms.ListBox();
            this.btnview = new System.Windows.Forms.Button();
            this.btnreactivate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstarchive
            // 
            this.lstarchive.FormattingEnabled = true;
            this.lstarchive.ItemHeight = 16;
            this.lstarchive.Location = new System.Drawing.Point(148, 39);
            this.lstarchive.Name = "lstarchive";
            this.lstarchive.Size = new System.Drawing.Size(608, 292);
            this.lstarchive.TabIndex = 0;
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btnview.FlatAppearance.BorderSize = 0;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(651, 365);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(105, 54);
            this.btnview.TabIndex = 1;
            this.btnview.Text = "View Club";
            this.btnview.UseVisualStyleBackColor = false;
            // 
            // btnreactivate
            // 
            this.btnreactivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btnreactivate.FlatAppearance.BorderSize = 0;
            this.btnreactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreactivate.ForeColor = System.Drawing.Color.White;
            this.btnreactivate.Location = new System.Drawing.Point(514, 365);
            this.btnreactivate.Name = "btnreactivate";
            this.btnreactivate.Size = new System.Drawing.Size(106, 54);
            this.btnreactivate.TabIndex = 2;
            this.btnreactivate.Text = "Reactivate";
            this.btnreactivate.UseVisualStyleBackColor = false;
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreactivate);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.lstarchive);
            this.Name = "Archive";
            this.Text = "Archived Club";
            this.Load += new System.EventHandler(this.Archive_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstarchive;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnreactivate;
    }
}