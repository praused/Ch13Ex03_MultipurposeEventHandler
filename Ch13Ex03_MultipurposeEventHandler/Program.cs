using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13Ex03_MultipurposeEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection myConnection1 = new Connection();
            myConnection1.Name = "First Connection.";
            Connection myConnection2 = new Connection();
            myConnection2.Name = "Second Connection.";
            Display myDisplay = new Display();
            myConnection1.MessageArrived += new MessageHandler(myDisplay.DisplayMessage);
            myConnection2.MessageArrived += new MessageHandler(myDisplay.DisplayMessage);
            myConnection1.Connect();
            myConnection2.Connect();
            Console.ReadKey();
        }
    }
}
