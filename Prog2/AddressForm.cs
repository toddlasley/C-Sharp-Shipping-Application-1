//Todd Lasley
//CIS 200-10
//Program 2
//6/11/15
//Describes necessary requirements for building an AddressForm which
//allows the user to input information needed for adding an Address.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class AddressForm : Form
    {
        List<string> _states; //backing field for list of states
        
        //constructor for address form, accepts parameter of the list of states
        public AddressForm(List<string> states)
        {
            InitializeComponent();
            States = states;
        }
        
        //property for states
        public List<string> States
        {
            get
            {
                return _states;
            }

            set
            {
                _states = value;
            }
        }

        //property for the name
        public string NameValue
        {
            //gets string from nameInput
            get { return nameInput.Text; }

            //sets the value for nameInput
            set { nameInput.Text = value; }
        }

        //property for the Address 1
        public string Addr1Value
        {
            //gets string from address1Input
            get { return address1Input.Text; }

            //sets the value for address1Input
            set { address1Input.Text = value; }
        }

        //property for the address2Input
        public string Addr2Value
        {
            //gets string from address2Input
            get { return address2Input.Text; }

            //sets the value for address2Input
            set { address2Input.Text = value; }
        }

        //property for the cityInput
        public string CityValue
        {
            //gets string from cityInput
            get { return cityInput.Text; }

            //sets the value for nameInput
            set { cityInput.Text = value; }
        }

        //property for the stateComboBox
        public int StateValue
        {
            //gets string from stateComboBox
            get { return stateComboBox.SelectedIndex; }

            //sets the value for stateComboBox
            set { stateComboBox.SelectedIndex = value; }
        }

        //property for the zipCodeInput
        public string ZipCodeValue
        {
            //gets string from zipCodeInput
            get { return zipCodeInput.Text; }

            //sets the value for zipCodeInput
            set { zipCodeInput.Text = value; }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        //load event for AddressForm
        //sets all of the options of the comboboxes
        private void AddressForm_Load(object sender, EventArgs e)
        {
            foreach (var s in States)
            {
                stateComboBox.Items.Add(s);
            }
        }

        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }

        //validating event done for multiple text boxes
        private void textbox_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = (TextBox)sender;    //creating Textbox variable that will refer to current textbox
                                            //via object sender

            //is the textbox empty?
            if (t.Text == "")
            {
                e.Cancel = true;

                errorProvider1.SetError(t, "You must enter something!");
            }
        }

        //validated event done for multiple text boxes
        private void textbox_Validated(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;    //creating Textbox variable that will refer to current textbox
                                            //via object sender

            errorProvider1.SetError(t, "");
        }

        private void zipCode_Validating(object sender, CancelEventArgs e)
        {
            int minZip = 10000; //minimum that a zip can be
            int maxZip = 99999; //maximum that a zip can be

            int zip; //used to test the zip

            //is the textbox empty?
            if (!int.TryParse(zipCodeInput.Text, out zip))
            {
                e.Cancel = true;

                errorProvider1.SetError(zipCodeInput, "You must enter something!");
            }
            else if (zip < minZip || zip > maxZip) //does it fall within the necessary range for a zip code?
            {
                e.Cancel = true;

                errorProvider1.SetError(zipCodeInput, "You must enter a five digit integer!");
            }
        }

        //validating event for stateComboBox
        private void stateComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (stateComboBox.SelectedIndex == -1)
            {
                e.Cancel = true;

                errorProvider1.SetError(stateComboBox, "You must select a state!");
            }
        }
        //validated event for stateComboBox
        private void stateComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(stateComboBox, ""); //clears out the error
        }
        
    }
}
