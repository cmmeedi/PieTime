namespace Exercise_5
{
    partial class PieTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PieTime));
            this.NumberOfTermsTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfTermsLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ApproximateValueResult = new System.Windows.Forms.Label();
            this.CalculateResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumberOfTermsTextBox
            // 
            this.NumberOfTermsTextBox.Location = new System.Drawing.Point(112, 6);
            this.NumberOfTermsTextBox.Name = "NumberOfTermsTextBox";
            this.NumberOfTermsTextBox.Size = new System.Drawing.Size(144, 20);
            this.NumberOfTermsTextBox.TabIndex = 0;
            this.NumberOfTermsTextBox.TextChanged += new System.EventHandler(this.NumberOfTermsTextBox_TextChanged);
            // 
            // NumberOfTermsLabel
            // 
            this.NumberOfTermsLabel.AutoSize = true;
            this.NumberOfTermsLabel.Location = new System.Drawing.Point(12, 9);
            this.NumberOfTermsLabel.Name = "NumberOfTermsLabel";
            this.NumberOfTermsLabel.Size = new System.Drawing.Size(89, 13);
            this.NumberOfTermsLabel.TabIndex = 1;
            this.NumberOfTermsLabel.Text = "Enter # of Terms:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(26, 46);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ApproximateValueResult
            // 
            this.ApproximateValueResult.Location = new System.Drawing.Point(23, 92);
            this.ApproximateValueResult.Name = "ApproximateValueResult";
            this.ApproximateValueResult.Size = new System.Drawing.Size(233, 23);
            this.ApproximateValueResult.TabIndex = 3;
            this.ApproximateValueResult.Click += new System.EventHandler(this.ApproximateValueResult_Click);
            // 
            // CalculateResult
            // 
            this.CalculateResult.Location = new System.Drawing.Point(23, 136);
            this.CalculateResult.Name = "CalculateResult";
            this.CalculateResult.Size = new System.Drawing.Size(233, 27);
            this.CalculateResult.TabIndex = 4;
            this.CalculateResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // PieTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 173);
            this.Controls.Add(this.CalculateResult);
            this.Controls.Add(this.ApproximateValueResult);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.NumberOfTermsLabel);
            this.Controls.Add(this.NumberOfTermsTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PieTime";
            this.Text = "PieTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberOfTermsTextBox;
        private System.Windows.Forms.Label NumberOfTermsLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label ApproximateValueResult;
        private System.Windows.Forms.Label CalculateResult;
    }
}

