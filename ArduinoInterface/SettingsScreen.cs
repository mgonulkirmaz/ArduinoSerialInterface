using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ArduinoInterface.Properties;

namespace ArduinoInterface
{
    public partial class SettingsScreen : Form
    {
        public SettingsScreen()
        {
            InitializeComponent();
        }

        private string portName;
        private string baudRate;
        private char seperator;



        public static readonly List<string> SupportedBaudRates = new List<string>
        {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800"
        };

        public string PortName { get => portName; set => portName = value; }
        public string BaudRate { get => baudRate; set => baudRate = value; }
        public char Seperator { get => seperator; set => seperator = value; }

        private void SettingsScreen_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach(string pt in ports)
            {
                cmPort.Items.Add(pt);
            }

            foreach(string baud in SupportedBaudRates)
            {
                cmBaudRate.Items.Add(baud);
            }

            cmPort.Text = portName;
            cmBaudRate.Text = baudRate;
            txtSeperator.Text = seperator.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmPort.Text != null && cmBaudRate != null && txtSeperator != null)
            {
                Settings.Default.defaultPort = cmPort.Text;
                Settings.Default.defaultBaudRate = cmBaudRate.Text;
                Settings.Default.defaultSeperator = Convert.ToChar(txtSeperator.Text);
                Settings.Default.Save();
            }

            MessageBox.Show("Settings saved succesfully","Settings Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void SettingsScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            ArduinoInterfaceMain frm = new ArduinoInterfaceMain();
            frm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
