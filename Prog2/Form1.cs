//Todd Lasley
//CIS 200-10
//Program 2
//6/11/15
//Describes necessary requirements for building a Form which
//is the main form and is the start for the program.
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
    public partial class Form1 : Form
    {

        List<Address> addresses = new List<Address>();      // List of test addresses

        List<string> states = new List<string>(); //declare a list for states used in address

        //create list of parcels for the letters
        List<Parcel> parcels = new List<Parcel>();

        //constructor for main form Form1
        //adds test data to lists that are declared above
        public Form1()
        {
            InitializeComponent();

            //creating addresses for testing
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
                "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            //extra Address objects added
            Address a5 = new Address("Todd Lasley", "550 Ruggles Place", "Apt. 6",
                "Louisville", "KY", 40208); // Test Address 5
            Address a6 = new Address("Michael Myers", "42 Elm Ave.", "",
                "San Francisco", "CA", 85742); // Test Address 6
            Address a7 = new Address("Jared Taylor", "127 St. Route 271", "",
                "Hawesville", "KY", 42348); // Test Address 7
            Address a8 = new Address("Smitty Werbenjagermanjensen", "401 That St.", "Apt. 5",
                "Cincinatti", "OH", 12354); // Test Address 8

            //creating letters for testing
            // Letter test objects
            Letter letter1 = new Letter(a1, a2, 3.95M); //letter1
            Letter letter2 = new Letter(a3, a6, 4.58M); //letter2
            Letter letter3 = new Letter(a4, a5, 7.5M); //letter3
            Letter letter4 = new Letter(a5, a2, 5.8M); //letter4

            //add the addresses to the list on form load
            addresses.Add(a1);
            addresses.Add(a2);
            addresses.Add(a3);
            addresses.Add(a4);
            addresses.Add(a5);
            addresses.Add(a6);
            addresses.Add(a7);
            addresses.Add(a8);

            //add states to the list
            states.Add("KY");
            states.Add("IN");
            states.Add("OH");
            states.Add("TX");

            //add the items to the list
            parcels.Add(letter1);
            parcels.Add(letter2);
            parcels.Add(letter3);
            parcels.Add(letter4);
        }

        //event handler for About under File
        //displays personal/assignment info to a label via load event
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutBox = new About(); //creating dialog box object

            aboutBox.ShowDialog(); //open the new About box
        }

        //event handler for Exit under File
        //closes the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //ask Dr. Wright what he prefers???
        }

        //event handler opening a new AddressForm
        private void mainMenuStrip_Click(object sender, EventArgs e)
        {
            
            AddressForm addressForm = new AddressForm(states); //create new object of AddressForm
            DialogResult result; //used to store what is happened to the form
            

            result = addressForm.ShowDialog(); // form will be opened and will be modal

            //checking to see if anything was stored
            if(result == DialogResult.OK)
            {
                string name = addressForm.NameValue; //get the name from the AddressForm
                string address1 = addressForm.Addr1Value; //get the address line 1 from the AddressForm
                string address2 = addressForm.Addr2Value; //get the address line 2 from the AddressForm
                string city = addressForm.CityValue; //get the city from the AddressForm
                string state = states[addressForm.StateValue]; //get the state from the AddressForm
                int zipCode = int.Parse(addressForm.ZipCodeValue); //get the zip code from the AddressForm

                //create address with new data
                Address newAddress = new Address(name, address1, address2, city, state, zipCode);
                
                //add the new address to the list
                addresses.Add(newAddress);
            }

        }

        //event handler for Reporting Addresses
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            output.Clear();//clear whatever was in the output text box

            //foreach will concatenate the strings
            foreach (var a in addresses)
            {
                output.Text += a.ToString() + System.Environment.NewLine + System.Environment.NewLine;
            }
        }

        //event handler for listing parcels (letters in this case)
        private void listLettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            output.Clear();//clear whatever was in the output text box

            //display the letters
            foreach (var p in parcels)
            {
                output.Text += p.ToString() + System.Environment.NewLine + System.Environment.NewLine;
            }
            //now we calculate the cost of shipping all of the letters
            decimal totalCost = 0; //temporary variable to hold the total

            //doing the calculation
            foreach (var p in parcels)
            {
                totalCost += p.CalcCost();
            }
            
            //print the total at the bottom
            output.Text += "Total Cost for all of the letters: " + totalCost.ToString("C");
        }

        //event handler for loading of Form1
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //event handler for Inserting a Letter
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm = new LetterForm(addresses);
            DialogResult result; //used to store what is happened to the form

            result = letterForm.ShowDialog(); // form will be opened and will be modal

            if (result == DialogResult.OK)
            {
                Address originAddress = addresses[letterForm.OriginAddress]; //get origin address from the Letterorm
                Address destinAddress = addresses[letterForm.DestAddress]; //get destination address from the LetterForm

                decimal cost = decimal.Parse(letterForm.Cost); //get the cost from the LetterForm

                //create letter with the data
                Letter newLetter = new Letter(originAddress, destinAddress, cost);

                //add the new address to the list
                parcels.Add(newLetter);
            }
            else
            {
                result = DialogResult.Cancel;
            }
        }
    }
}
