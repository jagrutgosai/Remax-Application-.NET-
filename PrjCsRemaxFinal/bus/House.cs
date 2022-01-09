using System;
using System.Collections.Generic;
using System.Text;

namespace PrjCsRemaxFinal.data
{
    public class clsHouse
    {
        private string vNumber;
        private string vName;
        private string vRefSeller;

        public clsHouse()
        {
            this.Name = this.Number = this.RefSeller = "Not Defined";
        }

        public clsHouse(string name, string number, string refseller)
        {
            this.Name = name;
            this.Number = number;
            this.RefSeller = refseller;
        }

        public string Name
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

        public string RefSeller
        {
            get => default;
            set
            {
            }
        }
    }
}