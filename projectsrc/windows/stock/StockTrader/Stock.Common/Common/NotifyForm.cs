﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stock.Common
{
    public partial class NotifyForm : Form
    {
        public NotifyForm()
        {
            InitializeComponent();
        }

        internal void InvokeShow(String s)
        {
                //this.Invoke(new MethodInvoker(() =>
                //{
                    this.textBox1.AppendText(s + "\r\n");
            //}));
        }
    }
}
