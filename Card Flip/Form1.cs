//Sabrina Turney
//COP 2360
//Tutorial 2-5: Creating the Card Flip Application
//Last edited: August 25, 2019
//The purpose of this program is to follow along with an in-book tutorial to create an application that
//appears to "flip" a card using properties like visibility, demonstrating how events are handled in order.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//The actual Card Flip Project begins here - In VS, these classes have been created automatically for us
//We simply add the events that take place in our program by interacting with the window "design".
namespace Card_Flip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowBackButton_Click(object sender, EventArgs e)
            //Here, we have an event created when we clicked on the button "Show the Card Back" button in the designer.
            //We see in order that the back of the card is visible, and then the face is hidden, giving the impression that
            //our card has "flipped".
        {
            cardBackPictureBox.Visible = true;
            cardFacePictureBox.Visible = false;

        }

        private void ShowFaceButton_Click(object sender, EventArgs e)
            //Here, the opposite occurs. We clicked on the button "Show the Card Face" button in the designer.
            //The order here in exactly the same, with the back picture box now becoming invisible.
        {
            cardBackPictureBox.Visible = false;
            cardFacePictureBox.Visible = true;

        }
    }
}
