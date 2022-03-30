﻿using System.Windows.Controls;

namespace Ona_Pix.Pages
{
    public partial class BehaviorPage : UserControl
    {
        public BehaviorPage()
        {
            InitializeComponent();
        }

        //Toggle点击事件
        internal void DisableExceptionToggle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //禁用报错
            if (DisableExceptionToggle.IS_TOGGLED)
                Properties.Settings.Default.IsExceptionDisabled = true;
            else
                Properties.Settings.Default.IsExceptionDisabled = false;

            Properties.Settings.Default.Save();
        }
        internal void DisableTipsToggle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //禁用一言
            if (DisableTipsToggle.IS_TOGGLED)
                Properties.Settings.Default.IsTipsDisabled = true;
            else
                Properties.Settings.Default.IsTipsDisabled = false;

            Properties.Settings.Default.Save();
        }
    }
}