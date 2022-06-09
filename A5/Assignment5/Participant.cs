using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Participant
    {
        
        private string _name;
        private string _lastName;
        private Address address; 


       
        internal string Name { get => this._name; set => this._name = value; }
        internal string LastName { get => this._lastName; set => this._lastName = value; }
        string FullName { get  => Name + ", " + LastName;}
        public Address Address { get => this.address; set => this.address = value; }

        public Participant( )
        {
            address = new Address();
        }


        override
        public string ToString() 
        {
            string strOut = "";
            strOut += String.Format("{0,-25}", FullName);
            strOut += "\t";
            strOut += String.Format("{0,-26}", address.ToString());

            return strOut;
        }



        public bool Validate(Participant participant) 
        {
            
            bool ok = !string.IsNullOrEmpty(participant._name);
            if (ok) { ok = !string.IsNullOrEmpty(participant._lastName);
                if (ok) { ok = !string.IsNullOrEmpty(participant.address.City); }
                return ok;          
            }
            return false;
        }
    }

}
