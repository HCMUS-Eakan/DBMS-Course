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
    public partial class CustomerProfile : Form
    {
        public CustomerProfile()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nameTb.ReadOnly = false;
            addressTb.ReadOnly = false;
            phoneNumTb.ReadOnly = false;
            emailTb.ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            nameTb.ReadOnly = true;
            addressTb.ReadOnly = true;
            phoneNumTb.ReadOnly = true;
            emailTb.ReadOnly = true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}