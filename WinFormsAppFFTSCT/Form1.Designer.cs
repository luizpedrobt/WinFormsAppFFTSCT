using System.IO.Ports;

namespace WinFormsAppFFTSCT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private SerialPort serialPort1;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Text.ASCIIEncoding asciiEncoding3 = new System.Text.ASCIIEncoding();
            System.Text.DecoderReplacementFallback decoderReplacementFallback3 = new System.Text.DecoderReplacementFallback();
            System.Text.EncoderReplacementFallback encoderReplacementFallback3 = new System.Text.EncoderReplacementFallback();
            serialPort1 = new SerialPort(components);
            FftDisplayPoint = new ScottPlot.WinForms.FormsPlot();
            PointDisplayPlot = new ScottPlot.WinForms.FormsPlot();
            serialCloseBtn = new Button();
            chBoxSelectPort = new ComboBox();
            chBoxBaudRate = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            serialOpenBtn = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            collecteDataBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // serialPort1
            // 
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.DiscardNull = false;
            serialPort1.DtrEnable = false;
            //asciiEncoding3.DecoderFallback = decoderReplacementFallback3;
            //asciiEncoding3.EncoderFallback = encoderReplacementFallback3;
            serialPort1.Encoding = asciiEncoding3;
            serialPort1.Handshake = Handshake.None;
            serialPort1.NewLine = "\n";
            serialPort1.Parity = Parity.None;
            serialPort1.ParityReplace = 63;
            serialPort1.PortName = "COM1";
            serialPort1.ReadBufferSize = 4096;
            serialPort1.ReadTimeout = -1;
            serialPort1.ReceivedBytesThreshold = 1;
            serialPort1.RtsEnable = false;
            serialPort1.StopBits = StopBits.One;
            serialPort1.WriteBufferSize = 2048;
            serialPort1.WriteTimeout = -1;
            // 
            // FftDisplayPoint
            // 
            FftDisplayPoint.DisplayScale = 1F;
            FftDisplayPoint.Location = new Point(14, 15);
            FftDisplayPoint.Margin = new Padding(3, 4, 3, 4);
            FftDisplayPoint.Name = "FftDisplayPoint";
            FftDisplayPoint.Size = new Size(477, 569);
            FftDisplayPoint.TabIndex = 0;
            // 
            // PointDisplayPlot
            // 
            PointDisplayPlot.DisplayScale = 1F;
            PointDisplayPlot.Location = new Point(451, 16);
            PointDisplayPlot.Margin = new Padding(3, 4, 3, 4);
            PointDisplayPlot.Name = "PointDisplayPlot";
            PointDisplayPlot.Size = new Size(466, 568);
            PointDisplayPlot.TabIndex = 1;
            // 
            // serialCloseBtn
            // 
            serialCloseBtn.Location = new Point(113, 26);
            serialCloseBtn.Name = "serialCloseBtn";
            serialCloseBtn.Size = new Size(84, 72);
            serialCloseBtn.TabIndex = 2;
            serialCloseBtn.Text = "Close";
            serialCloseBtn.Click += serialCloseBtn_Click;
            // 
            // chBoxSelectPort
            // 
            chBoxSelectPort.Location = new Point(17, 104);
            chBoxSelectPort.Name = "chBoxSelectPort";
            chBoxSelectPort.Size = new Size(180, 28);
            chBoxSelectPort.TabIndex = 3;
            // 
            // chBoxBaudRate
            // 
            chBoxBaudRate.Items.AddRange(new object[] { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" });
            chBoxBaudRate.Location = new Point(17, 138);
            chBoxBaudRate.Name = "chBoxBaudRate";
            chBoxBaudRate.Size = new Size(180, 28);
            chBoxBaudRate.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 109);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 7;
            label1.Text = "Serial COM Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 141);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 8;
            label2.Text = "Baud Rate";
            // 
            // serialOpenBtn
            // 
            serialOpenBtn.Location = new Point(17, 26);
            serialOpenBtn.Name = "serialOpenBtn";
            serialOpenBtn.Size = new Size(84, 72);
            serialOpenBtn.TabIndex = 13;
            serialOpenBtn.Text = "Open";
            serialOpenBtn.UseVisualStyleBackColor = true;
            serialOpenBtn.Click += serialOpenBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(serialOpenBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(chBoxBaudRate);
            groupBox1.Controls.Add(chBoxSelectPort);
            groupBox1.Controls.Add(serialCloseBtn);
            groupBox1.Location = new Point(906, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 184);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(collecteDataBtn);
            groupBox2.Location = new Point(906, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 89);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(215, 26);
            button3.Name = "button3";
            button3.Size = new Size(162, 47);
            button3.TabIndex = 1;
            button3.Text = "Plot FFT";
            button3.UseVisualStyleBackColor = true;
            // 
            // collecteDataBtn
            // 
            collecteDataBtn.Location = new Point(17, 26);
            collecteDataBtn.Name = "collecteDataBtn";
            collecteDataBtn.Size = new Size(162, 47);
            collecteDataBtn.TabIndex = 0;
            collecteDataBtn.Text = "Collect Data";
            collecteDataBtn.UseVisualStyleBackColor = true;
            collecteDataBtn.Click += collecteDataBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 636);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(PointDisplayPlot);
            Controls.Add(FftDisplayPoint);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "FFT Serial Plotter";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot FftDisplayPoint;
        private ScottPlot.WinForms.FormsPlot PointDisplayPlot;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox5;
        private Button serialOpenBtn;
        private GroupBox groupBox1;
        private ComboBox chBoxBaudRate;
        private Button serialCloseBtn;
        private ComboBox chBoxSelectPort;
        private GroupBox groupBox2;
        private Button button3;
        private Button collecteDataBtn;
    }
}
