namespace ArduinoInterface
{
    partial class ArduinoInterfaceMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtSerialMonitor = new System.Windows.Forms.RichTextBox();
            this.txtLastCommand = new System.Windows.Forms.TextBox();
            this.txtLastValue = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusConState = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(470, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.settingsToolStripMenuItem.Text = "Menu";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(110, 405);
            this.txtCommand.MaxLength = 100;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(260, 20);
            this.txtCommand.TabIndex = 1;
            // 
            // txtSerialMonitor
            // 
            this.txtSerialMonitor.HideSelection = false;
            this.txtSerialMonitor.Location = new System.Drawing.Point(17, 61);
            this.txtSerialMonitor.Name = "txtSerialMonitor";
            this.txtSerialMonitor.ReadOnly = true;
            this.txtSerialMonitor.Size = new System.Drawing.Size(434, 286);
            this.txtSerialMonitor.TabIndex = 2;
            this.txtSerialMonitor.Text = "";
            // 
            // txtLastCommand
            // 
            this.txtLastCommand.Location = new System.Drawing.Point(110, 353);
            this.txtLastCommand.Name = "txtLastCommand";
            this.txtLastCommand.ReadOnly = true;
            this.txtLastCommand.Size = new System.Drawing.Size(153, 20);
            this.txtLastCommand.TabIndex = 3;
            // 
            // txtLastValue
            // 
            this.txtLastValue.Location = new System.Drawing.Point(110, 379);
            this.txtLastValue.Name = "txtLastValue";
            this.txtLastValue.ReadOnly = true;
            this.txtLastValue.Size = new System.Drawing.Size(153, 20);
            this.txtLastValue.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightGray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusPort,
            this.statusBaudRate,
            this.statusConState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(470, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel1.Text = "CONNECTION: ";
            // 
            // statusPort
            // 
            this.statusPort.Name = "statusPort";
            this.statusPort.Size = new System.Drawing.Size(41, 17);
            this.statusPort.Text = "COM3";
            this.statusPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusBaudRate
            // 
            this.statusBaudRate.Name = "statusBaudRate";
            this.statusBaudRate.Size = new System.Drawing.Size(37, 17);
            this.statusBaudRate.Text = "38400";
            this.statusBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusConState
            // 
            this.statusConState.AutoSize = false;
            this.statusConState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusConState.ForeColor = System.Drawing.Color.ForestGreen;
            this.statusConState.Name = "statusConState";
            this.statusConState.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusConState.Size = new System.Drawing.Size(287, 17);
            this.statusConState.Spring = true;
            this.statusConState.Text = "CONNECTED";
            this.statusConState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnect.Location = new System.Drawing.Point(269, 358);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(182, 38);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSend.Location = new System.Drawing.Point(376, 402);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Command";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Command";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Serial Monitor";
            // 
            // ArduinoInterfaceMain
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(470, 462);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtLastValue);
            this.Controls.Add(this.txtLastCommand);
            this.Controls.Add(this.txtSerialMonitor);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ArduinoInterfaceMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Interface";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ArduinoInterfaceMain_FormClosed);
            this.Load += new System.EventHandler(this.ArduinoInterfaceMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.RichTextBox txtSerialMonitor;
        private System.Windows.Forms.TextBox txtLastCommand;
        private System.Windows.Forms.TextBox txtLastValue;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusPort;
        private System.Windows.Forms.ToolStripStatusLabel statusBaudRate;
        private System.Windows.Forms.ToolStripStatusLabel statusConState;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

