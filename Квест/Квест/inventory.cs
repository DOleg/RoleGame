﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Квест
{
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }

        private void medicine_Click(object sender, EventArgs e)
        {
            if (Globals.Medic > 0)
                Globals.Heal += 50;
                
            
        }

        private void inventory_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVillage form2 = new FormVillage();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
    }
}
