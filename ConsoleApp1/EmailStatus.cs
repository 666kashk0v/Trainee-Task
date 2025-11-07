using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeshipTask
{
    public class EmailStatus
    {
        //Method which check status of "emailAddress" field
        private bool IsEmail(string EmailAddress)
        {
            if (EmailAddress == null || EmailAddress.Contains("@") == false) //check the "@" sign
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string ReturnEmailStatus(string EmailAddress)
        {
            if (IsEmail(EmailAddress)) { return EmailAddress; }
            else { return "Email is not detected or invalid."; }
        }
    }
}
