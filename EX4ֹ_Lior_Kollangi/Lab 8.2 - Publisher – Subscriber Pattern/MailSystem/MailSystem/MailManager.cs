using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailSystem
{
    public class MailArrivedEventArgs : EventArgs
    {
        public string Title { get; }
        public string Body { get; }
        public MailArrivedEventArgs(string Title,string Body)
        {
            this.Title = Title;
            this.Body = Body;

        }
    }
    class MailManager
    {
         event EventHandler<MailArrivedEventArgs> MailArrived;


        void SimulateMailArrived(object e)
        {
            OnMailArrived(new MailArrivedEventArgs("dummy title", "dummy body"));
        }

        protected virtual void OnMailArrived(MailArrivedEventArgs e)
        {
            if (MailArrived != null)
                MailArrived(this, e);
        }
        static void Mm_MailArrived(object sender, MailArrivedEventArgs e)
        {
            Console.WriteLine("Title: " + e.Title);
            Console.WriteLine("Body: " + e.Body);
        }
        static void Main(string[] args)
        {
            MailManager mm = new MailManager();
            mm.MailArrived += Mm_MailArrived;
            mm.SimulateMailArrived(null);
            Timer timer = new Timer(new TimerCallback(mm.SimulateMailArrived),null,1000,1000);
            Thread.Sleep(10000);
        }       
    }
}
