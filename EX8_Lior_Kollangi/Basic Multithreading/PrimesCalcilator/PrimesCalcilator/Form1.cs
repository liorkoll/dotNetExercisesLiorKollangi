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
       public static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
       public static CancellationToken cancellationToken = cancellationTokenSource.Token;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           PrimesCalc pc = new PrimesCalc();
           var synchronizationContext = SynchronizationContext.Current;


           if (cancellationToken != null) cancellationTokenSource = new CancellationTokenSource();
           Task.Run (()=>   
            {
                int [] primes = pc.CalcPrimes(int.Parse(textBox1.Text),int.Parse(textBox2.Text));
                cancellationToken.ThrowIfCancellationRequested();
                Task.Delay(10000);
             synchronizationContext.Send(o =>

           {
               
               listBox1.Items.Clear();
                for (int i = 0; i < primes.Length; i++)
                    listBox1.Items.Add(primes[i].ToString());
          }, null);
        });

         



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cancellationToken!=null) cancellationTokenSource.Cancel();
         
        }
      
    }
}
