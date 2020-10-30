using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingProgram
{
    public partial class CashierWindowQueueForm : Form
    {
        private CashierClass cashier;
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            cashier = new CashierClass();
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();


            btnRefresh.Enabled = false;
        }

        private void timer1_tick(object sender, EventArgs e)
        {
           
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (String obj in CashierList)
            {
                listCashierQueue.Items.Add(obj);
            }


        }

        private void btnNext_Click(object sender, EventArgs e)
        {

          

            NowServingForm f4 = new NowServingForm();
            f4.Show();
            DisplayCashierQueue(CashierClass.CashierQueue);
                
         
                
        }
                     
    }
            
           


 }
 

