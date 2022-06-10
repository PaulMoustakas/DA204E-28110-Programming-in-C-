using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class MainForm : Form
    {
        private readonly TaskManager taskManager;
        public MainForm()
        {
            taskManager = new TaskManager();
            InitializeComponent();
            InitializeGUI();
        }


        /// <Initialize GUI>
        /// Initializes all the components 
        /// and resets all the fields. 
        /// </Initialize GUI>
        private void InitializeGUI() 
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm";
            TBToDo.Text = String.Empty;
            CBPriority.DataSource = Enum.GetValues(typeof(Priorities));
            taskManager.ClearList();
            LBTasks.Items.Clear();
        }
        

        /// <Add task to list>
        /// Reads input and creates a new task object
        /// Adds to list if valid input
        /// </Add task to list>
        private void BtnAddTask_Click(object sender, System.EventArgs e)
        {
            if (TBToDo.Text != string.Empty)
            {
                Task theTask = new Task
                    (
                       dateTimePicker.Value,
                       (Priorities)CBPriority.SelectedItem,
                       TBToDo.Text
                    );
                taskManager.AddTask(theTask);
                UpdateGUI();
            }
            else MessageBox.Show("Please enter a 'To-Do' before adding.");   
        }
    

        /// <Menu File Event>
        /// This method is the DropDownItemClicked event handler.
        /// It passes the ClickedItem object to a utility method
        /// called UpdateStatus, which updates the text displayed
        /// in the StatusStrip control.
        /// </Menu File Event>
        private void MenuItemFile_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.UpdateStatus(e.ClickedItem);
        }


        /// <Utility method for menu File event>
        /// This utility method assigns the value of a ToolStripItem
        /// control's Text property to the associated method. 
        /// Methods, New, open, Save, SaveAs and Exit. 
        /// </Utility method for menu File event>
        private void UpdateStatus(ToolStripItem item)
        {
            if (item != null)
            {
                switch (item.Text)
                {
                    case "&Save":
                        taskManager.SaveFile();
                        break;
                    case "&Open":
                        taskManager.LoadFile();
                        UpdateGUI();
                        break;
                    case "&New":
                        InitializeGUI();
                        break;
                    case "E&xit":
                        Exit();
                        break; 
                }         
            }
        }


        /// <Exit prompt>
        /// Control the Exit button
        /// Prompt the user to confirm
        /// the Exit of the application.
        /// </Exit prompt>
        private void Exit () 
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit the program?", "Exit Program", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK) { Application.Exit(); }
            else return;
        }

        /// <Update GUI>
        /// Updates the GUI (Task list) based on the Task object from the list
        /// Resets the Todo Input.
        /// </Update GUI>
        private void UpdateGUI () {
        TBToDo.Text = string.Empty; 
        LBTasks.Items.Clear();
            if (taskManager.GetTaskInfo() != null) { 
            LBTasks.Items.AddRange(taskManager.GetTaskInfo()); }
            else LBTasks.Items.Clear();
        }

        private void ToolStripHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Apus To-do list, happy hacking!"); 
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
