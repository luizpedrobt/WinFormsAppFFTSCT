
using FftSharp;
using ScottPlot.WinForms;
using System.Numerics;
using System.IO.Ports;

namespace WinFormsAppFFTSCT
{
    public partial class Form1 : Form
    {
        int nOfSamples;
        double[] collectedData = new double[128];
        int sampleRate = 125000000;
        public Form1()
        {
            InitializeComponent();
            nOfSamples = 128;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] availablePorts = SerialPort.GetPortNames();

            chBoxSelectPort.Items.AddRange(availablePorts);

            serialCloseBtn.Enabled = false;
            serialOpenBtn.Enabled = true;
        }

        private void serialOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = chBoxSelectPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(chBoxBaudRate.Text);
                serialPort1.Open();

                serialCloseBtn.Enabled = true;
                serialOpenBtn.Enabled = false;
                MessageBox.Show("Serial Port " + serialPort1.PortName + " succesfully opened.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialCloseBtn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();

                MessageBox.Show("Serial Port " + serialPort1.PortName + " succesfully closed.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                serialCloseBtn.Enabled = false;
                serialOpenBtn.Enabled = true;
            }
        }

        private void collecteDataBtn_Click(object sender, EventArgs e)
        {
            collectedData = returnDataArray();
            int[] time = new int[nOfSamples];
            for(int i = 0; i < nOfSamples; i++)
            {
                time[i] = i;
            }

            PointDisplayPlot.Plot.Add.Scatter(time, collectedData);
            PointDisplayPlot.Refresh();

            MessageBox.Show("Data succesfully collected. Data length: " + collectedData.Length, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private double[] returnDataArray()
        {
            string notFormattedData;
            int count = 0;
            double currentData;
            double[] collectedData = new double[nOfSamples];

            while ((serialPort1.IsOpen) && (count < nOfSamples))
            {
                notFormattedData = serialPort1.ReadLine();
                if (double.TryParse(notFormattedData, out currentData))
                {
                    collectedData[count] = currentData;
                    count++;
                }
            }
            return (collectedData);
        }
        private void plotFFTbtn_Click(object sender, EventArgs e)
        {
            System.Numerics.Complex[] aqsData_FFT = FftSharp.FFT.Forward(collectedData);
            double[] psd = FftSharp.FFT.Power(aqsData_FFT);
            double[] freq = FftSharp.FFT.FrequencyScale(aqsData_FFT.Length, sampleRate);

            FftDisplayPoint.Plot.Add.Scatter(freq, psd);
            FftDisplayPoint.Refresh(); 
        }
    }
}
