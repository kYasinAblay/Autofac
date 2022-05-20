using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ILogClass
{
    public class SharedClassLog
    {

        public interface ILog
        {
            void Write(string message);
        }

        public class ConsoleLog : ILog
        {
            public void Write(string message)
            {
                Console.WriteLine(message);
            }
        }
        public class EmailLog : ILog
        {
            private const string adminEmail = "admin@foo.com";

            public void Write(string message)
            {
                Console.WriteLine($"Email sent to {adminEmail} : {message}");
            }
        }
        public class SMSLog : ILog
        {
            private string phoneNumber;

            public SMSLog(string phoneNumber)
            {
                this.phoneNumber = phoneNumber;
            }

            public void Write(string message)
            {
                Console.WriteLine($"SMS to {phoneNumber} : {message}");
            }
        }


    }
}
