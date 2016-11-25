using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace SerialViewer
{
    class Serial
    {
        public List<String> portsList;
        public Dictionary<int, string> parityList = new Dictionary<int, string>();
        public SerialPort port;
        public string dataBuffer;

        public BackgroundWorker worker = new BackgroundWorker();

        public Serial()
        {
            // try getting the list of ports
            this.RefreshPorts();

            // if there aren't any, warn the user
            if(this.portsList.Count == 0)
            {
                MessageBox.Show("No COM ports were found! Please connect your device and click Refresh.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // populate various combo boxes
            foreach (int baud in Constants.baudList)
                Program.mainForm.baudBox.Items.Add(baud);
            Program.mainForm.baudBox.SelectedIndex = 0;

            int i = 0;

            Program.mainForm.parityBox.Items.AddRange(Constants.parityList);
            Program.mainForm.parityBox.SelectedIndex = 0;

            foreach (string parity in Constants.parityList)
            {
                this.parityList.Add(i++, parity);
            }
        }

        public void RefreshPorts()
        {
            // create a list of ports available in the system
            this.portsList = new List<String>();

            foreach (string port in SerialPort.GetPortNames())
                this.portsList.Add(port);

            this.portsList.Sort();
            Program.mainForm.portBox.Items.AddRange(this.portsList.ToArray());
        }

        public void ConnectAndRead()
        {
            // initialize the port

            this.port = new SerialPort();
            this.port.PortName = Program.mainForm.portBox.SelectedItem.ToString();
            this.port.BaudRate = (int) Program.mainForm.baudBox.SelectedItem;
            this.port.Parity = (Parity) Program.mainForm.parityBox.SelectedIndex;
            int dataBits = 0;
            int.TryParse(Program.mainForm.databitsBox.Text, out dataBits);
            this.port.DataBits = dataBits;
            this.port.StopBits = StopBits.One;

            this.port.ReadTimeout = 500;
            this.port.WriteTimeout = 500;
            
            this.port.Open();
            
            // now create a worker so we can read from the port and update the UI without freezing
            worker.DoWork += delegate (object s, DoWorkEventArgs args)
            {
                while (true)
                {
                    if (port.BytesToRead <= 0)
                    {
                        // do nothing if there is nothing to read
                    }
                    else
                    {
                        // append the newly read data to the buffer and update the UI
                        this.dataBuffer += this.port.ReadLine() + Environment.NewLine;
                        Program.mainForm.UpdateViewerBox(dataBuffer);
                    }
                }
            };

            worker.RunWorkerAsync();
        }

        // stop the worker and close the port
        public void Stop()
        {
            this.worker.CancelAsync();
            this.port.Close();
        }

    }
}
