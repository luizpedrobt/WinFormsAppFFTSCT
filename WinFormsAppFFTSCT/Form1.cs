
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

            int[] time = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
                            10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
                            20, 21, 22, 23, 24, 25, 26, 27, 28, 29,
                            30, 31, 32, 33, 34, 35, 36, 37, 38, 39,
                            40, 41, 42, 43, 44, 45, 46, 47, 48, 49,
                            50, 51, 52, 53, 54, 55, 56, 57, 58, 59,
                            60, 61, 62, 63, 64, 65, 66, 67, 68, 69,
                            70, 71, 72, 73, 74, 75, 76, 77, 78, 79,
                            80, 81, 82, 83, 84, 85, 86, 87, 88, 89,
                            90, 91, 92, 93, 94, 95, 96, 97, 98, 99,
                            100, 101, 102, 103, 104, 105, 106, 107, 108, 109,
                            110, 111, 112, 113, 114, 115, 116, 117, 118, 119,
                            120, 121, 122, 123};
            
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
