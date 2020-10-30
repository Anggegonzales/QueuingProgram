using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingProgram
{
    public partial class NowServingForm : Form
    {

        private CashierClass cashier;
        public NowServingForm()
        {

            InitializeComponent();
        }

        private void NowServingForm_Load(object sender, EventArgs e)
        {

            

            try {

                if (CashierClass.CashierQueue.Count == 0)
                {
                    throw new ArgumentNullException("Queue is Empty");
                    
                }
                if (CashierClass.CashierQueue.Count > 0)
                {
                    lblServe.Text = CashierClass.CashierQueue.Peek();
                    CashierClass.CashierQueue.Dequeue();
                }
                {
                    DisplayCashierQueue1(CashierClass.CashierQueue);
                    
                    
                    timer1.Start();
                }
            } catch (ArgumentNullException er) {
                MessageBox.Show(er.Message);
                System.Windows.Forms.Application.Exit();
            }
        }

        private int ticker = 1;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (ticker <= 3)
            {
                ticker++;
            }
            else
            {
                //CashierClass.CashierQueue.Dequeue();
                timer1.Stop();
                Close();
            }
        }
        private void DisplayCashierQueue1(IEnumerable CashierList)
        {
            listViewNext.Items.Clear();
            foreach (String obj in CashierList)
            {
                listViewNext.Items.Add(obj);
                
            }
            
           
         
                //{

                //listViewNext.Items.Add(CashierQueueEnum.Current.ToString());

                //}







            }



            //if (CashierClass.CashierQueue.Count > 0)
            //{
            //    lblServe.Text = CashierClass.CashierQueue.Peek();
            //} else
            //{
            //    MessageBox.Show("Queue is Empty");
            //} 



        
    }
}

