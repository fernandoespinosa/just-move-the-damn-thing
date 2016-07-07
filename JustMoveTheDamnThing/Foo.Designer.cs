namespace JustMoveTheDamnThing
{
    partial class Foo
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
            this.label = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 9);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(457, 18);
            this.label.TabIndex = 1;
            this.label.Text = "Select the damn location where all this shebang is gonna go:";
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(16, 30);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(828, 274);
            this.listBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(535, 325);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 32);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // configButton
            // 
            this.configButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.configButton.Location = new System.Drawing.Point(16, 325);
            this.configButton.Margin = new System.Windows.Forms.Padding(4);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(150, 32);
            this.configButton.TabIndex = 4;
            this.configButton.Text = "Config";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.startButton.Location = new System.Drawing.Point(693, 325);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 32);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // reloadButton
            // 
            this.reloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reloadButton.Location = new System.Drawing.Point(174, 325);
            this.reloadButton.Margin = new System.Windows.Forms.Padding(4);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(150, 32);
            this.reloadButton.TabIndex = 6;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // Foo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 370);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Foo";
            this.Load += new System.EventHandler(this.Foo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button reloadButton;
    }
}