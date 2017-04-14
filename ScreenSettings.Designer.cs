namespace WorkScreenSaver
{
    partial class ScreenSettings
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
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnMeeting = new System.Windows.Forms.Button();
            this.btnServerRoom = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnEngineering = new System.Windows.Forms.Button();
            this.btnQuality = new System.Windows.Forms.Button();
            this.btnMangement = new System.Windows.Forms.Button();
            this.btnProduction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(49, 10);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(218, 25);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Select Your Location:";
            // 
            // btnLunch
            // 
            this.btnLunch.Location = new System.Drawing.Point(93, 37);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(130, 30);
            this.btnLunch.TabIndex = 1;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = true;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // btnMeeting
            // 
            this.btnMeeting.Location = new System.Drawing.Point(93, 73);
            this.btnMeeting.Name = "btnMeeting";
            this.btnMeeting.Size = new System.Drawing.Size(130, 30);
            this.btnMeeting.TabIndex = 2;
            this.btnMeeting.Text = "Meeting";
            this.btnMeeting.UseVisualStyleBackColor = true;
            this.btnMeeting.Click += new System.EventHandler(this.btnMeeting_Click);
            // 
            // btnServerRoom
            // 
            this.btnServerRoom.Location = new System.Drawing.Point(93, 109);
            this.btnServerRoom.Name = "btnServerRoom";
            this.btnServerRoom.Size = new System.Drawing.Size(130, 30);
            this.btnServerRoom.TabIndex = 3;
            this.btnServerRoom.Text = "Server Room";
            this.btnServerRoom.UseVisualStyleBackColor = true;
            this.btnServerRoom.Click += new System.EventHandler(this.btnServerRoom_Click);
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(93, 145);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(130, 30);
            this.btnService.TabIndex = 4;
            this.btnService.Text = "Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnEngineering
            // 
            this.btnEngineering.Location = new System.Drawing.Point(93, 181);
            this.btnEngineering.Name = "btnEngineering";
            this.btnEngineering.Size = new System.Drawing.Size(130, 30);
            this.btnEngineering.TabIndex = 5;
            this.btnEngineering.Text = "Engineering";
            this.btnEngineering.UseVisualStyleBackColor = true;
            this.btnEngineering.Click += new System.EventHandler(this.btnEngineering_Click);
            // 
            // btnQuality
            // 
            this.btnQuality.Location = new System.Drawing.Point(93, 217);
            this.btnQuality.Name = "btnQuality";
            this.btnQuality.Size = new System.Drawing.Size(130, 30);
            this.btnQuality.TabIndex = 6;
            this.btnQuality.Text = "Quality";
            this.btnQuality.UseVisualStyleBackColor = true;
            this.btnQuality.Click += new System.EventHandler(this.btnQuality_Click);
            // 
            // btnMangement
            // 
            this.btnMangement.Location = new System.Drawing.Point(93, 253);
            this.btnMangement.Name = "btnMangement";
            this.btnMangement.Size = new System.Drawing.Size(130, 30);
            this.btnMangement.TabIndex = 7;
            this.btnMangement.Text = "Management";
            this.btnMangement.UseVisualStyleBackColor = true;
            this.btnMangement.Click += new System.EventHandler(this.btnMangement_Click);
            // 
            // btnProduction
            // 
            this.btnProduction.Location = new System.Drawing.Point(93, 289);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(130, 30);
            this.btnProduction.TabIndex = 8;
            this.btnProduction.Text = "Production";
            this.btnProduction.UseVisualStyleBackColor = true;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            // 
            // ScreenSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 330);
            this.Controls.Add(this.btnProduction);
            this.Controls.Add(this.btnMangement);
            this.Controls.Add(this.btnQuality);
            this.Controls.Add(this.btnEngineering);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnServerRoom);
            this.Controls.Add(this.btnMeeting);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.lblLocation);
            this.Name = "ScreenSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnMeeting;
        private System.Windows.Forms.Button btnServerRoom;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnEngineering;
        private System.Windows.Forms.Button btnQuality;
        private System.Windows.Forms.Button btnMangement;
        private System.Windows.Forms.Button btnProduction;
    }
}

