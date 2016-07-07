namespace ReallyJustMoveIt
{
    partial class Window
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
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target:";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox.Location = new System.Drawing.Point(80, 12);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(549, 31);
            this.pathTextBox.TabIndex = 1;
            // 
            // targetTextBox
            // 
            this.targetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetTextBox.Location = new System.Drawing.Point(80, 49);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(549, 31);
            this.targetTextBox.TabIndex = 2;
            // 
            // moveButton
            // 
            this.moveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.moveButton.Location = new System.Drawing.Point(478, 87);
            this.moveButton.Margin = new System.Windows.Forms.Padding(4);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(150, 32);
            this.moveButton.TabIndex = 6;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Path:";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 140);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Label label2;
    }
}

