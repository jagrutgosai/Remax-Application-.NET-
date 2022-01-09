using PrjCsRemaxFinal.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjCsRemaxFinal
{
    public partial  class Remax : Form
    {
        public static Remax instance;
        public Remax()
        {
            InitializeComponent();
            instance = this;
            instance.IsMdiContainer = true;
        }
        
        private void Remax_Load(object sender, EventArgs e)
        {
           
            
            frmUserVerification uv = new frmUserVerification();
            if (uv.ShowDialog(this) == DialogResult.OK)
            {
                
            }
            uv.Dispose();

        }
    }
}
