﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todolist
{
    public partial class display : Form
    {
        public display()
        {
            InitializeComponent();
            DGV1.DataSource = null;
            DGV1.DataSource = Class1.GetAllProducts();

        }

        private void display_Load(object sender, EventArgs e)
        {
            
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
