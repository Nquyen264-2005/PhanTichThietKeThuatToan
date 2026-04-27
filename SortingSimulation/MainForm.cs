using SortingSimulation.Algorithms;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SortingSimulation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cboAlgorithm.SelectedIndex = 0;
            lblTime.Text = "-";
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int n = (int)numElements.Value;
            int[] data = GenerateRandomArray(n);
            int[] dataCopy = (int[])data.Clone();

            string algorithm = cboAlgorithm.SelectedItem.ToString();

            Stopwatch sw = Stopwatch.StartNew();

            switch (algorithm)
            {
                case "QuickSort":
                    QuickSort.Sort(dataCopy, 0, dataCopy.Length - 1);
                    break;
                case "HeapSort":
                    HeapSort.Sort(dataCopy);
                    break;
                case "MergeSort":
                    MergeSort.Sort(dataCopy);
                    break;
            }

            sw.Stop();
            lblTime.Text = $"{sw.ElapsedMilliseconds} ms";

            lstResult.Items.Clear();
            lstResult.Items.Add("Dữ liệu sau khi sắp xếp:");
            lstResult.Items.AddRange(dataCopy.Take(20).Select(x => x.ToString()).ToArray());
            lstResult.Items.Add("...");
        }

        private int[] GenerateRandomArray(int n)
        {
            Random rnd = new Random();
            return Enumerable.Range(0, n).Select(_ => rnd.Next(0, 100000)).ToArray();
        }
    }
}
