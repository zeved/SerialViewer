using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(databitsBox.Text))
            {
                MessageBox.Show("Data bits box is empty! Defaulting to 8 bits.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.databitsBox.Text = "8";
            }

            if (Program.serial.portsList.Count == 0)
            {
                MessageBox.Show("No COM ports found! Nothing to connect to!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                Program.serial.ConnectAndRead();
        }

        public delegate void UpdateText(string text);

        public void UpdateViewerBox(string data)
        {
            if (viewerBox.InvokeRequired)
            {
                viewerBox.Invoke(new UpdateText(this.UpdateViewerBox),
                new object[] { data });
            }
            
            viewerBox.Text = data;
            
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            Program.serial.Stop();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.viewerBox.Clear();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Program.serial.RefreshPorts();
        }
    }
}
