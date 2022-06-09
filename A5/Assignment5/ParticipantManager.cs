using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class ParticipantManager
    {
        private List<Participant> participantList;
        public int Count { get => participantList.Count; }


        /// <summary>
        /// Constructor to initialize vars and objects. 
        /// </summary>
        public ParticipantManager()
        {
            participantList = new List<Participant>(); 
        }

        /// <summary>
        /// Function to add participant to the list
        /// Returns true if successfull otherwise false
        /// </summary>
        public bool AddParticipant (Participant participant)
        {
            if (participant != null) 
            {
                participantList.Add(participant);
                return true;
            }
            return false;
        }

        /// <summary>
        /// 1. Creates a new participant object
        /// 2. checks the inputs for null values and empty strings. 
        /// -- If above - sets the inputs 
        /// 4. Adds the participant object to list
        /// -- Else false
        /// </summary>     
     

        public bool AddNewParticipant(Participant participant) 
        {
            if (participant.Validate(participant)) 
            {
                participantList.Add(participant);
                return true;
            }
            return false;
        }

        public bool ChangeParticipantAtIndex (int index, Participant participant)
        {
            if (CheckIndex(index) && participant.Validate(participant))
            {
                participantList[index] = participant;   
                return true;
            }
            return false; 
        }


        public bool DeleteParticipantAtIndex (int index) 
        {
            if (CheckIndex(index))
            {
                participantList.RemoveAt(index);
                return true;
            }
            return false; 
        }

        private bool CheckIndex (int index)
        {
            if (index > -1 && index < participantList.Count) { return true; }
            return false; 
        } 


        public Participant GetParticipantAtIndex (int index)
        {
            if (CheckIndex(index))
                return participantList[index];
            return null;
        }

        public string[] GetParticipantInfo () 
        {
            string [] info = new string[participantList.Count];
            
            for (int i = 0; i < participantList.Count; i++)
            {
                if(participantList[i] != null) 
                info[i] = participantList[i].ToString();
            }
            return info;
        }
    }
}
