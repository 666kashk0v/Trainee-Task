using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeshipTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use constructor and add manually incorrect "emailAdress" field
            FormatUserInfo user1 = new FormatUserInfo("Иванов", "Иван", "Иванович");
            EmailStatus emailUser1 = new EmailStatus();
            Console.WriteLine(emailUser1.ReturnEmailStatus(user1.EmailAddress));
            Console.WriteLine(user1.ShowFormatedName());
            Console.ReadLine();

            //Set input fields manually, also set additional field("emailAdress").
            FormatUserInfo user2 = new FormatUserInfo();
            EmailStatus emailUser2 = new EmailStatus();
            user2.FirstName = "Дмит рий";
            user2.LastName = "Дми триен ко";
            user2.MiddleName = "Дмит риев";
            user2.EmailAddress = "dmitrydd@gmail.com";
            Console.WriteLine(emailUser2.ReturnEmailStatus(user2.EmailAddress));
            Console.WriteLine(user2.ShowFormatedName());
            Console.ReadLine();
        }
    }
}
