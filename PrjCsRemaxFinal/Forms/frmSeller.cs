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
    public partial class frmSeller : Form
    {
        //Global Variables
        string mode,uid;
        int currpos;
        DataTable tabHouses;
        DataRow myRow;
        clsDataSource myDs;
        public frmSeller()
        {
            InitializeComponent();
        }
        private void hideHouseInfo()
        {
            txtId.Visible = txtname.Visible =  false;
            lblEntries.Visible = lblId.Visible =  lblName.Visible = false;
            btnFirst.Visible = btnPrev.Visible = btnNext.Visible = btnLast.Visible = btnSave.Visible = btnCancel.Visible = false;
            btnDelete.Visible = btnEdit.Visible = false;
        }
        private void showHouseInfo()
        {
            txtId.Visible = txtname.Visible =  true;
            lblEntries.Visible = lblId.Visible = lblName.Visible =  true;
            btnFirst.Visible = btnPrev.Visible = btnNext.Visible = btnLast.Visible = btnSave.Visible = btnCancel.Visible = true;
            btnDelete.Visible = btnEdit.Visible = true;
        }
        private void frmSeller_Load(object sender, EventArgs e)
        {
            hideHouseInfo();
            uid = frmUserVerification.uv.txtUid.Text;
            currpos = 0;
            myDs = new clsDataSource();
            tabHouses = myDs.getMyHouses(uid);
           
            lblWelcome.Text = "Welcome " + myDs.getAllSellers().Rows.Find(uid)["ClName"].ToString();
            lblAgentInfo.Text = "Your agent: " + myDs.getMyAgent(uid).Rows[0]["EmpName"].ToString();

        }
        private void DisplayData()
        {
            txtId.Text = myRow["HouseNum"].ToString();
            txtname.Text = myRow["HouseName"].ToString();
            lblEntries.Text = "Showing #" + (currpos + 1) + " entry out of " + tabHouses.Rows.Count + "entries";
        }
        private void btnDispHouses_Click(object sender, EventArgs e)
        {
            showHouseInfo();
            btnSave.Visible = btnCancel.Visible = false;
            myRow = tabHouses.Rows[currpos];
            DisplayData();
        }
        private void ActivateButtons(bool AdEdDel, bool SavCanc, bool Navig)
        {
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = AdEdDel;
            btnSave.Enabled = btnCancel.Enabled = SavCanc;
            btnNext.Enabled = btnLast.Enabled = btnPrev.Enabled = btnLast.Enabled = Navig;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            showHouseInfo();
            btnSave.Visible = btnCancel.Visible = true;
            btnFirst.Visible = btnPrev.Visible = btnNext.Visible = btnLast.Visible = false;
            lblEntries.Text = "Adding Mode";
            txtId.Text = txtname.Text =  "";
            txtId.Text = "hs";
          
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure to delete this House?";
            string title = "Warning : House deletion";
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                tabHouses.Rows[currpos].Delete();
                tabHouses = myDs.refreshMyHouses();
                currpos = 0;
                myRow = tabHouses.Rows[currpos];
                DisplayData();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currpos = 0;
            myRow = tabHouses.Rows[currpos];
            DisplayData();
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
            myRow = tabHouses.Rows[currpos];
            DisplayData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currpos < (tabHouses.Rows.Count - 1))
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
            myRow = tabHouses.Rows[currpos];
            DisplayData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currpos = tabHouses.Rows.Count - 1;
            myRow = tabHouses.Rows[currpos];
            DisplayData();
            btnPrev.Enabled = true;
            btnNext.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string name = txtname.Text.Trim();
            

            if (mode == "add")
            {
                myRow = tabHouses.NewRow();
                myRow["HouseNum"] = id;
                myRow["HouseName"] = name;
                myRow["ReferSeller"] = uid;
               
                if (tabHouses.Rows.Find(id) != null)
                {
                    MessageBox.Show("The House ID is already taken. Try another.");
                }
                else
                {

                    tabHouses.Rows.Add(myRow);
                    currpos = tabHouses.Rows.Count - 1;
                }
            }
            else if (mode == "edit")
            {
                myRow = tabHouses.Rows[currpos];
                myRow["HouseNum"] = id;
                myRow["HouseName"] = name;

                txtId.ReadOnly = false;
            }

            tabHouses = myDs.refreshMyHouses();
            DisplayData();
            ActivateButtons(true, false, true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ActivateButtons(true, false, true);
            txtId.ReadOnly = false;
        }
    }
}
