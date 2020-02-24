﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoppinList
{
    /// <summary>
    /// Interaction logic for AddToShoppingList.xaml
    /// </summary>
    public partial class AddToShoppingList : UserControl
    {
        public AddToShoppingList()
        {
            InitializeComponent();
            AddButton.Click += OnAddButtonClicked;
        }
        public void OnAddButtonClicked(object sender, RoutedEventArgs e)
        {
            //var data = (ShoppingListData)DataContext;
            
            if (DataContext is ShoppingListData data)
            {
                data.Add(ItemToAdd.Text);
                ItemToAdd.Text = "";
            }
        }
    }
}
