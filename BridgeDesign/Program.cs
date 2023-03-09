using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            customerManager.MessagesenrerBase = new EmailSender();
            customerManager.Send(new Body { Title = "Message1" } );
            customerManager.MessagesenrerBase = new SMSSender();
            customerManager.Send(new Body { Title = "Message2" });
            Console.ReadLine();
        }
    }

    interface MessagesenrerBase
    {
        void Send(Body body);
    }

    class SMSSender:MessagesenrerBase
    {
        public void Send(Body body)
        {
            Console.WriteLine("{0} sent via SMSSender.",body.Title);
        }
    }

    class EmailSender: MessagesenrerBase
    {
        public void Send(Body body)
        {
            Console.WriteLine("{0} sent via EmailSender.", body.Title);
        }
    }
    class CustomerManager
    {
        public MessagesenrerBase MessagesenrerBase { get; set; }

        public void Send(Body body)
        {
            MessagesenrerBase.Send(body);
        }
    }

    class Body
    {
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
