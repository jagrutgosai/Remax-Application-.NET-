using System;
using System.Collections.Generic;
using System.Text;

namespace PrjCsRemaxFinal.data
{
    public class clsSeller : clsClient
    {
        private string vSellerID;
        private clsListHouse vHouses;

        public clsSeller()
        {
            this.ClientName = this.SellerID = this.RefAgent = "Not Defined";
            this.Houses = new clsListHouse();
        }
        public clsSeller(string cname, string sellerid, string refagent, clsListHouse houses)
        {
            this.ClientName = cname;
            this.SellerID = sellerid;
            this.RefAgent = refagent;
            this.Houses = houses;
        }

        public string SellerID
        {
            get => default;
            set
            {
            }
        }

        public clsListHouse Houses
        {
            get => default;
            set
            {
            }
        }
    }
}