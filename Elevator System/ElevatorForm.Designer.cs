
namespace Elevator_System
{
    partial class ElevatorForm
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
            this.floorPanel = new System.Windows.Forms.Panel();
            this.directionPb = new System.Windows.Forms.PictureBox();
            this.currentFloorLb = new System.Windows.Forms.Label();
            this.floorsPanel = new System.Windows.Forms.Panel();
            this.emergencyPb = new System.Windows.Forms.PictureBox();
            this.floorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directionPb)).BeginInit();
            this.floorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyPb)).BeginInit();
            this.SuspendLayout();
            // 
            // floorPanel
            // 
            this.floorPanel.BackColor = System.Drawing.Color.Black;
            this.floorPanel.Controls.Add(this.directionPb);
            this.floorPanel.Controls.Add(this.currentFloorLb);
            this.floorPanel.Location = new System.Drawing.Point(215, 29);
            this.floorPanel.Name = "floorPanel";
            this.floorPanel.Size = new System.Drawing.Size(113, 76);
            this.floorPanel.TabIndex = 0;
            // 
            // directionPb
            // 
            this.directionPb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.directionPb.BackColor = System.Drawing.Color.Transparent;
            this.directionPb.Location = new System.Drawing.Point(47, 9);
            this.directionPb.Name = "directionPb";
            this.directionPb.Size = new System.Drawing.Size(52, 56);
            this.directionPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.directionPb.TabIndex = 1;
            this.directionPb.TabStop = false;
            // 
            // currentFloorLb
            // 
            this.currentFloorLb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentFloorLb.BackColor = System.Drawing.Color.Transparent;
            this.currentFloorLb.Font = new System.Drawing.Font("Dogica Pixel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentFloorLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.currentFloorLb.Location = new System.Drawing.Point(0, 0);
            this.currentFloorLb.Name = "currentFloorLb";
            this.currentFloorLb.Size = new System.Drawing.Size(63, 76);
            this.currentFloorLb.TabIndex = 0;
            this.currentFloorLb.Text = "0";
            this.currentFloorLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // floorsPanel
            // 
            this.floorsPanel.BackColor = System.Drawing.Color.Azure;
            this.floorsPanel.Controls.Add(this.emergencyPb);
            this.floorsPanel.Location = new System.Drawing.Point(172, 156);
            this.floorsPanel.Name = "floorsPanel";
            this.floorsPanel.Size = new System.Drawing.Size(198, 396);
            this.floorsPanel.TabIndex = 2;
            this.floorsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FloorsRequesterBorder);
            // 
            // emergencyPb
            // 
            this.emergencyPb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.emergencyPb.BackColor = System.Drawing.Color.Transparent;
            this.emergencyPb.Image = global::Elevator_System.Properties.Resources.emergency_button;
            this.emergencyPb.Location = new System.Drawing.Point(70, 26);
            this.emergencyPb.Name = "emergencyPb";
            this.emergencyPb.Size = new System.Drawing.Size(57, 64);
            this.emergencyPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emergencyPb.TabIndex = 3;
            this.emergencyPb.TabStop = false;
            this.emergencyPb.Click += new System.EventHandler(this.EmergencyStop);
            // 
            // ElevatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(553, 612);
            this.Controls.Add(this.floorsPanel);
            this.Controls.Add(this.floorPanel);
            this.Name = "ElevatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator";
            this.floorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.directionPb)).EndInit();
            this.floorsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emergencyPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel floorPanel;
        private System.Windows.Forms.Label currentFloorLb;
        private System.Windows.Forms.PictureBox directionPb;
        private System.Windows.Forms.Panel floorsPanel;
        private System.Windows.Forms.PictureBox emergencyPb;
    }
}

