using System;
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

namespace TestWPF
{
    /// <summary>
    /// Interaction logic for ContactDetailWindow.xaml
    /// </summary>
    public partial class ContactDetailWindow : Window
    {
        public enum Mode {Read, Add, Edit};
        private Mode _mode;
        
        public ContactDetailWindow()
        {
            InitializeComponent();
        }

        public ContactDetailWindow(Mode mode, Contact c)
        {
            InitializeComponent();
            this._mode = mode;
            this.lastNameTextBox.Text = "" + (int)mode;
            if (mode == Mode.Add)
            {
                this.Title = "Add Contact";
            }
            else if (mode == Mode.Edit)
            {
                this.Title = "Edit Contact";
            }

            TextBox[] tbs = { this.firstNameTextBox, this.lastNameTextBox, this.phoneTextBox, this.addressTextBox, this.cityTextBox, this.stateTextBox, this.zipTextBox };
            foreach (var tb in tbs)
            {
                // manipulation only if not read mode
                tb.IsEnabled = !(this._mode == Mode.Read);
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
