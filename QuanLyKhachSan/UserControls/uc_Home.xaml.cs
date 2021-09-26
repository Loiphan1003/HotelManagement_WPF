﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI.UserControls
{
    /// <summary>
    /// Interaction logic for uc_Home.xaml
    /// </summary>
    public partial class uc_Home : UserControl
    {

        private string baseDir;
        private int index = 0;

        public uc_Home()
        {
            InitializeComponent();
            //lấy ra đường dẫn tương đối
            baseDir = Environment.CurrentDirectory;

            ImageBrush ENABLED_BACKGROUND = new ImageBrush(new BitmapImage(new Uri(baseDir + "\\Res\\Home0.png")));
            this.Background = ENABLED_BACKGROUND;

            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 10);
            dispatcherTimer.Start();

        }
        #region method
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            index++;
            if (index > 3)
                index = 0;
            ImageBrush ENABLED_BACKGROUND = new ImageBrush(new BitmapImage(new Uri(baseDir + "\\Res\\Home" + index.ToString() + ".png")));
            this.Background = ENABLED_BACKGROUND;
        }
        #endregion

        #region event
        private void right_Click(object sender, RoutedEventArgs e)
        {
            index++;
            if (index > 3)
                index = 0;
            ImageBrush ENABLED_BACKGROUND = new ImageBrush(new BitmapImage(new Uri(baseDir + "\\Res\\Home" + index.ToString() + ".png")));
            this.Background = ENABLED_BACKGROUND;
        }


        private void left_Click(object sender, RoutedEventArgs e)
        {
            index--;
            if (index < 0)
                index = 3;
            ImageBrush ENABLED_BACKGROUND = new ImageBrush(new BitmapImage(new Uri(baseDir + "\\Res\\Home" + index.ToString() + ".png")));
            this.Background = ENABLED_BACKGROUND;
        }
        #endregion
    }
}
