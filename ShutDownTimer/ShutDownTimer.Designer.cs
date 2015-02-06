namespace ShutDownTimer
{
    partial class ShutDownTimer
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
            this.DisplayText = new System.Windows.Forms.Label();
            this.ShutDownRadioButton = new System.Windows.Forms.RadioButton();
            this.RestartRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectionBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeValueLabel = new System.Windows.Forms.Label();
            this.TimeBar = new System.Windows.Forms.TrackBar();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.StopShutdown = new System.Windows.Forms.Button();
            this.SelectionBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayText
            // 
            this.DisplayText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayText.Location = new System.Drawing.Point(26, 9);
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.Size = new System.Drawing.Size(427, 40);
            this.DisplayText.TabIndex = 0;
            // 
            // ShutDownRadioButton
            // 
            this.ShutDownRadioButton.AutoSize = true;
            this.ShutDownRadioButton.Location = new System.Drawing.Point(16, 36);
            this.ShutDownRadioButton.Name = "ShutDownRadioButton";
            this.ShutDownRadioButton.Size = new System.Drawing.Size(75, 17);
            this.ShutDownRadioButton.TabIndex = 1;
            this.ShutDownRadioButton.TabStop = true;
            this.ShutDownRadioButton.Text = "ShutDown";
            this.ShutDownRadioButton.UseVisualStyleBackColor = true;
            // 
            // RestartRadioButton
            // 
            this.RestartRadioButton.AutoSize = true;
            this.RestartRadioButton.Location = new System.Drawing.Point(16, 60);
            this.RestartRadioButton.Name = "RestartRadioButton";
            this.RestartRadioButton.Size = new System.Drawing.Size(59, 17);
            this.RestartRadioButton.TabIndex = 2;
            this.RestartRadioButton.TabStop = true;
            this.RestartRadioButton.Text = "Restart";
            this.RestartRadioButton.UseVisualStyleBackColor = true;
            // 
            // SelectionBox
            // 
            this.SelectionBox.Controls.Add(this.ShutDownRadioButton);
            this.SelectionBox.Controls.Add(this.RestartRadioButton);
            this.SelectionBox.Location = new System.Drawing.Point(26, 39);
            this.SelectionBox.Name = "SelectionBox";
            this.SelectionBox.Size = new System.Drawing.Size(194, 94);
            this.SelectionBox.TabIndex = 3;
            this.SelectionBox.TabStop = false;
            this.SelectionBox.Text = "Select One of them";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TimeValueLabel);
            this.groupBox1.Controls.Add(this.TimeBar);
            this.groupBox1.Controls.Add(this.TimeLabel);
            this.groupBox1.Location = new System.Drawing.Point(240, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 94);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "minutes";
            // 
            // TimeValueLabel
            // 
            this.TimeValueLabel.AutoSize = true;
            this.TimeValueLabel.Location = new System.Drawing.Point(91, 35);
            this.TimeValueLabel.Name = "TimeValueLabel";
            this.TimeValueLabel.Size = new System.Drawing.Size(19, 13);
            this.TimeValueLabel.TabIndex = 7;
            this.TimeValueLabel.Text = "60";
            // 
            // TimeBar
            // 
            this.TimeBar.Location = new System.Drawing.Point(10, 60);
            this.TimeBar.Maximum = 60;
            this.TimeBar.Minimum = 1;
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(183, 45);
            this.TimeBar.TabIndex = 6;
            this.TimeBar.Value = 1;
            this.TimeBar.ValueChanged += new System.EventHandler(this.TimeBar_ValueChanged);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(7, 36);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(78, 13);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "Do your stuff in";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(145, 141);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(180, 34);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "Get It Done!";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // StopShutdown
            // 
            this.StopShutdown.Location = new System.Drawing.Point(171, 190);
            this.StopShutdown.Name = "StopShutdown";
            this.StopShutdown.Size = new System.Drawing.Size(124, 33);
            this.StopShutdown.TabIndex = 6;
            this.StopShutdown.Text = "Stop the shutdown";
            this.StopShutdown.UseVisualStyleBackColor = true;
            this.StopShutdown.Click += new System.EventHandler(this.StopShutdown_Click);
            // 
            // ShutDownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 232);
            this.Controls.Add(this.StopShutdown);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectionBox);
            this.Controls.Add(this.DisplayText);
            this.Name = "ShutDownTimer";
            this.Text = "Shutdown Clock";
            this.Load += new System.EventHandler(this.ShutDownTimer_Load);
            this.SelectionBox.ResumeLayout(false);
            this.SelectionBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DisplayText;
        private System.Windows.Forms.RadioButton ShutDownRadioButton;
        private System.Windows.Forms.RadioButton RestartRadioButton;
        private System.Windows.Forms.GroupBox SelectionBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label TimeValueLabel;
        private System.Windows.Forms.TrackBar TimeBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StopShutdown;
    }
}

