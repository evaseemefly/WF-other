namespace Wxwinter.Test.Statements
{
    partial class testForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.bookmarkTextBox = new System.Windows.Forms.TextBox();
            this.bookmarkLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.valueComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "启动";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // bookmarkTextBox
            // 
            this.bookmarkTextBox.Location = new System.Drawing.Point(89, 56);
            this.bookmarkTextBox.Name = "bookmarkTextBox";
            this.bookmarkTextBox.Size = new System.Drawing.Size(121, 21);
            this.bookmarkTextBox.TabIndex = 1;
            this.bookmarkTextBox.Text = "wxwinter";
            // 
            // bookmarkLabel
            // 
            this.bookmarkLabel.AutoSize = true;
            this.bookmarkLabel.Location = new System.Drawing.Point(17, 59);
            this.bookmarkLabel.Name = "bookmarkLabel";
            this.bookmarkLabel.Size = new System.Drawing.Size(53, 12);
            this.bookmarkLabel.TabIndex = 3;
            this.bookmarkLabel.Text = "bookmark";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(19, 104);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(17, 12);
            this.valueLabel.TabIndex = 4;
            this.valueLabel.Text = "值";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(135, 143);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "提交";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // valueComboBox
            // 
            this.valueComboBox.FormattingEnabled = true;
            this.valueComboBox.Location = new System.Drawing.Point(89, 96);
            this.valueComboBox.Name = "valueComboBox";
            this.valueComboBox.Size = new System.Drawing.Size(121, 20);
            this.valueComboBox.TabIndex = 6;
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 180);
            this.Controls.Add(this.valueComboBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.bookmarkLabel);
            this.Controls.Add(this.bookmarkTextBox);
            this.Controls.Add(this.startButton);
            this.Name = "testForm";
            this.Text = "testForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox bookmarkTextBox;
        private System.Windows.Forms.Label bookmarkLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox valueComboBox;
    }
}