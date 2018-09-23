using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credits.Forms
{
    public partial class ShowAllForm : Form
    {
        public ShowAllForm()
        {
            InitializeComponent();
        }

        private void ShowAllForm_Load(object sender, EventArgs e)
        {
            using (BankDbEntities bn = new BankDbEntities())
            {
                dataGridView1.DataSource = bn.udv_showtotalsummary.ToList();
            }
        }
    }
}
