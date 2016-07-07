using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustMoveTheDamnThing
{
    public partial class Foo : Form
    {
        public Foo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string ConfigurationFile { get { return Assembly.GetExecutingAssembly().Location + ".targets.txt"; } }

        public string SelectedTarget { get { return (string) this.listBox.SelectedItem; } }

        private void Foo_Load(object sender, EventArgs e)
        {
            if (!File.Exists(ConfigurationFile))
                File.WriteAllLines(ConfigurationFile, new string[0]);
            this.listBox.Items.AddRange(File.ReadAllLines(ConfigurationFile));
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigurationFile);
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            this.listBox.Items.Clear();
            this.listBox.Items.AddRange(File.ReadAllLines(ConfigurationFile));
        }
    }
}
