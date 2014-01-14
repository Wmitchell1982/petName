using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PetName
{
    
    /// William Mitchell
    /// POS/409
    /// 12/16/2013
    /// Dr Brad Purdy
    /// Application: Pet Name Generator
    /// This application will generate a random petname based on the type of pet the user choses
            public partial class nameEntryAndDisplay : Form
    {
        
        /// Initializes a new instance of the <see cref="nameEntryAndDisplay"/> class.
        public nameEntryAndDisplay()
        {
            InitializeComponent();
        }

        /// Handles the Click event of the btnExit control.
        /// calls the exit application method from the exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            exitApplication();
        }
      
        /// Exits the application.
        private void exitApplication()
        {
            Application.Exit();
        }

        /// Handles the Click event of the msitExit control.
        /// calls the exit application method from the exit menu item
        private void msitExit_Click(object sender, EventArgs e)
        {
            exitApplication();
        }

        /// Handles the Click event of the btnReset control.
        /// calls the reset form method from the reset button
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        /// Resets the form.
        private void resetForm()
        {
            this.lblPetName.Visible = false;
            this.lblPetName.Text = null;
            this.errInfo.Clear();
            this.cbPetType.SelectedIndex = -1;
        }

        /// Handles the Click event of the msitAbout control.
        /// shows the about message box
        private void msitAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pet Name Generator By William Mitchell 2013", "About", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        /// Handles the Click event of the btnPetName control.
        /// calls the generate name method
        private void btnPetName_Click(object sender, EventArgs e)
        {
            generateName();
        }

        /// Generates the name.
        private void generateName()
        {
            var petType = this.cbPetType.SelectedIndex;
            
            string[] catNames = { "Milo", "Tabby", "Snickers", "Kitty", "Bannana Bread", "Shasha", "Flower"}; //creates an array for possible cat names 
            string[] fishNames = { "Blubber", "Bubbles", "Goldy", "Dot", "Nemo", "Dory", "Sharkbait" }; //creates an array for possible fish names 
            string[] dogNames = { "Fido", "Rover", "Champ", "Rex", "Molly", "Max", "Ruby" }; //creates an array for possible dog names 
            string petNameSelected; //creates string variable for the pet name selected from random picking selected
            Random random = new Random(); //sets the random picker method to be used to generate a pet name

            if (petType == -1)
            {
                this.errInfo.SetError(this.cbPetType, "Please Select a Pet Type"); //creates an error event if no pet is chosen
            }
            else if (petType == 0) //if a dog is chosen this will occer
            {
                string petTypeString = cbPetType.SelectedItem.ToString(); //assigns value to pet type string
                petNameSelected = dogNames[random.Next(0,7)]; //randomly selects from the dog name array
                this.lblPetName.Text = "Your " + petTypeString + "'s name is " + petNameSelected; //updates the label for the pet name selected
                this.lblPetName.Visible = true; //shows the pet name label

            }
            else if (petType == 1) //if a cat is chosen this will occer
            {
                string petTypeString = cbPetType.SelectedItem.ToString(); //assigns value to pet type string
                petNameSelected = catNames[random.Next(0, 7)]; //randomly selects from the cat name array
                this.lblPetName.Text = "Your " + petTypeString + "'s name is " + petNameSelected; //updates the label for the pet name selected
                this.lblPetName.Visible = true; //shows the pet name label
            }
            else if (petType == 2)
            {
                string petTypeString = cbPetType.SelectedItem.ToString(); //assigns value to pet type string
                petNameSelected = fishNames[random.Next(0, 7)]; //randomly selects from the fish name array
                this.lblPetName.Text = "Your " + petTypeString + "'s name is " + petNameSelected; //updates the label for the pet name selected
                this.lblPetName.Visible = true; //shows the pet name label
            }
        }


        /// Handles the Load event of the nameEntryAndDisplay control.
        /// calls the tool tip creator method
        private void nameEntryAndDisplay_Load(object sender, EventArgs e)
        {
            toolTipCreator();
        }

        /// Tool tip creator.
        /// sets messages for the tool tips
        private void toolTipCreator()
        {
            this.ttInfo.SetToolTip(this.cbPetType, "Choose a pet type");
            this.ttInfo.SetToolTip(this.btnExit, "Exit Application");
            this.ttInfo.SetToolTip(this.btnPetName, "Generate a pet's name");
            this.ttInfo.SetToolTip(this.btnReset, "Reset the form");
        }
    
    }


}
