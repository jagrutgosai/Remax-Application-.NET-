using System;
using System.Collections.Generic;
using System.Text;

namespace PrjCsRemaxFinal.data
{
    public abstract class clsEmployee
    {
        private String vNumber;
        private string vName;
        private DateTime vJoinDate;
        private String vPassword;

        public String Name
        {
            get => default;
            set
            {
            }
        }

        public string Number
        {
            get => default;
            set
            {
            }
        }

        public DateTime JoinDate
        {
            get => default;
            set
            {
            }
        }

        public string Password 
        { get => vPassword; set => vPassword = value; }
    }
}