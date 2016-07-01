using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            MailManager mailManager = new MailManager();
            mailManager.MailArrived += Mm_MailArrived;
            mailManager.SimulateMailArrived();
            Timer timer = new Timer(new TimerCallback(TimerCallback), mailManager, 1000, 1000);
            Thread.Sleep(10000);
        }
        private static void TimerCallback(object state)
        {
            var mailManager = state as MailManager;
            mailManager.SimulateMailArrived();
        }
        static void Mm_MailArrived(object sender, MailArrivedEventArgs e)
        {
            Console.WriteLine("Title: " + e.Title);
            Console.WriteLine("Body: " + e.Body);
        }
    }
}
