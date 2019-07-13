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
    public partial class ArduinoInterfaceMain : Form
    {
        Arduino arduino = new Arduino(Settings.Default.defaultPort,Settings.Default.defaultBaudRate,Settings.Default.defaultSeperator);
        SerialPort arduinoConnection = new SerialPort();
        //Timer checkTimer = new Timer();

        public ArduinoInterfaceMain()
        {
            InitializeComponent();
        }

        private void ArduinoInterfaceMain_Load(object sender, EventArgs e)
        {
            arduino.ConnectionPort = Settings.Default.defaultPort;
            arduino.BaudRate = Settings.Default.defaultBaudRate;
            arduino.Seperator = Settings.Default.defaultSeperator;

            //checkTimer.Interval = 1000;
            //checkTimer.Tick += new EventHandler(checkConnection);
            //checkTimer.Start();

            statusPort.Text = arduino.ConnectionPort;
            statusBaudRate.Text = arduino.BaudRate;
            statusConState.Alignment = ToolStripItemAlignment.Right;
            statusConState.Text = "DISCONNECTED";
            statusConState.ForeColor = Color.Red;
        }

        private void checkConnection(object sender, EventArgs e)
        {
            if (arduinoConnection.IsOpen)
            {
                btnConnect.Text = "DISCONNECT";
                btnConnect.ForeColor = Color.Red;
                statusConState.Text = "CONNECTED";
                statusConState.ForeColor = Color.ForestGreen;
            }
            else
            {
                btnConnect.Text = "CONNECT";
                btnConnect.ForeColor = Color.ForestGreen;
                statusConState.Text = "DISCONNECTED";
                statusConState.ForeColor = Color.Red;
            }
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SettingsScreen frm = new SettingsScreen();            
            frm.PortName = arduino.ConnectionPort;
            frm.BaudRate = arduino.BaudRate;
            frm.Seperator = arduino.Seperator;
            frm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (arduinoConnection.IsOpen)
            {
                arduinoConnection.DiscardInBuffer();
                arduinoConnection.Close();
            }
            Application.Exit();
        }

        private void ArduinoInterfaceMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (arduinoConnection.IsOpen)
            {
                arduinoConnection.DiscardInBuffer();
                arduinoConnection.Close();
            }
            Application.Exit();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {                      
            if (!arduinoConnection.IsOpen)
            {
                arduinoConnection.PortName = arduino.ConnectionPort;
                arduinoConnection.BaudRate = Convert.ToInt32(arduino.BaudRate);
                arduinoConnection.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
                arduinoConnection.Open();

                if (arduinoConnection.IsOpen)
                {
                    btnConnect.Text = "DISCONNECT";
                    btnConnect.ForeColor = Color.Red;
                    statusConState.Text = "CONNECTED";
                    statusConState.ForeColor = Color.ForestGreen;
                }
            }
            else
            {
                arduinoConnection.WriteLine("disconnect");
                arduinoConnection.ReadExisting();
                arduinoConnection.DiscardInBuffer();
                arduinoConnection.Close();

                if (!arduinoConnection.IsOpen)
                {
                    btnConnect.Text = "CONNECT";
                    btnConnect.ForeColor = Color.ForestGreen;
                    statusConState.Text = "DISCONNECTED";
                    statusConState.ForeColor = Color.Red;
                }
            }
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {
                if (arduinoConnection.IsOpen)
                {
                    List<string> sdata = new List<string>();
                    sdata = arduino.SplitData(arduinoConnection.ReadLine());

                    txtSerialMonitor.BeginInvoke(new Action(delegate () { txtSerialMonitor.AppendText("=> "); }));

                    if (sdata.Count > 1)
                    {
                        txtLastValue.BeginInvoke(new Action(delegate () { txtLastValue.Text = sdata[1]; }));
                    }

                    foreach (string str in sdata)
                    {
                        txtSerialMonitor.BeginInvoke(new Action(delegate () { txtSerialMonitor.AppendText(str + " "); }));
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string command = txtCommand.Text;
            txtLastCommand.Text = command;

            if (command == "disconnect")
            {
                btnConnect.Text = "CONNECT";
                btnConnect.ForeColor = Color.ForestGreen;
                statusConState.Text = "DISCONNECTED";
                statusConState.ForeColor = Color.Red;
            }

            arduinoConnection.WriteLine(command);
            txtSerialMonitor.AppendText("<= " + command + "\n");
            txtCommand.Text = "";
        }
    }
}
