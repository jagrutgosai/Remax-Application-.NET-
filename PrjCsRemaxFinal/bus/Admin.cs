using System;
using System.Collections.Generic;
using System.Text;

namespace PrjCsRemaxFinal.data
{
    public class clsAdmin : clsEmployee
    {
        private clsListAgent vAgents;
        private clsListClient vClients;
        private clsListHouse vHouses;

        public clsAdmin()
        {
            this.Name = this.Number = this.Password = "Not defined";
            this.JoinDate = DateTime.Now;
            this.Agents = new clsListAgent();
            this.Clients = new clsListClient();
            this.Houses = new clsListHouse();
        }

        public clsAdmin(String name, String number, String password, DateTime joinDate, clsListAgent agents, clsListClient clients, clsListHouse houses)
        {
            this.Name = name;
            this.Number = number;
            this.Password = password;
            this.JoinDate = joinDate;
            this.Agents = agents;
            this.Clients = clients;
            this.Houses = houses;
        }

        public clsListAgent Agents
        {
            get => default;
            set
            {
            }
        }

        public clsListClient Clients
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