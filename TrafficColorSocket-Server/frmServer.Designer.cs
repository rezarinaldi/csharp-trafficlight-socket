namespace TrafficColorSocket_Server
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.txtPortServer = new System.Windows.Forms.TextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.redPanel = new System.Windows.Forms.Panel();
            this.yellowPanel = new System.Windows.Forms.Panel();
            this.greenPanel = new System.Windows.Forms.Panel();
            this.timerServer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // txtIPServer
            // 
            this.txtIPServer.Location = new System.Drawing.Point(102, 103);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(100, 20);
            this.txtIPServer.TabIndex = 3;
            this.txtIPServer.Text = "192.168.43.93";
            // 
            // txtPortServer
            // 
            this.txtPortServer.Location = new System.Drawing.Point(270, 103);
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.Size = new System.Drawing.Size(100, 20);
            this.txtPortServer.TabIndex = 4;
            this.txtPortServer.Text = "16344";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(166, 334);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 5;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // redPanel
            // 
            this.redPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.redPanel.Location = new System.Drawing.Point(18, 159);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(104, 93);
            this.redPanel.TabIndex = 6;
            // 
            // yellowPanel
            // 
            this.yellowPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.yellowPanel.Location = new System.Drawing.Point(153, 159);
            this.yellowPanel.Name = "yellowPanel";
            this.yellowPanel.Size = new System.Drawing.Size(104, 93);
            this.yellowPanel.TabIndex = 7;
            // 
            // greenPanel
            // 
            this.greenPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.greenPanel.Location = new System.Drawing.Point(287, 159);
            this.greenPanel.Name = "greenPanel";
            this.greenPanel.Size = new System.Drawing.Size(104, 93);
            this.greenPanel.TabIndex = 7;
            // 
            // timerServer
            // 
            this.timerServer.Enabled = true;
            this.timerServer.Tick += new System.EventHandler(this.timerServer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Server";
            // 
            // txtStatusLabel
            // 
            this.txtStatusLabel.AutoSize = true;
            this.txtStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusLabel.Location = new System.Drawing.Point(140, 282);
            this.txtStatusLabel.Name = "txtStatusLabel";
            this.txtStatusLabel.Size = new System.Drawing.Size(135, 24);
            this.txtStatusLabel.TabIndex = 10;
            this.txtStatusLabel.Text = "All lights are off";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 390);
            this.Controls.Add(this.txtStatusLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yellowPanel);
            this.Controls.Add(this.greenPanel);
            this.Controls.Add(this.redPanel);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.txtPortServer);
            this.Controls.Add(this.txtIPServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Traffic Light Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.TextBox txtPortServer;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Panel redPanel;
        private System.Windows.Forms.Panel yellowPanel;
        private System.Windows.Forms.Panel greenPanel;
        private System.Windows.Forms.Timer timerServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtStatusLabel;
    }
}

