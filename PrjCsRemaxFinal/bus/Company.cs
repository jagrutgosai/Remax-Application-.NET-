using System;
using System.Collections.Generic;
using System.Text;

namespace PrjCsRemaxFinal.data
{
    public abstract class clsCompany
    {
        private string vName;
        private System.DateTime vStartUpDate;
        private clsAdmin vAdmin;
        private clsAgent vAgents;

        public string Name
        {
            get => vName;
            set
            {
                vName = value;
            }
        }

        public System.DateTime StartUpDate
        {
            get => vStartUpDate;
            
        }

        public clsAdmin Admin
        {
            get => default;
            set
            {
            }
        }

        public int Agents
        {
            get => default;
            set
            {
            }
        }
    }
}