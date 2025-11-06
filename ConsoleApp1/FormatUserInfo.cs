using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeshipTask
{
    class FormatUserInfo
    {
        //Input fields
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        //Additional field
        public string emailAddress { get; set; } = null;
        //Constructor for init "Input fields"
        public FormatUserInfo(string firstName, string lastName, string middleName) 
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }
        //Empty constructor if we want to init classes field manually
        public FormatUserInfo() { }
        //Method which delete spaces and sets the correct cases
        private void FormatName()
        {
            FirstName = FirstName.Replace(" ", "");
            LastName = LastName.Replace(" ", "");
            MiddleName = MiddleName.Replace(" ", "");

            FirstName = char.ToUpper(FirstName[0]) + FirstName.Substring(1).ToLower();
            LastName = char.ToUpper(LastName[0]) + LastName.Substring(1).ToLower();
            MiddleName = char.ToUpper(MiddleName[0]) + ".";
        }
        //Method which check status of "emailAddress" field
        private bool IsEmail() 
        {
            if (emailAddress == null || emailAddress.Contains("@") == false) //check the "@" sign
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        //Method which return formated name
        public string ShowFormatedName()
        {
            string result;
            FormatName();
            if (IsEmail()) 
            {
                Console.WriteLine("Email adress was detected");
                result = $"{FirstName} {LastName} {MiddleName} {emailAddress}";
            }
            else 
            {
                Console.WriteLine("Error. Field \"Email address\" is empty or incorrect");
                result = $"{FirstName} + {LastName} + {MiddleName}";
            }
            return result;
        }
    }
}
