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

namespace VerticalPrototype1
{
    /// <summary>
    /// Interaction logic for SelectTable.xaml
    /// </summary>
    public partial class SelectTable : UserControl
    {
        public SelectTable()
        {
            InitializeComponent();
        }

        private void tableClick(object sender, RoutedEventArgs e)
        {
            Button b = e.Source as Button;
            MainWindow.tableNum = b.Content as String;
            MainWindow.switchToMenuCategoriesView();
        }
    }
}
