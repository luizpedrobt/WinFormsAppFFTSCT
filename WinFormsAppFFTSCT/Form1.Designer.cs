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
            System.Text.ASCIIEncoding asciiEncoding1 = new System.Text.ASCIIEncoding();
            System.Text.DecoderReplacementFallback decoderReplacementFallback1 = new System.Text.DecoderReplacementFallback();
            System.Text.EncoderReplacementFallback encoderReplacementFallback1 = new System.Text.EncoderReplacementFallback();
            serialPort1 = new SerialPort(components);
            FftDisplayPoint = new ScottPlot.WinForms.FormsPlot();
            PointDisplayPlot = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // serialPort1
            // 
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.DiscardNull = false;
            serialPort1.DtrEnable = false;
            //asciiEncoding1.DecoderFallback = decoderReplacementFallback1;
            //asciiEncoding1.EncoderFallback = encoderReplacementFallback1;
            serialPort1.Encoding = asciiEncoding1;
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
            FftDisplayPoint.Location = new Point(12, 11);
            FftDisplayPoint.Name = "FftDisplayPoint";
            FftDisplayPoint.Size = new Size(417, 427);
            FftDisplayPoint.TabIndex = 0;
            // 
            // PointDisplayPlot
            // 
            PointDisplayPlot.DisplayScale = 1F;
            PointDisplayPlot.Location = new Point(395, 12);
            PointDisplayPlot.Name = "PointDisplayPlot";
            PointDisplayPlot.Size = new Size(421, 426);
            PointDisplayPlot.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 471);
            Controls.Add(PointDisplayPlot);
            Controls.Add(FftDisplayPoint);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot FftDisplayPoint;
        private ScottPlot.WinForms.FormsPlot PointDisplayPlot;
    }
}
