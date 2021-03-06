﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SixFabWpf
{
    /// <summary>
    /// Interaction logic for Products.xaml
    /// </summary>
    public partial class Products : Window
    {
        string portname;

        public Products(string portname)
        {
            InitializeComponent();
            this.portname = portname;
        }

        private void GPS_Click(object sender, MouseButtonEventArgs e)
        {
            Gps gps = new Gps(portname);
            gps.ShowDialog();
        }

        private void M66_Click(object sender, MouseButtonEventArgs e)
        {
            MainWindow m66 = new MainWindow(portname);
            m66.ShowDialog();
        }

        private void XBEE_Click(object sender, MouseButtonEventArgs e)
        {
            Xbee xbee = new Xbee(portname);
            xbee.ShowDialog();
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Label)sender).Cursor = Cursors.Hand;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.ChangedButton == MouseButton.Left)
                    DragMove();
            }
            catch (Exception ex)
            {
            }
        }

        private void FormClose_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void FormMinimize_Click(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
