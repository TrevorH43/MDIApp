namespace MDIApp
{
    partial class NameSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.boyNameTextBox = new System.Windows.Forms.TextBox();
            this.girlNameTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a boy\'s name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter a girl\'s name:";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(226, 227);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(35, 13);
            this.resultsLabel.TabIndex = 4;
            this.resultsLabel.Text = "label3";
            // 
            // boyNameTextBox
            // 
            this.boyNameTextBox.Location = new System.Drawing.Point(350, 103);
            this.boyNameTextBox.Name = "boyNameTextBox";
            this.boyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.boyNameTextBox.TabIndex = 5;
            // 
            // girlNameTextBox
            // 
            this.girlNameTextBox.Location = new System.Drawing.Point(350, 139);
            this.girlNameTextBox.Name = "girlNameTextBox";
            this.girlNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.girlNameTextBox.TabIndex = 6;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(417, 217);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 7;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // NameSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.girlNameTextBox);
            this.Controls.Add(this.boyNameTextBox);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NameSearch";
            this.Text = "NameSearch";
            this.Load += new System.EventHandler(this.NameSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.TextBox boyNameTextBox;
        private System.Windows.Forms.TextBox girlNameTextBox;
        private System.Windows.Forms.Button checkButton;
    }
}