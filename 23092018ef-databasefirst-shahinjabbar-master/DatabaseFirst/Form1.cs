using Credits.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_takecredit_Click(object sender, EventArgs e)
        {
            using (BankDbEntities bn = new BankDbEntities())
            {
                try
                {
                    if (txbx_name.Text != null && txbx_surname.Text != null && txbx_passportnumber.Text != null)
                    {
                        bn.usp_AddCustomers(txbx_name.Text, txbx_surname.Text, Convert.ToInt32(txbx_passportnumber.Text));
                        TakeCreditForm tcf = new TakeCreditForm();
                        tcf.ShowDialog();
                    }
                }
                catch (FormatException exp)
                {

                    throw exp;
                }

            }
           
        }
    }
}
