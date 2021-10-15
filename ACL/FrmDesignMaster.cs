using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmDesignMaster : Form
    {
        DataTable dt = new DataTable();

        public FrmDesignMaster()
        {
            InitializeComponent();
            dt.Columns.Add("Color");
            dt.Columns.Add("Count");
            dt.Columns.Add("Ends");
            dt.Columns.Add("WarpWeft");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtColor.Text.Trim(), txtYarn.Text.Trim(), txtEnds.Text.Trim(), rdWarp.Checked == true ? "WARP" : "WEFT");
            dgvDesign.DataSource = dt;
        }

        private void dgvDesign_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2");
        }

        private void colorMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmColor frm = new FrmColor();
            frm.Show();
            this.Hide();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
