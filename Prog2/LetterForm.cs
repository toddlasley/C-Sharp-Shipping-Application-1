//Todd Lasley
//CIS 200-10
//Program 2
//6/11/15
//Describes necessary requirements for building a LetterForm which
//allows the user to add a letter with given addresses.

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
    public partial class LetterForm : Form
    {
        //backing field for...
        private List<Address> _address; //origin address

        public LetterForm(List<Address> addresses)
        {
            InitializeComponent();

            Addresses = addresses;

        }

        //property for Origin Address
        public List<Address> Addresses
        {
            //get accessor
            get
            {
                return _address;
            } //end get

            //set accessor
            set
            {
                _address = value;
            }//end set
        } //end property for origin address

        //property for the origAddrComboBox
        public int OriginAddress
        {
            //gets string from origAddrComboBox
            get { return origAddrComboBox.SelectedIndex; }

            //sets the value for origAddrComboBox
            set { origAddrComboBox.SelectedIndex = value; }
        }

        //property for the destAddrComboBox
        public int DestAddress
        {
            //gets string from destAddrComboBox
            get { return destAddrComboBox.SelectedIndex; }

            //sets the value for stateComboBox
            set { destAddrComboBox.SelectedIndex = value; }
        }

        //property for Cost
        public string Cost
        {
            //get accessor
            get
            {
                return costInput.Text;
            }
            //set accessor
            set
            {
                costInput.Text = value;
            }
        } //end property for Cost

        //load event for LetterForm
        private void LetterForm_Load(object sender, EventArgs e)
        {
            //adding the values to the comboboxes (Origin Address and Destination Address)
            foreach (var a in Addresses)
            {
                origAddrComboBox.Items.Add(a.Name);
                destAddrComboBox.Items.Add(a.Name);
            }
        }

        //event handler 
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //validating event for costInput textbox
        private void costInput_Validating(object sender, CancelEventArgs e)
        {
            decimal cost; //used to test the decimal value in CostInput

            if (!decimal.TryParse(costInput.Text, out cost)) //is it even a decimal?
            {
                e.Cancel = true; //stops focus changing

                errorProvider1.SetError(costInput, "Must be a decimal!"); //the error message

                costInput.SelectAll(); //makes it easier to change
            }
            else if (cost < 0) //so it's a decimal but is it positive?
            {
                errorProvider1.SetError(costInput, "The cost cannot be negative!"); //the error message

                costInput.SelectAll(); //makes it easier to change
            }
        }

        //Validated event for costInput textbox
        private void costInput_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(costInput, ""); // Clears error message
        }
        //validating event for Origin Address Combo Box
        private void origAddrComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (origAddrComboBox.SelectedIndex == -1) //is anything selected?
            {
                e.Cancel = true;

                errorProvider1.SetError(origAddrComboBox, "You must select an address!"); //error message
            }
            else if (origAddrComboBox.SelectedIndex == destAddrComboBox.SelectedIndex) //are origin and destination the same?
            {
                e.Cancel = true;

                errorProvider1.SetError(origAddrComboBox, "Your origin address and destination address are the same!");
            }
        }
        //validating event for destination address combobox
        private void destAddrComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (destAddrComboBox.SelectedIndex == -1) //is anything selected?
            {
                e.Cancel = true;

                errorProvider1.SetError(origAddrComboBox, "You must select an address!");
            }
            else if (origAddrComboBox.SelectedIndex == destAddrComboBox.SelectedIndex) //are origin and destination the same?
            {
                e.Cancel = true;

                errorProvider1.SetError(origAddrComboBox, "Your origin address and destination address are the same!");
            }
        }

        private void ComboBox_Validated(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;      //creating a variable that can use object sender to
                                                //determine which combobox is in focus
            errorProvider1.SetError(c, ""); //clear any error messageg
        }
    }
}
