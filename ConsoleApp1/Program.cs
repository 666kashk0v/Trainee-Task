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
            AddName name = new AddName("Иванов", "Иван", "Иванович");
            name.emailAddress = "ivanoviimail.ru";
            Console.WriteLine(name.ShowFormatedName());
            Console.ReadLine();

            //Set input fields manually, also set additional field("emailAdress").
            AddName name1 = new AddName();
            name1.FirstName = "Дмит рий";
            name1.LastName = "Дми триен ко";
            name1.MiddleName = "Дмит риев";
            name1.emailAddress = "dmitrydd@gmail.com";
            Console.WriteLine(name1.ShowFormatedName());
            Console.ReadLine();
        }
    }
}
