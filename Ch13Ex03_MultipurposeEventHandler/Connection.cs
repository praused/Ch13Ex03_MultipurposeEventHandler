using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ch13Ex03_MultipurposeEventHandler
{
    public delegate void MessageHandler(Connection sender, MessageArrivedEventArgs e);

    public class Connection
    {
        public event MessageHandler MessageArrived;
        private Timer pollTimer;
        public string Name { get; set; }

        public Connection()
        {
            pollTimer = new Timer(100);
            pollTimer.Elapsed += new ElapsedEventHandler(CheckForMessage);
        }

        public void Connect()
        {
            pollTimer.Start();
        }

        public void Disconnect()
        {
            pollTimer.Stop();
        }

        private static Random random = new Random();

        private void CheckForMessage(object sender, EventArgs e)
        {
            Console.WriteLine("Checking for new messages.");
            if ((random.Next(9) == 0) && MessageArrived != null)
            {

                MessageArrived(this, new MessageArrivedEventArgs("Hello, Mum!"));
            }
        }
    }
}
