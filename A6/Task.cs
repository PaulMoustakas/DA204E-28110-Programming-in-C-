using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{

    internal class Task
    {
        private string toDo;
        private Priorities priorities;
        private DateTime dateTime; 
        public string ToDo { get => this.toDo; set => toDo = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public Priorities Priorities { get => this.priorities; set => priorities = value; }



        public Task(DateTime dateTime, Priorities priorities, string toDo)
        {
            this.toDo = toDo;
            this.priorities = priorities;
            this.dateTime = dateTime;
        }


        /// <ToString method>
        /// Overrides the tostring method
        /// Creates a new organized based on the object. 
        /// </ToString method>
        override
            public string ToString()
        {
            string strOut = "";
            strOut += String.Format("{0,-20}", dateTime.ToLongDateString());
            strOut += String.Format("{0,-8}", dateTime.ToShortTimeString());
            strOut += String.Format("{0,-10}", priorities);
            strOut += String.Format("{0,-20}", toDo);

            return strOut;
        }
    }
}
