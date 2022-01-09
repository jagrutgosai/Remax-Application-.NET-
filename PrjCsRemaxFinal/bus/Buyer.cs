using System;
using System.Collections.Generic;
using System.Text;

namespace PrjCsRemaxFinal.data
{
    public class clsBuyer : clsClient
    {
        private string vBuyerID;

        public clsBuyer()
        {
            this.ClientName = this.BuyerID = this.RefAgent = "Not Defined"; 
            
        }

        public clsBuyer(string cname, string bid, string refagent)
        {
            this.ClientName = cname;
            this.BuyerID = bid;
            this.RefAgent = refagent;
        }



        public string BuyerID
        {
            get => default;
            set
            {
            }
        }
    }
}