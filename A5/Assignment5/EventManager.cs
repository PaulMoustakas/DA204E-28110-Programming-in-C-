using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class EventManager
    {
        private string title;
        private double eventEstimation; 
        private ParticipantManager participantManager;


        public double EventEstimate { get => - CalcTotalCost() - CalcTotalFees(); }
        public double CostPerPerson { get; set; }
        public double FeePerPerson { get; set; }
        public string Title { get { return title; } set { title = value; } }
        public ParticipantManager ParticipantManager  { get => this.participantManager; }


        public EventManager () 
        {
            this.participantManager = new ParticipantManager ();
        }



        /// <summary>
        /// Calculates the total cost 
        /// for the event based on cost and amount of participants
        /// </summary>
        /// <returns></returns>
        public double CalcTotalCost() 
        {
            double totalCost = this.participantManager.Count * CostPerPerson; 
            return totalCost; 
        }

        /// <summary>
        /// Calculates the total fees
        /// </summary>
        /// <returns></returns>
        public double CalcTotalFees() 
        {
            double totalFees = this.participantManager.Count * FeePerPerson;
            return totalFees;
        }
    }
}

