using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiaTienTraSua
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
        }

        private void btnCaculator_Click(object sender, EventArgs e)
        {
            try
            {
                int totalMoney = 0;
                int totalAfterDiscount = 0;
                int person = 0;
                int disCount = 0;
                int disCountPerPeson = 0;
                bool percentDiscount = false;

                if (txtDiscount.Text.ToString().Equals(""))
                {
                    txtDiscount.Text = "0";
                }

                if (txtDiscount.Text.ToString().Contains("%"))
                {
                    percentDiscount = true;
                    string txtDisCountPercent = txtDiscount.Text.ToString().Replace("%","");
                    disCount = int.Parse(txtDisCountPercent.ToString());
                }
                else
                {
                    disCount = int.Parse(txtDiscount.Text.ToString());

                    person = dgvMain.Rows.Count - 1;

                    if (person == 0)
                    {
                        person = 1;
                    }

                    disCountPerPeson = disCount / person;
                }

                int rowsCount = dgvMain.Rows.Count - 1;

                for(int i = 0; i < rowsCount; ++i)
                {
                    string strMoney = dgvMain.Rows[i].Cells[1].Value.ToString();
                    if (strMoney == "")
                    {
                        strMoney = "0";
                    }
                    int iMoney = int.Parse(strMoney);
                    totalMoney += iMoney;

                    if (percentDiscount)
                    {
                        double dNewMoney = iMoney / 100.0 * (100 - disCount);
                        int iNewMoney = (int)dNewMoney;
                        int iLamTron = (iNewMoney + 1000 / 2) / 1000 * 1000;
                        totalAfterDiscount += iLamTron;
                        dgvMain.Rows[i].Cells[2].Value = iLamTron.ToString();
                    }
                    else
                    {
                        int iNewMoney = iMoney - disCountPerPeson;
                        int iLamTron = (iNewMoney + 1000 / 2) / 1000 * 1000;
                        totalAfterDiscount += iLamTron;
                        dgvMain.Rows[i].Cells[2].Value = iLamTron.ToString();
                    }
                }

                txtTotal.Text = totalMoney.ToString();
                txtTotalAfterDiscount.Text = totalAfterDiscount.ToString();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                MessageBox.Show(err);
            }
        }

        private void dgvMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cells = dgvMain.SelectedCells;
            foreach(DataGridViewCell cell in cells)
            {
                string cellVal = cell.Value.ToString();
            }
        }
    }
}
