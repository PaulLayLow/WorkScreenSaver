namespace WorkScreenSaver
{
    partial class Background
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
            this.lblLocation = new System.Windows.Forms.Label();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLocation.Location = new System.Drawing.Point(12, 53);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(299, 108);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "label1";
            // 
            // Background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Background";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Background";
            this.Load += new System.EventHandler(this.Background_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Background_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Background_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Background_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Timer moveTimer;
    }
}