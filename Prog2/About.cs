//Todd Lasley
//CIS 200-10
//Program 2
//6/11/15
//Describes necessary requirements for building a AboutForm which
//displays general information about the program.

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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            aboutLbl.Text = "Todd Lasley\nCIS 200-10\nProgram 2\n6/11/15\nProgram that shows how to utilize dialog boxes.";
        }
    }
}
