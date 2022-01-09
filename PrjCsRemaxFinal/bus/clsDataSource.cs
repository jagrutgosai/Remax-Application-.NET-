using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace PrjCsRemaxFinal.data
{
    public class  clsDataSource
    {
        OleDbDataAdapter myAdpHouses, myAdpAdmin, myAdpAgent, myAdpBuyer, myAdpSeller,myAdpClients,myAdpMyBuyers, myAdpMySellers,myAdpMyHouses;
        DataSet mySet;

        public DataTable getAdmin()
        {

           OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jagua\source\repos\PrjCsRemaxFinal\PrjCsRemaxFinal\data\Remax.mdb");
            clsAdmin adm = new clsAdmin();
           

            string sql = "SELECT * FROM Employees WHERE EmpNumber like 'ad%'";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            mySet = new DataSet();
            myAdpAdmin = new OleDbDataAdapter(myCmd);
            myAdpAdmin.Fill(mySet, "Admin");
            DataTable tabAdmin = mySet.Tables["Admin"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabAdmin.Columns[0];
            tabAdmin.PrimaryKey = keys;
            return tabAdmin;
        }
        public DataTable getAllAgents()
        {
          OleDbConnection  myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jagua\source\repos\PrjCsRemaxFinal\PrjCsRemaxFinal\data\Remax.mdb");
            string sql = "SELECT * FROM Employees WHERE EmpNumber like 'ag%'";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            mySet = new DataSet();
           myAdpAgent = new OleDbDataAdapter(myCmd);
            myAdpAgent.Fill(mySet, "Agents");
           DataTable tabAgents = mySet.Tables["Agents"];
           DataColumn[] keys = new DataColumn[1];
            keys[0] = tabAgents.Columns[0];
            tabAgents.PrimaryKey = keys;
            return tabAgents;
        }
        public DataTable getMyAgent(string uid)
        {
            OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jagua\source\repos\PrjCsRemaxFinal\PrjCsRemaxFinal\data\Remax.mdb");
            string sql = "SELECT * FROM Employees WHERE EmpNumber = (SELECT Clients.ReferAgent from Clients where ClNumber='"+uid+"')";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            mySet = new DataSet();
            myAdpAgent = new OleDbDataAdapter(myCmd);
            myAdpAgent.Fill(mySet, "Agents");
            DataTable tabAgents = mySet.Tables["Agents"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabAgents.Columns[0];
            tabAgents.PrimaryKey = keys;
            return tabAgents;
        }
        public DataTable refreshAgents()
        {
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(myAdpAgent);
            // Now we need to update to the database or synchronise to the database
            myAdpAgent.Update(mySet, "Agents");
            // Update the contents of the dataset with fresh contents from database
            mySet.Tables.Remove("Agents");
            myAdpAgent.Fill(mySet, "Agents");
            DataTable tabAgents = mySet.Tables["Agents"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabAgents.Columns[0];
            tabAgents.PrimaryKey = keys;
            return tabAgents;
        }
        public DataTable refreshBuyers()
        {
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(myAdpBuyer);
            myAdpBuyer.Update(mySet, "Buyers");
            mySet.Tables.Remove("Buyers");
            myAdpBuyer.Fill(mySet, "Buyers");
            DataTable tabBuyers = mySet.Tables["Buyers"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabBuyers.Columns[0];
            tabBuyers.PrimaryKey = keys;
            return tabBuyers;
        }
        public DataTable refreshMyBuyers()
        {
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(myAdpMyBuyers);
            myAdpMyBuyers.Update(mySet, "MyBuyers");
            mySet.Tables.Remove("MyBuyers");
            myAdpMyBuyers.Fill(mySet, "MyBuyers");
            DataTable tabBuyers = mySet.Tables["MyBuyers"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabBuyers.Columns[0];
            tabBuyers.PrimaryKey = keys;
            return tabBuyers;
        }
        public DataTable refreshSellers()
        {
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(myAdpSeller);
            myAdpSeller.Update(mySet, "Sellers");
            mySet.Tables.Remove("Sellers");
            myAdpSeller.Fill(mySet, "Sellers");
            DataTable tabSellers = mySet.Tables["Sellers"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabSellers.Columns[0];
            tabSellers.PrimaryKey = keys;
            return tabSellers;
        }
        public DataTable refreshMySellers()
        {
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(myAdpMySellers);
            myAdpMySellers.Update(mySet, "MySellers");
            mySet.Tables.Remove("MySellers");
            myAdpMySellers.Fill(mySet, "MySellers");
            DataTable tabSellers = mySet.Tables["MySellers"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabSellers.Columns[0];
            tabSellers.PrimaryKey = keys;
            return tabSellers;
        }
        public DataTable refreshHouses()
        {
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(myAdpHouses);
            myAdpHouses.Update(mySet, "Houses");
            mySet.Tables.Remove("Houses");
            myAdpHouses.Fill(mySet, "Houses");
            DataTable tabHouses = mySet.Tables["Houses"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabHouses.Columns[0];
            tabHouses.PrimaryKey = keys;
            return tabHouses;
        }
        public DataTable refreshMyHouses()
        {
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(myAdpMyHouses);
            myAdpMyHouses.Update(mySet, "MyHouses");
            mySet.Tables.Remove("MyHouses");
            myAdpMyHouses.Fill(mySet, "MyHouses");
            DataTable tabHouses = mySet.Tables["MyHouses"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabHouses.Columns[0];
            tabHouses.PrimaryKey = keys;
            return tabHouses;
        }

        public DataTable getAllBuyers()
        {
            OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jagua\source\repos\PrjCsRemaxFinal\PrjCsRemaxFinal\data\Remax.mdb");


            string sql = "SELECT * FROM Clients WHERE ClNumber like 'bl%'";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            myAdpBuyer = new OleDbDataAdapter(myCmd);
            mySet = new DataSet();
            myAdpBuyer.Fill(mySet, "Buyers");
            DataTable tabBuyers = mySet.Tables["Buyers"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabBuyers.Columns[0];
            tabBuyers.PrimaryKey = keys;
            return tabBuyers;
        }

        public DataTable getMyBuyers(string uid)
        {
            OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jagua\source\repos\PrjCsRemaxFinal\PrjCsRemaxFinal\data\Remax.mdb");


            string sql = "SELECT * FROM Clients WHERE ClNumber like 'bl%' AND ReferAgent='"+uid+"'";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            myAdpMyBuyers = new OleDbDataAdapter(myCmd);
            mySet = new DataSet();
            myAdpMyBuyers.Fill(mySet, "MyBuyers");
            DataTable tabBuyers = mySet.Tables["MyBuyers"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabBuyers.Columns[0];
            tabBuyers.PrimaryKey = keys;
            return tabBuyers;
        }

        public DataTable getAllSellers()
        {


            OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jagua\source\repos\PrjCsRemaxFinal\PrjCsRemaxFinal\data\Remax.mdb");
            string sql = "SELECT * FROM Clients WHERE ClNumber like 'sl%'";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            myAdpSeller = new OleDbDataAdapter(myCmd);
            mySet = new DataSet();
            myAdpSeller.Fill(mySet, "Sellers");
            DataTable tabSellers = mySet.Tables["Sellers"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabSellers.Columns[0];
            tabSellers.PrimaryKey = keys;
            return tabSellers;
        }
        public DataTable getMySellers(string uid)
        {


            OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jagua\source\repos\PrjCsRemaxFinal\PrjCsRemaxFinal\data\Remax.mdb");
            string sql = "SELECT * FROM Clients WHERE ClNumber like 'sl%' AND ReferAgent='" + uid + "'";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            myAdpMySellers = new OleDbDataAdapter(myCmd);
            mySet = new DataSet();
            myAdpMySellers.Fill(mySet, "MySellers");
            DataTable tabSellers = mySet.Tables["MySellers"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabSellers.Columns[0];
            tabSellers.PrimaryKey = keys;
            return tabSellers;
        }
        public DataTable getAllCLients()
        {
            OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jagua\source\repos\PrjCsRemaxFinal\PrjCsRemaxFinal\data\Remax.mdb");
            string sql = "SELECT * FROM Clients";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            myAdpClients = new OleDbDataAdapter(myCmd);
            mySet = new DataSet();
            myAdpClients.Fill(mySet, "Clients");
            DataTable tabClients = mySet.Tables["Clients"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabClients.Columns[0];
            tabClients.PrimaryKey = keys;
            return tabClients;
        }

        public DataTable getAllHouses()
        {
            OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jagua\source\repos\PrjCsRemaxFinal\PrjCsRemaxFinal\data\Remax.mdb");
            string sql = "SELECT * FROM Houses";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            myAdpHouses = new OleDbDataAdapter(myCmd);
            mySet = new DataSet();
            myAdpHouses.Fill(mySet, "Houses");
            DataTable tabHouses = mySet.Tables["Houses"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabHouses.Columns[0];
            tabHouses.PrimaryKey = keys;
            return tabHouses;
        }
        public DataTable getMyHouses(string uid)
        {
            OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jagua\source\repos\PrjCsRemaxFinal\PrjCsRemaxFinal\data\Remax.mdb");
            string sql = "SELECT * FROM Houses WHERE ReferSeller='"+uid+"'";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            myAdpMyHouses = new OleDbDataAdapter(myCmd);
            mySet = new DataSet();
            myAdpMyHouses.Fill(mySet, "MyHouses");
            DataTable tabHouses = mySet.Tables["MyHouses"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabHouses.Columns[0];
            tabHouses.PrimaryKey = keys;
            return tabHouses;
        }
        public void refreshDataAdmin()
        {
            
        }

        public void refreshDataAgent()
        {

        }

        public void refreshDataBuyer()
        {

        }

        public void refreshDataSeller()
        {

        }
    }
}
