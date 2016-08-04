using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimesCalcilator
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken; 
        public static AutoResetEvent are = new AutoResetEvent(false);
        PrimesCalc pc = new PrimesCalc();
        public Form1()
        {
            InitializeComponent();
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2 = 0;
            bool checkNum = int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2);
            if (!checkNum)
            {
                MessageBox.Show("Please type only numbers");
                return;
            }


            var synchronizationContext = SynchronizationContext.Current;

            Task.Run(() =>
            {
   
              
                List<int> primes = pc.CalcPrimes(num1,num2,cancellationToken);

                synchronizationContext.Send(o =>
                {
                    for (int i = 0; i < primes.Count; i++)
                    {
                        listBox1.Items.Add(primes[i].ToString());
                    }
                }
                ,null);


            },cancellationToken);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pc.waitHandle.Reset();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();

        }
    }
}
