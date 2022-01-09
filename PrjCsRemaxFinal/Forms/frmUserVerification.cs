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
    public partial class frmUserVerification : Form
    {
        public static frmUserVerification uv;
        public TextBox txtUid;
        public frmUserVerification()
        {
            InitializeComponent();
            uv = this;
            txtUid = txtUserId;

        }

        private void frmUserVerification_Load(object sender, EventArgs e)
        {
           
        }
        
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
                clsDataSource myDs = new clsDataSource();
                string uid = txtUserId.Text.Trim();
                string pwd = txtPwd.Text.Trim();
           
           

            if (rdbtnClient.Checked)
            {
                DataTable tabBuyers = myDs.getAllBuyers();
               
                DataTable tabSellers = myDs.getAllSellers();
                if (tabBuyers.Rows.Find(uid) != null && tabBuyers.Rows.Find(uid)["ClNumber"].ToString() == uid && tabBuyers.Rows.Find(uid)["ClPassword"].ToString() == pwd)
                {
                    //MessageBox.Show("Login Successful");
                    frmBuyer curBuyer = new frmBuyer();
                    curBuyer.MdiParent = Remax.instance;
                    curBuyer.Show();
                    this.DialogResult = DialogResult.Yes;
                    
                }
                else if (tabSellers.Rows.Find(uid) != null && tabSellers.Rows.Find(uid)["ClNumber"].ToString() == uid && tabSellers.Rows.Find(uid)["ClPassword"].ToString() == pwd)
                {
                    //MessageBox.Show("Login Successful");
                    frmSeller curSeller = new frmSeller();
                    curSeller.MdiParent = Remax.instance;
                    curSeller.Show();
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            }
            else if (rdbtnManage.Checked)
            {
            
               DataTable  myAdm = myDs.getAdmin();
               
                if (myAdm.Rows.Find(uid) !=null && myAdm.Rows.Find(uid)["EmpNumber"].ToString() == uid && myAdm.Rows.Find(uid)["EmpPassword"].ToString() == pwd)
                {
                    frmAdmin curAdm = new frmAdmin();
                     curAdm.MdiParent = Remax.instance;
                    //  this.Close();
                    curAdm.Show();
                    this.DialogResult = DialogResult.Yes;
                    // MessageBox.Show("Login Successful");
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            }
            else if (rdbtnEmployee.Checked)
            {
                DataTable tabAgents = myDs.getAllAgents();
                if(tabAgents.Rows.Find(uid) != null && tabAgents.Rows.Find(uid)["EmpNumber"].ToString() == uid && tabAgents.Rows.Find(uid)["EmpPassword"].ToString() == pwd)
                {
                    //MessageBox.Show("Login Successful");
                    frmAgent curAgent = new frmAgent();
                      curAgent.MdiParent = Remax.instance;
                    curAgent.Show();
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }

            }
            else
            {
                MessageBox.Show("Please select if you're an employee or a client");
            }
        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPwd.Text = txtUserId.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
