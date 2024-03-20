
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
            double[] dataX = { 1, 2, 3, 4, 5 };
            double[] dataY = { 1, 4, 8, 16, 25 };

            double[] time = {0, 8e-9, 1.6e-8, 2.4e-8, 3.2e-8, 4e-8, 4.8e-8, 5.6e-8,
                        6.4e-8, 7.2e-8, 8e-8, 8.8e-8, 9.6e-8, 1.04e-7, 1.12e-7, 1.2e-7,
                        1.28e-7, 1.36e-7, 1.44e-7, 1.52e-7, 1.6e-7, 1.68e-7, 1.76e-7, 1.84e-7,
                        1.92e-7, 2e-7, 2.08e-7, 2.16e-7, 2.24e-7, 2.32e-7, 2.4e-7, 2.48e-7,
                        2.56e-7, 2.64e-7, 2.72e-7, 2.8e-7, 2.88e-7, 2.96e-7, 3.04e-7, 3.12e-7,
                        3.2e-7, 3.28e-7, 3.36e-7, 3.44e-7, 3.52e-7, 3.6e-7, 3.68e-7, 3.76e-7,
                        3.84e-7, 3.92e-7, 4e-7, 4.08e-7, 4.16e-7, 4.24e-7, 4.32e-7, 4.4e-7,
                        4.48e-7, 4.56e-7, 4.64e-7, 4.72e-7, 4.8e-7, 4.88e-7, 4.96e-7, 5.04e-7,
                        5.12e-7, 5.2e-7, 5.28e-7, 5.36e-7, 5.44e-7, 5.52e-7, 5.6e-7, 5.68e-7,
                        5.76e-7, 5.84e-7, 5.92e-7, 6e-7, 6.08e-7, 6.16e-7, 6.24e-7, 6.32e-7,
                        6.4e-7, 6.48e-7, 6.56e-7, 6.64e-7, 6.72e-7, 6.8e-7, 6.88e-7, 6.96e-7,
                        7.04e-7, 7.12e-7, 7.2e-7, 7.28e-7, 7.36e-7, 7.44e-7, 7.52e-7, 7.6e-7,
                        7.68e-7, 7.76e-7, 7.84e-7, 7.92e-7, 8e-7
                        };
            
            double[] dados_ch1 = {
              75,   95,   32,   31,   99,   -32,   -31,   93,
              -95,   32,   -96,   31,   33,   96,   34,   32,
              37,   -98,   99,   96,   -30,   31,   -32,   30,
              36,   -184,   1656,   1646,   1177,   433,   -1451,   -1844,
              -1839,   -377,   -102,   102,   234,   105,   232,   230,
              41,   104,   169,   228,   169,   174,   369,   296,
              -367,   -499,   -170,   -108,   -97,   98,   172,   302,
              368,   362,   107,   -259,   -234,   -111,   -103,   30,
              -230,   -511,   -404,   -252,   -29,   96,   101,   98,
              229,   97,   33,   30,   100,   93,   101,   32,
              34,   -31,   -138,   32,   -94,   -33,   -95,   98,
              162,   -33,   -97,   -99,   97,   31,   35,   34,
              37,   -28,   165,   98,   -98,    15,    0,    0,    0,    0,    0,
              0,    0,    0,    0,    0,    0,     0,    0,    0,    0,    0,    0,
              0,    0,    0,    0,    0,    0,     0,    0,    0};

            int sampleRate = 125000000;

            System.Numerics.Complex[] aqsData_FFT = FftSharp.FFT.Forward(dados_ch1);
            double[] psd = FftSharp.FFT.Power(aqsData_FFT);
            double[] freq = FftSharp.FFT.FrequencyScale(aqsData_FFT.Length, sampleRate);

            FftDisplayPoint.Plot.Add.Scatter(freq, psd);
            FftDisplayPoint.Refresh();

            PointDisplayPlot.Plot.Add.Scatter(time, dados_ch1);
            PointDisplayPlot.Refresh();

        }
    }
}
