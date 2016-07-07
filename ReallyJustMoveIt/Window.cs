using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReallyJustMoveIt
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            var fullPath = Path.GetFullPath(this.pathTextBox.Text);
            var pathRoot = Path.GetPathRoot(this.pathTextBox.Text);
            var relPath = fullPath.Substring(pathRoot.Length);
            var targetPath = Path.GetFullPath(this.targetTextBox.Text);
            var destinationPath = Path.Combine(targetPath, relPath);

            if (File.Exists(fullPath))
            {
                var directoryName = Path.GetDirectoryName(destinationPath);
                if (!Directory.Exists(directoryName))
                    Directory.CreateDirectory(directoryName);
                File.Move(fullPath, destinationPath);
                Process.Start(destinationPath);
            }
            else if (Directory.Exists(fullPath))
            {
                var directoryName = Path.GetDirectoryName(destinationPath);
                if (!Directory.Exists(directoryName))
                    Directory.CreateDirectory(directoryName);
                Directory.Move(fullPath, destinationPath);
                Process.Start(destinationPath);
            }
            else
            {
                MessageBox.Show(
                    string.Format("No file or directory exists: {0}", fullPath),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
