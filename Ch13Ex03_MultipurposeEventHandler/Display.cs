using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13Ex03_MultipurposeEventHandler
{
    public class Display
    {
        public void DisplayMessage(Connection sender, MessageArrivedEventArgs e)
        {
            Console.WriteLine($"Message arrived from {sender.Name}.");
            Console.WriteLine($"Message arrived: {e.Message}");
        }
    }
}
