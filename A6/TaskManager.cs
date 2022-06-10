using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    internal class TaskManager
    {
        private List<Task> taskList;
        private readonly FileManager fileManager;
        public FileManager FileManager { get => this.fileManager; }


        public TaskManager () 
        {
            fileManager = new FileManager ();
            taskList = new List<Task>();
        }


        /// <Add task to list>
        /// Adds the task to the tasklist
        /// </Add task to list>
        /// <param name="task"></param>
        public bool AddTask (Task task) 
        {
            if (task != null) { taskList.Add(task); return true; }
            else { return false;}
        }


        public string[] GetTaskInfo()
        {
           
            string[] info = new string[taskList.Count];

            for (int i = 0; i < taskList.Count; i++)
            {
                if (taskList[i] != null)
                    info[i] = taskList[i].ToString();
            }
            return info;
        }

        public bool SaveFile () 
        {

            fileManager.SaveFile(taskList);
            return true;
        
        }

        public void ClearList() { taskList.Clear(); }

        public bool LoadFile()
        {
           
            this.taskList = fileManager.LoadFile();
            return true;

        }

    }
}
