﻿/*
 * This library is part of Stock Trader System
 *
 * Copyright (c) qiujoe (http://www.github.com/qiujoe)
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * Lesser General Public License for more details.
 *
 * For further information about StockTrader, please see the
 * project website: http://www.github.com/qiujoe/StockTrader
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stock.Trader.HuaTai
{
    public partial class FormInputValidateCode : Form
    {
        public FormInputValidateCode()
        {
            InitializeComponent();

            loadTraderInfo();
        }

        private void loadTraderInfo()
        {
            this.txtUsername.Text = Stock.Trader.Settings.Configure.GetStockTraderItem("Trade.Account");
            this.txtServicePwd.Text = Stock.Trader.Settings.Configure.GetStockTraderItem("Service.Password");
            this.txtTrdpwd.SetPswStr(Stock.Trader.Settings.Configure.GetStockTraderItem("Trade.Password"));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
