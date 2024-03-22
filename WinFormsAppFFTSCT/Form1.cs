
using FftSharp;
using ScottPlot.WinForms;
using System.Numerics;
using System.IO.Ports;

namespace WinFormsAppFFTSCT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            double[] test = returnDataArray();
            MessageBox.Show("Data succesfully collected. Here's the 16° number of the array: " + test[15], "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private double[] returnDataArray()
        {
            string notFormattedData;
            int count = 0;
            double currentData;
            double[] collectedData = new double[128];

            while ((serialPort1.IsOpen) && (count < 128))
            {
                notFormattedData = serialPort1.ReadLine();
                if(double.TryParse(notFormattedData, out currentData))
                {
                    collectedData[count] = currentData;
                    count++;
                }
            }
            return(collectedData);
        }
    }
}
