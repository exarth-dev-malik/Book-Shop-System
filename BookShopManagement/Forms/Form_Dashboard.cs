using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class Form_Dashboard : Form
    {
        int PanelWidth;
        bool isCollapased;
        public Form_Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapased = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapased)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapased = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if(panelLeft.Width<=44)
                {
                    isCollapased = true;
                    this.Refresh();
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btnSalesBooks_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSalesBooks);
        }

        private void btnPurchaseItems_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPurchaseItems);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnExpenses);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnViewSales);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSettings);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTimer.Text = dt.ToString("HH:MM:ss");
        }

        private void lblDashboardMarque_Click(object sender, EventArgs e)
        {

        }
        private void Lbl_DashMarquee_MouseEnter(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void Lbl_DashMarquee_MouseLeave(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
