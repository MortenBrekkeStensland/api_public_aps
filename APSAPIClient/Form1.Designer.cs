
namespace APSAPIClient
{
    partial class Form1
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
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.textBoxFeedback = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelCommand = new System.Windows.Forms.Label();
            this.labelFeedBack = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonDisplayTest = new System.Windows.Forms.Button();
            this.buttonFireTimerWithID = new System.Windows.Forms.Button();
            this.labelExampleCommands = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(152, 16);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(57, 20);
            this.textBoxPort.TabIndex = 0;
            this.textBoxPort.Text = "4777";
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(120, 82);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(196, 20);
            this.textBoxCommand.TabIndex = 1;
            // 
            // textBoxFeedback
            // 
            this.textBoxFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFeedback.Location = new System.Drawing.Point(120, 108);
            this.textBoxFeedback.Multiline = true;
            this.textBoxFeedback.Name = "textBoxFeedback";
            this.textBoxFeedback.Size = new System.Drawing.Size(319, 242);
            this.textBoxFeedback.TabIndex = 2;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(120, 19);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 3;
            this.labelPort.Text = "Port";
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Location = new System.Drawing.Point(14, 85);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(92, 13);
            this.labelCommand.TabIndex = 4;
            this.labelCommand.Text = "Custom Command";
            // 
            // labelFeedBack
            // 
            this.labelFeedBack.AutoSize = true;
            this.labelFeedBack.Location = new System.Drawing.Point(14, 111);
            this.labelFeedBack.Name = "labelFeedBack";
            this.labelFeedBack.Size = new System.Drawing.Size(55, 13);
            this.labelFeedBack.TabIndex = 5;
            this.labelFeedBack.Text = "Feedback";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(12, 19);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(17, 13);
            this.labelIP.TabIndex = 7;
            this.labelIP.Text = "IP";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(35, 16);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(79, 20);
            this.textBoxIP.TabIndex = 6;
            this.textBoxIP.Text = "127.0.0.1";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(215, 14);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 8;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(322, 80);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(296, 14);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 10;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonDisplayTest
            // 
            this.buttonDisplayTest.Enabled = false;
            this.buttonDisplayTest.Location = new System.Drawing.Point(120, 53);
            this.buttonDisplayTest.Name = "buttonDisplayTest";
            this.buttonDisplayTest.Size = new System.Drawing.Size(99, 23);
            this.buttonDisplayTest.TabIndex = 11;
            this.buttonDisplayTest.Text = "Display Test";
            this.buttonDisplayTest.UseVisualStyleBackColor = true;
            this.buttonDisplayTest.Click += new System.EventHandler(this.buttonDisplayTest_Click);
            // 
            // buttonFireTimerWithID
            // 
            this.buttonFireTimerWithID.Enabled = false;
            this.buttonFireTimerWithID.Location = new System.Drawing.Point(225, 53);
            this.buttonFireTimerWithID.Name = "buttonFireTimerWithID";
            this.buttonFireTimerWithID.Size = new System.Drawing.Size(115, 23);
            this.buttonFireTimerWithID.TabIndex = 12;
            this.buttonFireTimerWithID.Text = "Run File";
            this.buttonFireTimerWithID.UseVisualStyleBackColor = true;
            this.buttonFireTimerWithID.Click += new System.EventHandler(this.buttonOpenStart_Presentation_Click);
            // 
            // labelExampleCommands
            // 
            this.labelExampleCommands.AutoSize = true;
            this.labelExampleCommands.Location = new System.Drawing.Point(12, 58);
            this.labelExampleCommands.Name = "labelExampleCommands";
            this.labelExampleCommands.Size = new System.Drawing.Size(102, 13);
            this.labelExampleCommands.TabIndex = 13;
            this.labelExampleCommands.Text = "Example Commands";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 362);
            this.Controls.Add(this.labelExampleCommands);
            this.Controls.Add(this.buttonFireTimerWithID);
            this.Controls.Add(this.buttonDisplayTest);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.labelFeedBack);
            this.Controls.Add(this.labelCommand);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxFeedback);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.textBoxPort);
            this.Name = "Form1";
            this.Text = "API Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.TextBox textBoxFeedback;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.Label labelFeedBack;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonDisplayTest;
        private System.Windows.Forms.Button buttonFireTimerWithID;
        private System.Windows.Forms.Label labelExampleCommands;
    }
}

