using PrjCsRemaxFinal.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace PrjCsRemaxFinal.Forms
{
    public partial class frmAdmin : Form
    {
        //Global Variables
        string mode;
        int currpos;
        DataTable tabAgents;
        DataRow myRow;
        clsDataSource myDs;
        public frmAdmin()
        {
            InitializeComponent();
        }
        private void hideAgentInfo()
        {
            txtId.Visible = txtname.Visible = txtPwd.Visible = dtpJoinD.Visible = false;
            lblEntries.Visible = lblId.Visible = lblJD.Visible = lblName.Visible = lblPwd.Visible = false;
            btnFirst.Visible = btnPrev.Visible = btnNext.Visible = btnLast.Visible = btnSave.Visible = btnCancel.Visible = false;
            btnDelete.Visible = btnEdit.Visible = false;
        }
        private void showAgentInfo()
        {
            txtId.Visible = txtname.Visible = txtPwd.Visible = dtpJoinD.Visible = true;
            lblEntries.Visible = lblId.Visible = lblJD.Visible = lblName.Visible = lblPwd.Visible = true;
            btnFirst.Visible = btnPrev.Visible = btnNext.Visible = btnLast.Visible = btnSave.Visible = btnCancel.Visible = true;
            btnDelete.Visible = btnEdit.Visible = true;
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            hideAgentInfo();
            myDs = new clsDataSource();
            currpos = 0;
            tabAgents = myDs.getAllAgents();
        }
        private void DisplayData()
        {
            txtId.Text = myRow["EmpNumber"].ToString();
            txtname.Text = myRow["EmpName"].ToString();
            txtPwd.Text = myRow["EmpPassword"].ToString();
            dtpJoinD.Value = Convert.ToDateTime(myRow["JoinDate"]);
            lblEntries.Text = "Showing #" + (currpos + 1) + " entry out of " + tabAgents.Rows.Count + "entries";
        }
        private void btnDispAgents_Click(object sender, EventArgs e)
        {
            showAgentInfo();
            btnSave.Visible = btnCancel.Visible = false;
            myRow = tabAgents.Rows[currpos];
            DisplayData();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            showAgentInfo();
            btnSave.Visible = btnCancel.Visible = true;
            btnFirst.Visible = btnPrev.Visible = btnNext.Visible = btnLast.Visible = false;
            lblEntries.Text = "Adding Mode";
            txtId.Text = txtname.Text = txtPwd.Text = "";
            txtId.Text = "ag";
            dtpJoinD.Value = DateTime.Today;
            txtId.Focus();
            mode = "add";
            ActivateButtons(false, true, false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = btnCancel.Visible = true;
            btnFirst.Visible = btnPrev.Visible = btnNext.Visible = btnLast.Visible = false;
            lblEntries.Text = "Editing Mode";
            txtId.ReadOnly = true;
            txtname.Focus();
            mode = "edit";
            ActivateButtons(false, true, false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string name = txtname.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            DateTime jdate = dtpJoinD.Value;

            if(mode == "add")
            {
                myRow = tabAgents.NewRow();
                myRow["EmpNumber"] = id;
                myRow["EmpName"] = name;
                myRow["JoinDate"] = jdate;
                myRow["EmpPassword"] = pwd;
                if (tabAgents.Rows.Find(id) != null)
                {
                    MessageBox.Show("The Employee User ID is already taken. Try another.");
                }
                else
                {

                tabAgents.Rows.Add(myRow);
                currpos = tabAgents.Rows.Count - 1;
                }
            }
            else if(mode == "edit")
            {
                myRow = tabAgents.Rows[currpos];
                myRow["EmpNumber"] = id;
                myRow["EmpName"] = name;
                myRow["JoinDate"] = jdate;
                myRow["EmpPassword"] = pwd;
                txtId.ReadOnly = false;
            }
       
            tabAgents = myDs.refreshAgents();
                DisplayData();
                ActivateButtons(true, false, true);
            
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currpos = 0;
            myRow = tabAgents.Rows[currpos];
            DisplayData();
            btnNext.Enabled = true;
            btnPrev.Enabled = false;
        }
        private void ActivateButtons(bool AdEdDel, bool SavCanc, bool Navig)
        {
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = AdEdDel;
            btnSave.Enabled = btnCancel.Enabled = SavCanc;
            btnNext.Enabled = btnLast.Enabled = btnPrev.Enabled = btnLast.Enabled = Navig;
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currpos > 0)
            {
                currpos -= 1;
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }
            else
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
            }
            myRow = tabAgents.Rows[currpos];
            DisplayData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currpos < (tabAgents.Rows.Count - 1))
            {
                currpos += 1;
                btnNext.Enabled = true;
                btnPrev.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = true;
            }
            myRow = tabAgents.Rows[currpos];
            DisplayData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currpos = tabAgents.Rows.Count - 1;
            myRow = tabAgents.Rows[currpos];
            DisplayData();
            btnPrev.Enabled = true;
            btnNext.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ActivateButtons(true, false, true);
            txtId.ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure to delete this Agent?";
            string title = "Warning : Agent deletion";
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                tabAgents.Rows[currpos].Delete();
                tabAgents = myDs.refreshAgents();
                currpos = 0;
                myRow = tabAgents.Rows[currpos];
                DisplayData();
            }
        }

        private void btnShowAllAgents_Click(object sender, EventArgs e)
        {
            gridView.DataSource = tabAgents;
        }

        private void btnShowAllClients_Click(object sender, EventArgs e)
        {
            DataTable AllClients = myDs.getAllCLients();
            gridView.DataSource = AllClients;
        }

        private void btnShowAllHouses_Click(object sender, EventArgs e)
        {
            DataTable AllHouses = myDs.getAllHouses();
            gridView.DataSource = AllHouses;
        }

        private void btnSrAgent_Click(object sender, EventArgs e)
        {
            string id =txtSearch.Text.Trim();
            if(tabAgents.Rows.Find(id) != null)
            {
                DataTable tempTab = tabAgents.Clone();
                tempTab.ImportRow(tabAgents.Rows.Find(id));
                gridView.DataSource = tempTab;
                
            }
            else
            {
                MessageBox.Show("Please enter a valid Agent ID to search");
            }
        }

        private void btnSrBuyer_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text.Trim();
            DataTable tabBuyers = myDs.getAllBuyers();
            if (tabBuyers.Rows.Find(id) != null)
            {
                DataTable tempTab = tabBuyers.Clone();
                tempTab.ImportRow(tabBuyers.Rows.Find(id));
                gridView.DataSource = tempTab;

            }
            else
            {
                MessageBox.Show("Please enter a valid Buyer ID to search");
            }
        }

        private void btnSrSeller_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text.Trim();
            DataTable tabSellers = myDs.getAllSellers();
            if (tabSellers.Rows.Find(id) != null)
            {
                DataTable tempTab = tabSellers.Clone();
                tempTab.ImportRow(tabSellers.Rows.Find(id));
                gridView.DataSource = tempTab;

            }
            else
            {
                MessageBox.Show("Please enter a valid Seller ID to search");
            }
        }

        private void btnSrHouse_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text.Trim();
            DataTable tabHouses = myDs.getAllHouses();
            if (tabHouses.Rows.Find(id) != null)
            {
                DataTable tempTab = tabHouses.Clone();
                tempTab.ImportRow(tabHouses.Rows.Find(id));
                gridView.DataSource = tempTab;

            }
            else
            {
                MessageBox.Show("Please enter a valid House ID to search");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gridView.DataSource = null;
            txtSearch.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
