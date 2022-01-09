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

namespace PrjCsRemaxFinal.Forms
{
    public partial class frmAgent : Form
    {
        //Global Variables
        string mode,uid;
        int currpos;
        DataTable tabBuyers, tabSellers;
        DataRow myRow;
        clsDataSource myDs,allDs;
        bool isSeller;
        public frmAgent()
        {
            InitializeComponent();
        }
        private void hideClientInfo()
        {
            txtId.Visible = txtname.Visible = txtPwd.Visible =  false;
            lblEntries.Visible = lblId.Visible =  lblName.Visible = lblPwd.Visible = false;
            btnFirst.Visible = btnPrev.Visible = btnNext.Visible = btnLast.Visible = btnSave.Visible = btnCancel.Visible = false;
            btnDeleteBuy.Visible = btnDeleteSel.Visible= btnEditBuy.Visible = btnEditSel.Visible = false;
        }
        private void DisplayData(bool seller)
        {
            txtId.Text = myRow["ClNumber"].ToString();
            txtname.Text = myRow["ClName"].ToString();
            txtPwd.Text = myRow["ClPassword"].ToString();
            if (seller)
            {

            lblEntries.Text = "Showing #" + (currpos + 1) + " entry out of " + tabSellers.Rows.Count + "entries";
                btnAddBuy.Visible = btnEditBuy.Visible = btnDeleteBuy.Visible = false;
                btnAddSel.Visible = btnEditSel.Visible = btnDeleteSel.Visible = true;
            }
            else
            {
                btnAddBuy.Visible = btnEditBuy.Visible = btnDeleteBuy.Visible = true;
                btnAddSel.Visible = btnEditSel.Visible = btnDeleteSel.Visible = false;
                lblEntries.Text = "Showing #" + (currpos + 1) + " entry out of " + tabBuyers.Rows.Count + "entries";
            }
        }
        private void btnDispBuyers_Click(object sender, EventArgs e)
        {
            showClientInfo();
            btnSave.Visible = btnCancel.Visible = false;
            if (tabBuyers.Rows.Count !=0)
            {
            myRow = tabBuyers.Rows[currpos];
            isSeller = false;
            DisplayData(isSeller);

            }
            else
            {
                MessageBox.Show("You have no clients. Add one");
                isSeller = false;
            }
        }

        private void btnDispSellers_Click(object sender, EventArgs e)
        {
            showClientInfo();
            btnSave.Visible = btnCancel.Visible = false;
            if (tabSellers.Rows.Count != 0)
            {

            myRow = tabSellers.Rows[currpos];
                isSeller = true;
                DisplayData(isSeller);
            }
            else
            {
                MessageBox.Show("You have no clients. Add one");
                isSeller = true;
            }
           
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currpos = 0;
            if (isSeller)
            {
                myRow = tabSellers.Rows[currpos];
            }
            else
            {
            myRow = tabBuyers.Rows[currpos];

            }
            DisplayData(isSeller);
            btnNext.Enabled = true;
            btnPrev.Enabled = false;
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
            if (isSeller)
            {
                myRow = tabSellers.Rows[currpos];
            }
            else
            {
                myRow = tabBuyers.Rows[currpos];

            }
            DisplayData(isSeller);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if (isSeller)
            {
                if (currpos < (tabSellers.Rows.Count - 1))
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
                myRow = tabSellers.Rows[currpos];
            }
            else
            {
                if (currpos < (tabBuyers.Rows.Count - 1))
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
                myRow = tabBuyers.Rows[currpos];

            }
            DisplayData(isSeller);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (isSeller)
            {
            currpos = tabSellers.Rows.Count - 1;
            myRow = tabSellers.Rows[currpos];

            }
            else
            {
                currpos = tabBuyers.Rows.Count - 1;
                myRow = tabBuyers.Rows[currpos];
            }

            DisplayData(isSeller);
            btnPrev.Enabled = true;
            btnNext.Enabled = false;
        }

        private void btnAddBuy_Click(object sender, EventArgs e)
        {
            showClientInfo();
            btnSave.Visible = btnCancel.Visible = true;
            btnFirst.Visible = btnPrev.Visible = btnNext.Visible = btnLast.Visible = false;
            lblEntries.Text = "Buyer: Adding Mode";
            txtId.Text = txtname.Text = txtPwd.Text = "";
            txtId.Text = "bl";
          
            txtId.Focus();
            mode = "add";
            ActivateButtons(false, true, false,isSeller);
        }
        private void ActivateButtons(bool AdEdDel, bool SavCanc, bool Navig,bool seller)
        {
            if (isSeller)
            {
                btnAddSel.Enabled = btnEditSel.Enabled = btnDeleteSel.Enabled = btnAddBuy.Enabled = btnEditBuy.Enabled= btnDeleteBuy.Enabled =  AdEdDel;
            }
            else
            {

            btnAddBuy.Enabled = btnEditBuy.Enabled = btnDeleteBuy.Enabled = btnAddSel.Enabled = btnEditSel.Enabled = btnDeleteSel.Enabled = AdEdDel;
            }
            btnSave.Enabled = btnCancel.Enabled = SavCanc;
            btnNext.Enabled = btnLast.Enabled = btnPrev.Enabled = btnLast.Enabled = Navig;
        }
        private void btnAddSel_Click(object sender, EventArgs e)
        {
            showClientInfo();
            btnSave.Visible = btnCancel.Visible = true;
            btnFirst.Visible = btnPrev.Visible = btnNext.Visible = btnLast.Visible = false;
            lblEntries.Text = "Seller: Adding Mode";
            txtId.Text = txtname.Text = txtPwd.Text = "";
            txtId.Text = "sl";

            txtId.Focus();
            mode = "add";
            ActivateButtons(false, true, false, isSeller);
        }

        private void btnEditBuy_Click(object sender, EventArgs e)
        {
            showClientInfo();
            btnSave.Visible = btnCancel.Visible = true;
            btnFirst.Visible = btnPrev.Visible = btnNext.Visible = btnLast.Visible = false;
            lblEntries.Text = "Buyer: Editing Mode";
            txtname.Focus();
            txtId.ReadOnly = true;
            mode = "edit";
            ActivateButtons(false, true, false, isSeller);

        }

        private void btnEditSel_Click(object sender, EventArgs e)
        {
            showClientInfo();
            btnSave.Visible = btnCancel.Visible = true;
            btnFirst.Visible = btnPrev.Visible = btnNext.Visible = btnLast.Visible = false;
            lblEntries.Text = "Seller: Editing Mode";
            txtname.Focus();
            txtId.ReadOnly = true;
            mode = "edit";
            ActivateButtons(false, true, false, isSeller);
        }

        private void btnDeleteBuy_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure to delete this Buyer?";
            string title = "Warning : Buyer deletion";
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

               tabBuyers.Rows[currpos].Delete();
                tabBuyers = myDs.refreshBuyers();
                currpos = 0;
                myRow = tabBuyers.Rows[currpos];
                DisplayData(isSeller);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string name = txtname.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            if (isSeller)
            {
                if (mode == "add")
                {
                    myRow = tabSellers.NewRow();
                    myRow["ClNumber"] = id;
                    myRow["ClName"] = name;
                    myRow["ReferAgent"] = uid;
                    myRow["ClPassword"] = pwd;
                    if (tabSellers.Rows.Find(id) != null)
                    {
                        MessageBox.Show("The Seller User ID is already taken. Try another.");
                    }
                    else
                    {

                        tabSellers.Rows.Add(myRow);
                        currpos = tabSellers.Rows.Count - 1;
                    }
                }
                else if (mode == "edit")
                {
                    myRow = tabSellers.Rows[currpos];
                    myRow["ClNumber"] = id;
                    myRow["ClName"] = name;
                    myRow["ReferAgent"] = uid;
                    myRow["ClPassword"] = pwd;
                    txtId.ReadOnly = false;
                }

                tabSellers = myDs.refreshMySellers();
                DisplayData(isSeller);
                ActivateButtons(true, false, true,isSeller);


            }
            else
            {
                if (mode == "add")
                {
                    myRow = tabBuyers.NewRow();
                    myRow["ClNumber"] = id;
                    myRow["ClName"] = name;
                    myRow["ReferAgent"] = uid;
                    myRow["ClPassword"] = pwd;
                    if (tabBuyers.Rows.Find(id) != null)
                    {
                        MessageBox.Show("The Buyer User ID is already taken. Try another.");
                    }
                    else
                    {

                        tabBuyers.Rows.Add(myRow);
                        currpos = tabBuyers.Rows.Count - 1;
                    }
                }
                else if (mode == "edit")
                {
                    myRow = tabBuyers.Rows[currpos];
                    myRow["ClNumber"] = id;
                    myRow["ClName"] = name;
                    myRow["ReferAgent"] = uid;
                    myRow["ClPassword"] = pwd;
                    txtId.ReadOnly = false;
                }

                tabBuyers = myDs.refreshMyBuyers();
                DisplayData(isSeller);
                ActivateButtons(true, false, true, isSeller);


            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ActivateButtons(true, false, true,isSeller);
            txtId.ReadOnly = false;
        }

        private void btnShowAllAgents_Click(object sender, EventArgs e)
        {
            gridView.DataSource = allDs.getAllAgents();
        }

        private void btnShowAllClients_Click(object sender, EventArgs e)
        {
            gridView.DataSource = allDs.getAllCLients();
        }

        private void btnShowAllHouses_Click(object sender, EventArgs e)
        {
            gridView.DataSource = allDs.getAllHouses();
        }

        private void btnSrAgent_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text.Trim();
            DataTable AllAgents = allDs.getAllAgents();
            if (AllAgents.Rows.Find(id) != null)
            {
                DataTable tempTab = AllAgents.Clone();
                tempTab.ImportRow(AllAgents.Rows.Find(id));
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
            DataTable AllBuyers = allDs.getAllBuyers();
            if (AllBuyers.Rows.Find(id) != null)
            {
                DataTable tempTab = AllBuyers.Clone();
                tempTab.ImportRow(AllBuyers.Rows.Find(id));
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
            DataTable AllSellers = allDs.getAllSellers();
            if (AllSellers.Rows.Find(id) != null)
            {
                DataTable tempTab = AllSellers.Clone();
                tempTab.ImportRow(AllSellers.Rows.Find(id));
                gridView.DataSource = tempTab;

            }
            else
            {
                MessageBox.Show("Please enter a valid Buyer ID to search");
            }
        }

        private void btnSrHouse_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text.Trim();
            DataTable AllHouses = allDs.getAllHouses();
            if (AllHouses.Rows.Find(id) != null)
            {
                DataTable tempTab = AllHouses.Clone();
                tempTab.ImportRow(AllHouses.Rows.Find(id));
                gridView.DataSource = tempTab;

            }
            else
            {
                MessageBox.Show("Please enter a valid Buyer ID to search");
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

        private void btnDeleteSel_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure to delete this Seller?";
            string title = "Warning : Seller deletion";
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                tabSellers.Rows[currpos].Delete();
                tabSellers = myDs.refreshMySellers();
                currpos = 0;
                myRow = tabSellers.Rows[currpos];
                DisplayData(isSeller);
            }
        }

        private void showClientInfo()
        {
            txtId.Visible = txtname.Visible = txtPwd.Visible = true;
            lblEntries.Visible = lblId.Visible = lblName.Visible = lblPwd.Visible = true;
            btnFirst.Visible = btnPrev.Visible = btnNext.Visible = btnLast.Visible = btnSave.Visible = btnCancel.Visible = true;
            btnDeleteBuy.Visible = btnDeleteSel.Visible = btnEditBuy.Visible = btnEditSel.Visible = true;
        }
        private void frmAgent_Load(object sender, EventArgs e)
        {
            hideClientInfo();
            myDs = new clsDataSource();
            allDs = new clsDataSource();
            currpos = 0;
            uid = frmUserVerification.uv.txtUid.Text;
            tabBuyers = myDs.getMyBuyers(uid);
            tabSellers = myDs.getMySellers(uid);

        }
    }
}
