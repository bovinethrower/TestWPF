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
        private Contact _contact, _dummy;
        
        public ContactDetailWindow()
        {
            InitializeComponent();
            this._mode = Mode.Add;
            this._contact = new Contact();
        }

        public ContactDetailWindow(Mode m, Contact c)
        {
            InitializeComponent();
            this._mode = m;
            this._contact = c;
            this._dummy = c.Clone();
            this.DataContext = this._dummy;

            if (m == Mode.Add)
            {
                this.Title = "Add Contact";
            }
            else if (m == Mode.Edit)
            {
                this.Title = "Edit Contact";
            }

            TextBox[] tbs = { this.firstNameTextBox, this.lastNameTextBox, this.phoneTextBox, this.addressTextBox, this.cityTextBox, this.stateTextBox, this.zipTextBox };
            foreach (var tb in tbs)
            {
                // enabled only if not read mode
                tb.IsEnabled = !(m == Mode.Read);
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            // don't copy changes
            this.Close();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            // copy changes
            this._contact.FirstName = this._dummy.FirstName;
            this._contact.LastName = this._dummy.LastName;
            this._contact.Phone = this._dummy.Phone;
            this._contact.Address = this._dummy.Address;
            this._contact.City = this._dummy.City;
            this._contact.State = this._dummy.State;
            this._contact.Zip = this._dummy.Zip;
            this.Close();
        }
    }
}
