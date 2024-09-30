using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetodoBurbuja.models;

namespace MetodoBurbuja
{
    public partial class Form1 : Form
    {
        int[] numbers = new int [10];
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(tbNumber.Text);
                numbers[i++] = number;
                ShowNumbers();
                Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ShowNumbers()
        {
            if (lbNumbers.Items.Count > 0) 
            {
                lbNumbers.Items.Clear();
            }
            foreach (int number in numbers) 
            {
                lbNumbers.Items.Add(number);
            }
        }
        private void Clear()
        {
            tbNumber.Clear();
            tbNumber.Focus();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            bubble bubble = new bubble();
            bubble.BubbleSort(numbers);
            ShowNumbers();
        }
    }
}
