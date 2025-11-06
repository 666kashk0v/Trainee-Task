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
            user1.emailAddress = "ivanoviimail.ru";
            Console.WriteLine(user1.ShowFormatedName());
            Console.ReadLine();

            //Set input fields manually, also set additional field("emailAdress").
            FormatUserInfo user2 = new FormatUserInfo();
            user2.FirstName = "Дмит рий";
            user2.LastName = "Дми триен ко";
            user2.MiddleName = "Дмит риев";
            user2.emailAddress = "dmitrydd@gmail.com";
            Console.WriteLine(user2.ShowFormatedName());
            Console.ReadLine();
        }
    }
}
