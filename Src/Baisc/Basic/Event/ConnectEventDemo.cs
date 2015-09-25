using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LearnCSharp.Basic
{
    class ConnectEventDemo
    {
        public static void Run()
        {
            Connection myConnection = new Connection();
            Display myDisplay = new Display();

            myConnection.MessageArrived += new MessageHandler(myDisplay.DisplayMessage);
            myConnection.Connect();
        }
    }

    public delegate void MessageHandler(string messageText);

    class Connection
    {
        public event MessageHandler MessageArrived;

        private Timer pollTimer;

        public Connection()
        {
            pollTimer = new Timer(1000);
            pollTimer.Elapsed += new ElapsedEventHandler(CheckForMessage);
        }

        public void Connect()
        {
            pollTimer.Start();
        }

        public void DisConnect()
        {
            pollTimer.Stop();
        }

        private static Random rand = new Random();

        private void CheckForMessage(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Checking for new message.");
            if (rand.Next(9) == 0 && (MessageArrived != null))
            {
                MessageArrived("Hello Mum !");
            }
        }
    }

    class Display
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine("Message arrived: {0}", message);
        }
    }
}
