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
    public partial class FrmColor : Form
    {
        public FrmColor()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Color");
            dt.Columns.Add("RGB");
            string str = txtRGBFrom.Text.Trim();
            string[] tokensFrom = str.Split(',');

            string strTo = txtRGBTo.Text.Trim();
            string[] tokensTo = strTo.Split(',');

            string _from1, _from2, _from3, _to1, _to2, _to3, _val1, _val2, _val3;

            _from1 = tokensFrom[0].ToString();
            _from2 = tokensFrom[1].ToString();
            _from3 = tokensFrom[2].ToString();
            _to1 = tokensTo[0].ToString();
            _to2 = tokensTo[1].ToString();
            _to3 = tokensTo[2].ToString();

            int _prev1 = 0;
            int _prev2 = 0;
            int _prev3 = 0;

            string count = txtCounts.Text.Trim();

            string _color = txtColorName.Text.Trim();

            for (int i = 0; i < int.Parse(count); i++)
            {
                if (i == 0)
                {
                    _val1 = ((int.Parse(_from1) - int.Parse(_to1)) / int.Parse(count)).ToString();
                    _val2 = ((int.Parse(_from2) - int.Parse(_to2)) / int.Parse(count)).ToString();
                    _val3 = ((int.Parse(_from3) - int.Parse(_to3)) / int.Parse(count)).ToString();
                    _prev1 = int.Parse(_from1) - int.Parse(_val1);
                    _prev2 = int.Parse(_from2) - int.Parse(_val2);
                    _prev3 = int.Parse(_from3) - int.Parse(_val3);
                }
                else
                {
                    _val1 = ((_prev1 - int.Parse(_to1)) / int.Parse(count)).ToString();
                    _val2 = ((_prev2 - int.Parse(_to2)) / int.Parse(count)).ToString();
                    _val3 = ((_prev3 - int.Parse(_to3)) / int.Parse(count)).ToString();
                    _prev1 = _prev1 - int.Parse(_val1);
                    _prev2 = _prev2 - int.Parse(_val2);
                    _prev3 = _prev3 - int.Parse(_val3);
                }

                _color = txtColorName.Text.Trim() + (i + 1).ToString();

                string _rgb = _prev1.ToString() + "," + _prev2.ToString() + "," + _prev3.ToString();

                dt.Rows.Add(_color,_rgb);

                dgvColor.DataSource = dt;
            }
        }

        private void designMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDesignMaster frm = new FrmDesignMaster();
            frm.Show();
            this.Hide();
        }

        private void countMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
