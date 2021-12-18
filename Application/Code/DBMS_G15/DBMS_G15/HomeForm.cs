﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_G15
{
    public partial class HomeForm : Form
    {
        private Form currentChildForm;
        public HomeForm()
        {
            InitializeComponent();
            //panelLogo.BringToFront();
            //Test for hidding from difference role
            //btnProfile.Hide();
            //btnMoney.Hide();
            //btnContract.Hide();
            //btnDriver.Hide();
            //btnPartner.Hide();
            //btnCustomer.Hide();
            //btnDriver.Hide();
            //btnStaff.Hide();
            
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnProduct.Height;
            navMenu.Top = btnProduct.Top;
            navMenu.BringToFront();
            OpenChildForm(new productForm());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        { 
            navMenu.Height = btnOrder.Height;
            navMenu.Top = btnOrder.Top;
            navMenu.BringToFront();
            OpenChildForm(new OrderForm());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnCustomer.Height;
            navMenu.Top = btnCustomer.Top;
            navMenu.BringToFront();
            OpenChildForm(new CustomerForm());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnStaff.Height;
            navMenu.Top = btnStaff.Top;
            navMenu.BringToFront();
            OpenChildForm(new StaffForm());
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnDriver.Height;
            navMenu.Top = btnDriver.Top;
            navMenu.BringToFront();
            OpenChildForm(new DriverForm());
        }

        private void btnPartner_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnPartner.Height;
            navMenu.Top = btnPartner.Top;
            navMenu.BringToFront();
            OpenChildForm(new PartnerForm());
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnContract.Height;
            navMenu.Top = btnContract.Top;
            navMenu.BringToFront();
            OpenChildForm(new ContractForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
            t.Start();
            this.Close();
        }
        private void panelLogo_Click(object sender, EventArgs e)
        {
            navMenu.SendToBack();
            currentChildForm.Close();
        }
        public static void OpenLoginForm()
        {
            Application.Run(new LoginForm());
        }

        private void logoPic_Click(object sender, EventArgs e)
        {
            navMenu.SendToBack();
            currentChildForm.Close();
        }

        private void logoLabel_Click(object sender, EventArgs e)
        {
            navMenu.SendToBack();
            currentChildForm.Close();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnMoney.Height;
            navMenu.Top = btnMoney.Top;
            navMenu.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnProfile.Height;
            navMenu.Top = btnProfile.Top;
            navMenu.BringToFront();
        }
    }
}
