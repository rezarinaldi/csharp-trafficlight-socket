namespace TrafficColorSocket_Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPClient = new System.Windows.Forms.TextBox();
            this.txtPortClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rBMerahOn = new System.Windows.Forms.RadioButton();
            this.rBMerahOff = new System.Windows.Forms.RadioButton();
            this.rBKuningOn = new System.Windows.Forms.RadioButton();
            this.rBKuningOff = new System.Windows.Forms.RadioButton();
            this.rBHijauOn = new System.Windows.Forms.RadioButton();
            this.rBHijauOff = new System.Windows.Forms.RadioButton();
            this.groupBoxMerah = new System.Windows.Forms.GroupBox();
            this.groupBoxKuning = new System.Windows.Forms.GroupBox();
            this.groupBoxHijau = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxMerah.SuspendLayout();
            this.groupBoxKuning.SuspendLayout();
            this.groupBoxHijau.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // txtIPClient
            // 
            this.txtIPClient.Location = new System.Drawing.Point(126, 75);
            this.txtIPClient.Name = "txtIPClient";
            this.txtIPClient.Size = new System.Drawing.Size(100, 20);
            this.txtIPClient.TabIndex = 2;
            this.txtIPClient.Text = "192.168.43.93";
            // 
            // txtPortClient
            // 
            this.txtPortClient.Location = new System.Drawing.Point(126, 109);
            this.txtPortClient.Name = "txtPortClient";
            this.txtPortClient.Size = new System.Drawing.Size(100, 20);
            this.txtPortClient.TabIndex = 3;
            this.txtPortClient.Text = "16344";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "On";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Off";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Red";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Yellow";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Green";
            // 
            // rBMerahOn
            // 
            this.rBMerahOn.AutoSize = true;
            this.rBMerahOn.Location = new System.Drawing.Point(0, 0);
            this.rBMerahOn.Name = "rBMerahOn";
            this.rBMerahOn.Size = new System.Drawing.Size(14, 13);
            this.rBMerahOn.TabIndex = 9;
            this.rBMerahOn.UseVisualStyleBackColor = true;
            this.rBMerahOn.CheckedChanged += new System.EventHandler(this.rBMerahOn_CheckedChanged);
            // 
            // rBMerahOff
            // 
            this.rBMerahOff.AutoSize = true;
            this.rBMerahOff.Checked = true;
            this.rBMerahOff.Location = new System.Drawing.Point(73, 0);
            this.rBMerahOff.Name = "rBMerahOff";
            this.rBMerahOff.Size = new System.Drawing.Size(14, 13);
            this.rBMerahOff.TabIndex = 10;
            this.rBMerahOff.TabStop = true;
            this.rBMerahOff.UseVisualStyleBackColor = true;
            this.rBMerahOff.CheckedChanged += new System.EventHandler(this.rBMerahOff_CheckedChanged);
            // 
            // rBKuningOn
            // 
            this.rBKuningOn.AutoSize = true;
            this.rBKuningOn.Location = new System.Drawing.Point(3, 0);
            this.rBKuningOn.Name = "rBKuningOn";
            this.rBKuningOn.Size = new System.Drawing.Size(14, 13);
            this.rBKuningOn.TabIndex = 11;
            this.rBKuningOn.UseVisualStyleBackColor = true;
            this.rBKuningOn.CheckedChanged += new System.EventHandler(this.rBKuningOn_CheckedChanged);
            // 
            // rBKuningOff
            // 
            this.rBKuningOff.AutoSize = true;
            this.rBKuningOff.Checked = true;
            this.rBKuningOff.Location = new System.Drawing.Point(76, 0);
            this.rBKuningOff.Name = "rBKuningOff";
            this.rBKuningOff.Size = new System.Drawing.Size(14, 13);
            this.rBKuningOff.TabIndex = 12;
            this.rBKuningOff.TabStop = true;
            this.rBKuningOff.UseVisualStyleBackColor = true;
            this.rBKuningOff.CheckedChanged += new System.EventHandler(this.rBKuningOff_CheckedChanged);
            // 
            // rBHijauOn
            // 
            this.rBHijauOn.AutoSize = true;
            this.rBHijauOn.Location = new System.Drawing.Point(3, 0);
            this.rBHijauOn.Name = "rBHijauOn";
            this.rBHijauOn.Size = new System.Drawing.Size(14, 13);
            this.rBHijauOn.TabIndex = 13;
            this.rBHijauOn.UseVisualStyleBackColor = true;
            this.rBHijauOn.CheckedChanged += new System.EventHandler(this.rBHijauOn_CheckedChanged);
            // 
            // rBHijauOff
            // 
            this.rBHijauOff.AutoSize = true;
            this.rBHijauOff.Checked = true;
            this.rBHijauOff.Location = new System.Drawing.Point(76, 0);
            this.rBHijauOff.Name = "rBHijauOff";
            this.rBHijauOff.Size = new System.Drawing.Size(14, 13);
            this.rBHijauOff.TabIndex = 14;
            this.rBHijauOff.TabStop = true;
            this.rBHijauOff.UseVisualStyleBackColor = true;
            this.rBHijauOff.CheckedChanged += new System.EventHandler(this.rBHijauOff_CheckedChanged);
            // 
            // groupBoxMerah
            // 
            this.groupBoxMerah.Controls.Add(this.rBMerahOn);
            this.groupBoxMerah.Controls.Add(this.rBMerahOff);
            this.groupBoxMerah.Location = new System.Drawing.Point(129, 184);
            this.groupBoxMerah.Name = "groupBoxMerah";
            this.groupBoxMerah.Size = new System.Drawing.Size(97, 13);
            this.groupBoxMerah.TabIndex = 15;
            this.groupBoxMerah.TabStop = false;
            // 
            // groupBoxKuning
            // 
            this.groupBoxKuning.Controls.Add(this.rBKuningOn);
            this.groupBoxKuning.Controls.Add(this.rBKuningOff);
            this.groupBoxKuning.Location = new System.Drawing.Point(126, 213);
            this.groupBoxKuning.Name = "groupBoxKuning";
            this.groupBoxKuning.Size = new System.Drawing.Size(100, 13);
            this.groupBoxKuning.TabIndex = 16;
            this.groupBoxKuning.TabStop = false;
            // 
            // groupBoxHijau
            // 
            this.groupBoxHijau.Controls.Add(this.rBHijauOn);
            this.groupBoxHijau.Controls.Add(this.rBHijauOff);
            this.groupBoxHijau.Location = new System.Drawing.Point(126, 246);
            this.groupBoxHijau.Name = "groupBoxHijau";
            this.groupBoxHijau.Size = new System.Drawing.Size(100, 13);
            this.groupBoxHijau.TabIndex = 17;
            this.groupBoxHijau.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Client";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 283);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBoxHijau);
            this.Controls.Add(this.groupBoxKuning);
            this.Controls.Add(this.groupBoxMerah);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPortClient);
            this.Controls.Add(this.txtIPClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Traffic Light Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMerah.ResumeLayout(false);
            this.groupBoxMerah.PerformLayout();
            this.groupBoxKuning.ResumeLayout(false);
            this.groupBoxKuning.PerformLayout();
            this.groupBoxHijau.ResumeLayout(false);
            this.groupBoxHijau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPClient;
        private System.Windows.Forms.TextBox txtPortClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rBMerahOn;
        private System.Windows.Forms.RadioButton rBMerahOff;
        private System.Windows.Forms.RadioButton rBKuningOn;
        private System.Windows.Forms.RadioButton rBKuningOff;
        private System.Windows.Forms.RadioButton rBHijauOn;
        private System.Windows.Forms.RadioButton rBHijauOff;
        private System.Windows.Forms.GroupBox groupBoxMerah;
        private System.Windows.Forms.GroupBox groupBoxKuning;
        private System.Windows.Forms.GroupBox groupBoxHijau;
        private System.Windows.Forms.Label label8;
    }
}

