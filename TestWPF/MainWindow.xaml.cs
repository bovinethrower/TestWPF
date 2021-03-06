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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace TestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Contact> contacts;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Contact[] test = { new Contact("a", "b"), new Contact("c", "d") };
            // create contacts item
            contacts = new ObservableCollection<Contact>(test);
            // tell the DataGrid to load items from the contacts
            contactDataGrid.ItemsSource = contacts;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            contacts.Add(new Contact());
            ContactDetailWindow add = new ContactDetailWindow(ContactDetailWindow.Mode.Add, contacts[contacts.Count - 1]);
            add.Show();
            // show "please select a contact"
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if(contactDataGrid.SelectedValue != null)
            {
                ContactDetailWindow edit = new ContactDetailWindow(ContactDetailWindow.Mode.Edit, contactDataGrid.SelectedValue as Contact);
                edit.Show();
            }
            // show "please select a contact"
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (contactDataGrid.SelectedValue != null)
            {
                contacts.Remove(contactDataGrid.SelectedValue as Contact);
            }
            // show "please select a contact"
        }

        
    }
}
