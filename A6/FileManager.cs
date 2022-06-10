using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    internal class FileManager
    {

        /// <Load Task list from file>
        /// Loades the task list from file.
        /// User has to choose file to load from. 
        /// Returns true if loaded, otherwise false
        /// </Load Task list from filee>
        public List<Task> LoadFile()
        {
            List<Task> taskList = new List<Task>();
            System.IO.Stream myStream;
            _ = new SaveFileDialog();

            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFile.OpenFile()) != null)
                {
                    try
                    {
                        StreamReader reader = new StreamReader(myStream);
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] parts = line.Split('\t');
                            Task theTask = new Task(
                                DateTime.Parse(parts[0].Trim()),
                                (Priorities)Enum.Parse(typeof(Priorities), parts[1]),
                                parts[2].Trim()
                                );
                            taskList.Add(theTask);
                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.ToString());}
                    finally { myStream.Close(); }
                }
            }
            return taskList;
        }


        /// <Save Task list to file>
        /// Saves the task list to file.
        /// User has to choose file on save. 
        /// Returns true if saved, otherwise false
        /// </Save Task list to file>
        public bool SaveFile(List<Task> taskList)
        {
            bool isSaved = false;
            System.IO.Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    try
                    {
                        StreamWriter writer = new StreamWriter(myStream);
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Task task = taskList[i];
                            writer.WriteLine("{0}\t{1}\t{2}", task.DateTime, task.Priorities, task.ToDo);     
                        }
                        writer.Flush();
                        isSaved = true;
                    } catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                    finally { myStream.Close(); }
                }
            }
            return isSaved;
        }
    }
}
