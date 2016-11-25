namespace SerialViewer
{
    partial class MainForm
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
            this.portLabel = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.baudLabel = new System.Windows.Forms.Label();
            this.baudBox = new System.Windows.Forms.ComboBox();
            this.parityLabel = new System.Windows.Forms.Label();
            this.databitsLabel = new System.Windows.Forms.Label();
            this.databitsBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.viewerBox = new System.Windows.Forms.TextBox();
            this.parityBox = new System.Windows.Forms.ComboBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(13, 13);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 13);
            this.portLabel.TabIndex = 0;
            this.portLabel.Text = "Port:";
            // 
            // portBox
            // 
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(48, 10);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(71, 21);
            this.portBox.TabIndex = 1;
            // 
            // baudLabel
            // 
            this.baudLabel.AutoSize = true;
            this.baudLabel.Location = new System.Drawing.Point(125, 13);
            this.baudLabel.Name = "baudLabel";
            this.baudLabel.Size = new System.Drawing.Size(35, 13);
            this.baudLabel.TabIndex = 2;
            this.baudLabel.Text = "Baud:";
            // 
            // baudBox
            // 
            this.baudBox.FormattingEnabled = true;
            this.baudBox.Location = new System.Drawing.Point(166, 10);
            this.baudBox.Name = "baudBox";
            this.baudBox.Size = new System.Drawing.Size(86, 21);
            this.baudBox.TabIndex = 3;
            // 
            // parityLabel
            // 
            this.parityLabel.AutoSize = true;
            this.parityLabel.Location = new System.Drawing.Point(258, 13);
            this.parityLabel.Name = "parityLabel";
            this.parityLabel.Size = new System.Drawing.Size(36, 13);
            this.parityLabel.TabIndex = 4;
            this.parityLabel.Text = "Parity:";
            // 
            // databitsLabel
            // 
            this.databitsLabel.AutoSize = true;
            this.databitsLabel.Location = new System.Drawing.Point(369, 13);
            this.databitsLabel.Name = "databitsLabel";
            this.databitsLabel.Size = new System.Drawing.Size(52, 13);
            this.databitsLabel.TabIndex = 6;
            this.databitsLabel.Text = "Data bits:";
            // 
            // databitsBox
            // 
            this.databitsBox.Location = new System.Drawing.Point(427, 10);
            this.databitsBox.Name = "databitsBox";
            this.databitsBox.Size = new System.Drawing.Size(50, 20);
            this.databitsBox.TabIndex = 7;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(483, 8);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 10;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // viewerBox
            // 
            this.viewerBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.viewerBox.ForeColor = System.Drawing.SystemColors.Info;
            this.viewerBox.Location = new System.Drawing.Point(12, 37);
            this.viewerBox.Multiline = true;
            this.viewerBox.Name = "viewerBox";
            this.viewerBox.Size = new System.Drawing.Size(778, 338);
            this.viewerBox.TabIndex = 11;
            // 
            // parityBox
            // 
            this.parityBox.FormattingEnabled = true;
            this.parityBox.Location = new System.Drawing.Point(300, 10);
            this.parityBox.Name = "parityBox";
            this.parityBox.Size = new System.Drawing.Size(63, 21);
            this.parityBox.TabIndex = 12;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(564, 8);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 13;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(645, 8);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(726, 8);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 15;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 387);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.parityBox);
            this.Controls.Add(this.viewerBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.databitsBox);
            this.Controls.Add(this.databitsLabel);
            this.Controls.Add(this.parityLabel);
            this.Controls.Add(this.baudBox);
            this.Controls.Add(this.baudLabel);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.portLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SerialViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label baudLabel;
        private System.Windows.Forms.Label parityLabel;
        private System.Windows.Forms.Label databitsLabel;
        private System.Windows.Forms.Button connectButton;
        public System.Windows.Forms.ComboBox portBox;
        public System.Windows.Forms.ComboBox baudBox;
        public System.Windows.Forms.TextBox databitsBox;
        public System.Windows.Forms.ComboBox parityBox;
        public System.Windows.Forms.TextBox viewerBox;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button refreshButton;
    }
}

