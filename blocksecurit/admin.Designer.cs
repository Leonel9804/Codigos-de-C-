namespace blocksecurit
{
    partial class admin
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
            this.lblmensajeadmin = new System.Windows.Forms.Label();
            this.lbladmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmensajeadmin
            // 
            this.lblmensajeadmin.AutoSize = true;
            this.lblmensajeadmin.Location = new System.Drawing.Point(381, 356);
            this.lblmensajeadmin.Name = "lblmensajeadmin";
            this.lblmensajeadmin.Size = new System.Drawing.Size(0, 13);
            this.lblmensajeadmin.TabIndex = 0;
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Location = new System.Drawing.Point(356, 266);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(69, 13);
            this.lbladmin.TabIndex = 1;
            this.lbladmin.Text = "administrador";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbladmin);
            this.Controls.Add(this.lblmensajeadmin);
            this.Name = "admin";
            this.Text = "admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensajeadmin;
        private System.Windows.Forms.Label lbladmin;
    }
}