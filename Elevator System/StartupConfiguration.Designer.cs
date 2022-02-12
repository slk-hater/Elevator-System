namespace Elevator_System
{
    partial class StartupConfiguration
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
            this.startBtn = new System.Windows.Forms.Button();
            this.floorsAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.stopTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.floorsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopTime)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.BackColor = System.Drawing.Color.Silver;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Location = new System.Drawing.Point(167, 196);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.StartClick);
            // 
            // floorsAmount
            // 
            this.floorsAmount.BackColor = System.Drawing.Color.Silver;
            this.floorsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorsAmount.Location = new System.Drawing.Point(193, 29);
            this.floorsAmount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.floorsAmount.Name = "floorsAmount";
            this.floorsAmount.Size = new System.Drawing.Size(47, 29);
            this.floorsAmount.TabIndex = 1;
            this.floorsAmount.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of floors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Speed";
            // 
            // speed
            // 
            this.speed.BackColor = System.Drawing.Color.Silver;
            this.speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed.Location = new System.Drawing.Point(193, 85);
            this.speed.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(47, 29);
            this.speed.TabIndex = 3;
            this.speed.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stop time";
            // 
            // stopTime
            // 
            this.stopTime.BackColor = System.Drawing.Color.Silver;
            this.stopTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopTime.Location = new System.Drawing.Point(193, 140);
            this.stopTime.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.stopTime.Name = "stopTime";
            this.stopTime.Size = new System.Drawing.Size(47, 29);
            this.stopTime.TabIndex = 5;
            this.stopTime.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // StartupConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(254, 231);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stopTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.floorsAmount);
            this.Controls.Add(this.startBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartupConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartupConfiguration";
            ((System.ComponentModel.ISupportInitialize)(this.floorsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.NumericUpDown floorsAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown speed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown stopTime;
    }
}