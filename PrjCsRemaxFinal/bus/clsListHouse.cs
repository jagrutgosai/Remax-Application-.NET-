using System;
using System.Collections.Generic;
using System.Text;

namespace PrjCsRemaxFinal.data
{
    public class clsListHouse
    {
        private Dictionary<string, clsHouse> myList = new Dictionary<string, clsHouse>();

        

        public int NumberOfHouses
        {
            get
            {
                return myList.Count;
            }
            
        }

        public Dictionary<string, clsHouse>.ValueCollection NumberOfElements
        {
            get
            {
                return myList.Values;
            }
        }


        public bool Add(clsHouse House)
        {
            if (myList.ContainsKey(House.Number) == false)
            {
                myList.Add(House.Number, House);
                return true;
            }
            else { return false; }

        }

        public bool Delete(string Number)
        {

            return myList.Remove(Number);
        }

        public clsHouse Find(string Number)
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