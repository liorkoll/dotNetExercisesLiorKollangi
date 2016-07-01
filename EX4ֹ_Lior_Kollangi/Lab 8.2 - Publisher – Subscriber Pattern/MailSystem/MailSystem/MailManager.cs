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
        public string Title { get; private set; }
        public string Body { get; private set; }
        public MailArrivedEventArgs(string title,string body)
        {
            this.Title = title;
            this.Body = body;

        }
    }
    public class MailManager
    {
        public event EventHandler<MailArrivedEventArgs> MailArrived = delegate { };


        public void SimulateMailArrived()
        {
            OnMailArrived(new MailArrivedEventArgs("dummy title", "dummy body"));
        }

        protected virtual void OnMailArrived(MailArrivedEventArgs e)
        {
            if (MailArrived != null)
                MailArrived(this, e);
        }
       
       

            
    }
}
