using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LumenWorks.Framework.IO.Csv;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Bayes4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Time += 0.5;

            double[] dataX = new double[] { 1, 2, 3, 4, 5 };
            double[] dataY = new double[] { 1, 2, 3, 4, 5 };

            formsPlot1.Plot.AddSignal(dataY);

            formsPlot2.Plot.AddScatter(dataX, dataY);
        }



        private void formsPlot1_Load(object sender, EventArgs e)
        {
        }

        private void formsPlot1_Load_1(object sender, EventArgs e)
        {

        }

        public double Time = 0.0;

        //vetores do GPS

        List<double> Vtempo = new List<double>() { 0.0 };
        List<double> XFPSO = new List<double>() { 0.0 };
        List<double> YFPSO = new List<double>() { 0.0 };
        List<double> ZZFPSO = new List<double>() { 0.0 };

        // vetores do arquivo de serie

        int itempo;

        List<double> Vtempo1 = new List<double>() { 0.0 };
        List<double> XFPSO1 = new List<double>() { 0.0 };
        List<double> YFPSO1 = new List<double>() { 0.0 };
        List<double> ZZFPSO1 = new List<double>() { 0.0 };

        // Probabilidades de saída

        double[,] Phead = new double[15, 2];
        double[,] Poffs = new double[15, 2];

        // Probabilidades apriorísticas

        Dictionary<string, double> Plinh = new Dictionary<string, double>();
        Dictionary<string, double> Pincd = new Dictionary<string, double>();
        Dictionary<string, double> Pseve = new Dictionary<string, double>();

        // Verossimilhanças

        double[,,,] Lhead = new double[15, 5, 35, 16]; // 15 valores de heading para cada 5 linhas  x 16 incidencias x 20 severidades = 1600 combinações

        double[,] Loffs = new double[15, 2800]; // 15 valores de offset (idem nas condições)


        private void Tempo(object sender, EventArgs e)
        {
            Time += 0.5;

            // simula a tomada de pontos do GPS

            double X = Math.Sin(Time * 0.1);
            double Y = Math.Sin(Time * 0.06);
            double ZZ = Math.Sin(Time * 0.03);

            // Escreve o tempo na interface

            //textBox1.Text = Time.ToString();

            // Guarda os dados do timestep

            Vtempo.Add(Time);

            XFPSO.Add(X);
            YFPSO.Add(Y);
            ZZFPSO.Add(ZZ);

            //Transforma as listas em vetores

            double[] Timevec = new double[Vtempo.Count];
            double[] Xvec = new double[Vtempo.Count];
            double[] Yvec = new double[Vtempo.Count];
            double[] ZZvec = new double[Vtempo.Count];


            for (int j = 0; j < Vtempo.Count; j++)
            {
                Timevec[j] = Vtempo[j];
                Xvec[j] = XFPSO[j];
                Yvec[j] = YFPSO[j];
                ZZvec[j] = ZZFPSO[j];

            }

            // Gráfico de heading

            formsPlot1.Plot.Clear();

            formsPlot1.Plot.AddSignal(ZZvec);


            formsPlot1.Refresh();

            // Gráfico de Offset

            formsPlot2.Plot.Clear();

            formsPlot2.Plot.AddScatter(Xvec, Yvec);

            formsPlot2.Refresh();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void formsPlot2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void formsPlot4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formsPlot3_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void priorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showPriorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadTimeSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Comandos que viabilizam o input de arquivos do tipo .mot

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Arquivos MOT (*.mot) | *.mot;";
            openFileDialog1.Title = "Importar arquivo";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string extension = Path.GetExtension(filePath);

                if (extension == ".mot")
                {
                    // Comandos que lêem o arquivo e o transforma em vetores

                    string[] linhas = File.ReadAllLines(filePath);

                    int Linhas = linhas.Length;

                    string[] data = new string[Linhas - 1];
                    string[] hora = new string[Linhas - 1];
                    float[] roll = new float[Linhas - 1];
                    float[] pitch = new float[Linhas - 1];
                    float[] yaw = new float[Linhas - 1];

                    for (int i = 1; i < Linhas - 1; i++)
                    {
                        string[] linha = linhas[i].Split(" ");

                        data[i] = linha[0];
                        hora[i] = linha[1];
                        roll[i] = float.Parse(linha[2]);
                        pitch[i] = float.Parse(linha[3]);
                        yaw[i] = float.Parse(linha[4]);

                    }


                }
            }

        }

        private void loadLikelihoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {


                var csvTable = new DataTable();
                using (var csvReader = new CsvReader(new System.IO.StreamReader(System.IO.File.OpenRead(@openFileDialog1.FileName)), true))
                {
                    csvTable.Load(csvReader);

                }

                string Column1 = csvTable.Columns[0].ToString();


                // Carregando as verossimilhanças Phead

                int k1 = 0; // contador para condicoes de linha (5 cond)
                int k2 = 0; // contador para estados de mar (35 incidencias)
                int k3 = 0; // contador para estados de mar (16 incidencias)

                for (int i = 0; i < csvTable.Rows.Count; i++)
                {
                    for (int j = 0; j < csvTable.Columns.Count; j++)
                    {
                        string row = csvTable.Rows[i][j].ToString();

                        Lhead[j, k1, k2, k3] = Convert.ToDouble(row);

                        k3++;

                        if (k3 == 16)
                        {
                            k3 = 0;
                            k1++;

                            if (k1 == 5)
                            {
                                k1 = 0;
                                k2++;

                                if (k2 == 35)
                                {
                                    k2 = 0;
                                }
                            }

                        }


                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_AddingNew(object sender, AddingNewEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadPriorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {


                var csvTable = new DataTable();
                using (var csvReader = new CsvReader(new System.IO.StreamReader(System.IO.File.OpenRead(@openFileDialog1.FileName)), true))
                {
                    csvTable.Load(csvReader);

                }

                string Column1 = csvTable.Columns[0].ToString();


                // Carregando as PRIORS

                int k1 = 5; // Índice para condicoes de linha (5 cond)
                int k2 = 35; // Índice para estados de mar (35 incidencias)
                int k3 = 16; // Índice para estados de mar (16 incidencias)

                for (int i = 0; i < csvTable.Rows.Count; i++)
                {

                    string A = csvTable.Rows[i][0].ToString();
                    string pA = csvTable.Rows[i][1].ToString();

                    if (i < k1)
                    {
                        Plinh.Add(A, Convert.ToDouble(pA));
                    }

                    if (k1 <= i & i < (k1 + k2))
                    {
                        Pseve.Add(A, Convert.ToDouble(pA));
                    }


                    if ((k1 + k2) <= i & i <= (k1 + k2 + k3))
                    {
                        Pincd.Add(A, Convert.ToDouble(pA));
                    }
                }
            }

        }

        private void connectToGPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // limpa as janelas e liga o Timer1 (simulando recepção GPS)

            timer1.Start();

        }

        private void tempo2(object sender, EventArgs e)
        {

            // Controle do tempo (acrescenta time step)

            itempo++;

            if (itempo <= Vtempo1.Count)
            {
                double[] Timevec = new double[itempo];
                double[] Xvec = new double[itempo];
                double[] Yvec = new double[itempo];
                double[] ZZvec = new double[itempo];


                for (int j = 0; j < itempo; j++)
                {
                    Timevec[j] = Vtempo1[j];
                    Xvec[j] = XFPSO1[j];
                    Yvec[j] = YFPSO1[j];
                    ZZvec[j] = ZZFPSO1[j];

                }

                // Gráfico de heading

                formsPlot1.Plot.Clear();

                formsPlot1.Plot.AddSignal(ZZvec);

                formsPlot1.Plot.SetAxisLimitsY(255, 265);


                formsPlot1.Refresh();

                // Gráfico de Offset

                formsPlot2.Plot.Clear();

                formsPlot2.Plot.AddScatter(Xvec, Yvec);

                formsPlot2.Plot.SetAxisLimitsX(-30, 30);
                formsPlot2.Plot.SetAxisLimitsY(-30, 30);


                formsPlot2.Refresh();

            }
            else
            {
                timer2.Stop();
            }
        }
    }
}
