using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeshipTask
{
    public class FormatUserInfo
    {
        //Input fields
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        //Additional field
        public string EmailAddress { get; set; } = null;

        //Initial for MiddleName field
        private char InitialMiddleName { get; set; }


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
            FirstName = char.ToUpper(FirstName[0]) + FirstName.Substring(1).ToLower();

            LastName = LastName.Replace(" ", "");
            LastName = char.ToUpper(LastName[0]) + LastName.Substring(1).ToLower();

            MiddleName = MiddleName.Replace(" ", "");
            MiddleName = char.ToUpper(MiddleName[0]) + MiddleName.Substring(1).ToLower();
        }
        //Get initial for MiddleName field
        private void GetMiddleInitial()
        {
            InitialMiddleName = MiddleName[0];
        }
        
        //Method which return formated name
        public string ShowFormatedName()
        {
            FormatName();
            GetMiddleInitial();
            string result = $"{LastName} {FirstName} {InitialMiddleName}.";
            return result;
        }
    }
}
