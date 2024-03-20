
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

            int[] time = new int[] {};
            for(int i = 0; i < 100; i++)
            {
                time[i] = i;
            }
            
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
              37,   -28,   165,   98,   -98,    0,    0,    0,    0,    0,    0,
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
