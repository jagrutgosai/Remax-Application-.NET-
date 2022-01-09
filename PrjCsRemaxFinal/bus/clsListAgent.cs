using System;
using System.Collections.Generic;
using System.Text;

namespace PrjCsRemaxFinal.data
{
    public class clsListAgent
    {

        private Dictionary<string, clsAgent> myList = new Dictionary<string, clsAgent>();

        

        public int NumberOfAgents
        {
            get
            {
                return myList.Count;
            }
        }

        public Dictionary<string, clsAgent>.ValueCollection NumberOfElements
        {
            get
            {
                return myList.Values;
            }
        }
        public bool Add(clsAgent Agent)
        {
            if (myList.ContainsKey(Agent.Number) == false)
            {
                myList.Add(Agent.Number, Agent);
                return true;
            }
            else { return false; }

        }

        public bool Delete(string Number)
        {

            return myList.Remove(Number);
        }

        public clsAgent Find(string Number)
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