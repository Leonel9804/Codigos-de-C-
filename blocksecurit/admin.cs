﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blocksecurit
{
    public partial class admin : Form
    {
        public admin(String nombre)
        {
            InitializeComponent();
            lblmensajeadmin.Text=nombre;
        }
    }
}
