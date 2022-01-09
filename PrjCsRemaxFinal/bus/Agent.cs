using System;
using System.Collections.Generic;
using System.Text;

namespace PrjCsRemaxFinal.data
{
    public class clsAgent : clsEmployee
    {
        private clsListClient vClients;

        public clsAgent()
        {
            this.Name = this.Number = this.Password = "Not defined";
            this.JoinDate = DateTime.Now;
            this.Clients = new clsListClient();
        }

        public clsAgent(string name,string number,string password, DateTime joinDate, clsListClient clients)
        {
            this.Name = name;
            this.Number = number;
            this.Password = password;
            this.JoinDate = joinDate;
            this.Clients = clients;
        }

        public clsListClient Clients
        {
            get => default;
            set
            {
            }
        }

        public clsListHouse clsListHouse
        {
            get => default;
            
        }

        public clsListClient clsListClient
        {
            get => default;
            
        }
    }
}