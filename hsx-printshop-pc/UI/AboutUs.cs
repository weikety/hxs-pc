﻿using System;
using System.Windows.Forms;

namespace MaSoft.UI
{
    public partial class AboutUs : Form
    {

        #region 初始化

        public AboutUs()
        {
            InitializeComponent();
        }

        #endregion

        #region 方法

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region 关闭效果

        private void pictureBox_close_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_close.Image = Properties.Resources.MessageBox_close;
        }

        private void pictureBox_close_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_close.Image = Properties.Resources.MessageBox_close_hover;
        }

        #endregion
    }
}
