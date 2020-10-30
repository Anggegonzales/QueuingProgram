using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingProgram
{
    public partial class QueuingForm : Form
    {
        
        private CashierClass cashier;
        public QueuingForm()
        {
            cashier = new CashierClass();
            InitializeComponent();
        }
        private void QueuingForm_Load(object sender, EventArgs e)
        {
            CashierWindowQueueForm f2 = new CashierWindowQueueForm();
            f2.Show();
            
            
        }
        private void btnCashier_Click(object sender, EventArgs e)
        {

            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
           

        }

     
    }
}
