using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        EventManager eventManager; 
        public Form1()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            GroupBoxParticipant.Enabled = false;
            CBCountry.DataSource = Enum.GetValues(typeof(Countries));
            // Economy     
            LBNumOfParticipant.Text = String.Empty;
            LBTotalCostE.Text = String.Empty;
            LBTotalFeesE.Text = String.Empty;
            LBSurplusDef.Text = String.Empty;
            LBParticipants.Items.Clear();
        }

      
        /// <summary>
        /// Creates a new Event
        /// and enables the participat options
        /// 
        /// 1. Check for the minimum input before creating a new object. 
        /// 2. Sets the titel of the new object 
        /// 3. Enables the participant features
        /// 4. Checks and fills the cost and fee values
        /// </summary>
        private void BtnCreateEvent_Click(object sender, EventArgs e)
        {
            if (TBEventTitle.Text != string.Empty)
            {
                InitializeGUI();
                eventManager = new EventManager { Title = TBEventTitle.Text };
                GroupBoxParticipant.Enabled = true;

                if (double.TryParse(TBCostPerP.Text, out double cost))
                    eventManager.CostPerPerson = cost;
                else eventManager.CostPerPerson = 0.0;

                if (double.TryParse(TBFeePerP.Text, out double fee))
                    eventManager.FeePerPerson = fee;
                else eventManager.FeePerPerson = 0.0;
            }
            else MessageBox.Show("You need to enter a title for the event");
        }


        /// <summary>
        /// 9.3 
        ///  Create a new Participant object.
        ///  Read and save input in the object, validate input
        ///  and store the object in the list of participants.
        ///  Call the Participants property provided in the eventManager object.
        /// </summary>
        private void BtnAddParticipant_Click(object sender, EventArgs e)
        {
            ///New Participant
            Participant theParticipant = new Participant();

            /// Read and fill participant details  
            theParticipant = ReadInputParticipant(theParticipant);
            
            if (eventManager.ParticipantManager.AddNewParticipant(theParticipant)) { UpdateGUI(); }
            else MessageBox.Show("You need to fill out the participant details");
        }


        /// <summary>
        /// Method to read the input
        /// Separated to be used from Add and Change  
        /// </summary>
        private Participant ReadInputParticipant (Participant theParticipant) 
        {
            /// Read the inputs
            theParticipant.Name = TBFirstName.Text;
            theParticipant.LastName = TBLastName.Text;

            theParticipant.Address.Street = TBStreet.Text;
            theParticipant.Address.City = TBCity.Text;
            theParticipant.Address.ZipCode = TBZipCode.Text;
            theParticipant.Address.Country = (Countries)CBCountry.SelectedItem;

            return theParticipant; 
        }


        /// <summary>
        /// Updates the GUI after events in the application.
        /// Resets the input fields and fills output labels and list items
        /// </summary>
        private void UpdateGUI()
        {
            // Event Group (Reset)
            TBFirstName.Text = String.Empty;
            TBLastName.Text = String.Empty;
            TBCostPerP.Text = String.Empty;
            TBFeePerP.Text = String.Empty;

            // Participant Group (Reset)
            TBStreet.Text = String.Empty;
            TBCity.Text = String.Empty;
            TBZipCode.Text = String.Empty;
            CBCountry.SelectedIndex = 0;

            // Event economy
            LBNumOfParticipant.Text = Convert.ToString(this.eventManager.ParticipantManager.Count);
            LBTotalCostE.Text = Convert.ToString(eventManager.CalcTotalCost());
            LBTotalFeesE.Text = Convert.ToString(eventManager.CalcTotalFees());
            LBSurplusDef.Text = Convert.ToString(eventManager.EventEstimate); 

         
            // Participant List 
            LBParticipants.Items.Clear();
            if (eventManager.ParticipantManager.GetParticipantInfo() != null) { 
            LBParticipants.Items.AddRange(eventManager.ParticipantManager.GetParticipantInfo()); }
            else LBParticipants.Items.Clear();
        }

        private void Btn_DeleteParticipant_Click(object sender, EventArgs e)
        {
            int index = LBParticipants.SelectedIndex;
            if (eventManager.ParticipantManager.DeleteParticipantAtIndex(index))
                UpdateGUI();

            else MessageBox.Show("Could not remove the selected participant");
        }

        /// <summary>
        /// 1. Get the selected participant Index
        /// 2. Get the participant from list
        /// 3. ReadInputParticipant - Read the inputfields 
        /// 4. Call the Change method chain in eventmanager (includes checks)
        /// </summary>   
        private void BtnChangeParticipant_Click(object sender, EventArgs e)
        {
           
            int index = LBParticipants.SelectedIndex;
            if (index > -1)
            {
                Participant theParticipant = eventManager.ParticipantManager.GetParticipantAtIndex(index);
                theParticipant = ReadInputParticipant(theParticipant);
                
                if (eventManager.ParticipantManager.ChangeParticipantAtIndex(index, theParticipant))
                    UpdateGUI();
            }
            else MessageBox.Show("Could not change the selected participant info");
        }

        private void RePopulate(Participant theParticipant)
        {
            TBFirstName.Text = theParticipant.Name;
            TBLastName.Text = theParticipant.LastName;
            TBStreet.Text = theParticipant.Address.Street;
            TBCity.Text = theParticipant.Address.City;
            TBZipCode.Text = theParticipant.Address.ZipCode;
            CBCountry.SelectedIndex = (int)theParticipant.Address.Country; 
        }


        /// <summary>
        /// Trigger RePopulate on fields for selected Participant 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LBParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBParticipants.SelectedIndex;
            if (index > -1)
                RePopulate(eventManager.ParticipantManager.GetParticipantAtIndex(index));
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void LBNumOfParticipant_Click(object sender, EventArgs e)
        {

        }
    }
}
