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
    public partial class frmBuyer : Form
    {
        clsDataSource myDs;
        string uid;
        public frmBuyer()
        {
            InitializeComponent();
        }

        private void btnShowAllHouses_Click(object sender, EventArgs e)
        {
            DataTable AllHouses = myDs.getAllHouses();
            gridView.DataSource = AllHouses;
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

        private void frmBuyer_Load(object sender, EventArgs e)
        {
            myDs = new clsDataSource();
            uid = frmUserVerification.uv.txtUid.Text;
            lblWelcome.Text = "Welcome " + myDs.getAllBuyers().Rows.Find(uid)["ClName"].ToString();
            lblAgentInfo.Text = "Your agent: " + myDs.getMyAgent(uid).Rows[0]["EmpName"].ToString();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            gridView.DataSource = null;
            txtSearch.Clear();
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string msg = "Are you interested in this property?";
            string title = "House Buying Request";
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show("Your request has been forward to your agent.\n Thank you for your interest in the property.");
                
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
