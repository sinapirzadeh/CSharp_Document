using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager db = new DatabaseManager(new EmailNotification());
            DatabaseManager db2 = new DatabaseManager(new SmsNotification());
        }
    }


    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            // TODO : Send Message
        }

    }

    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            // TODO : Send Message
        }
    }

    public class DatabaseManager
    {
        private INotification notification;

        public DatabaseManager(INotification notification)
        {
            this.notification = notification;
        }
        public void Add()
        {
            notification.Send("Add New Record");
        }

        public void Remove()
        {
            notification.Send("Remove");
        }

        public void Update()
        {
            notification.Send("Update");
        }
    }
}
