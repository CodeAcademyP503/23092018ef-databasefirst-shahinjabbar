using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Credits.Models;

namespace Credits.Forms
{
    public partial class TakeCreditForm : Form
    {
        public TakeCreditForm()
        {
            InitializeComponent();
        }
        private void btb_addcredit_Click(object sender, EventArgs e)
        {
            using (BankDbEntities bn = new BankDbEntities())
            {
                try
                {
                    
                    if (comboBox1.Text != "" && textBox1.Text != null)
                    {
                        bn.usp_Givecredit(comboBox1.SelectedItem.ToString(), Convert.ToInt32(textBox1.Text), dateTimePicker1.Value, bn.Customers.ToList().Last().Id);
                        ShowAllForm showAllForm = new ShowAllForm();
                        showAllForm.ShowDialog();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void TakeCreditForm_Load(object sender, EventArgs e)
        {
            using (BankDbEntities bn = new BankDbEntities())
            {
                List<Customer> customers = bn.Customers.Where(x => x.Id > 0).ToList();
                comboBox1.Items.Add(bn.Customers.ToList().Last().Name);
            }
        }

    }
}
