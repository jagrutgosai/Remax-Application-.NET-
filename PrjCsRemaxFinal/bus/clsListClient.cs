using System;
using System.Collections.Generic;
using System.Text;

namespace PrjCsRemaxFinal.data
{
    public class clsListClient
    {
        private Dictionary<string, clsClient> myList = new Dictionary<string, clsClient>();

       

        public int NumberOfClients
        {
            get
            {
                return myList.Count;
            }
        }

        public Dictionary<string, clsClient>.ValueCollection NumberOfElements
        {
            get
            {
                return myList.Values;
            }
        }

        public bool Add(clsClient Client)
        {
            if (myList.ContainsKey(Client.RefAgent) == false)
            {
                myList.Add(Client.RefAgent, Client);
                return true;
            }
            else { return false; }

        }

        public bool Delete(string Number)
        {

            return myList.Remove(Number);
        }

        public clsClient Find(string Number)
        {
            if (myList.ContainsKey(Number) == true)
            {
                return myList[Number];
            }
            else { return null; }
        }

        public bool Exist(string Number)
        {

            return myList.ContainsKey(Number);

        }
    }

}
