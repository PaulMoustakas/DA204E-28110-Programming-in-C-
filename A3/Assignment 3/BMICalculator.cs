using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{


    class BMICalculator
    {
        private string name = "";
        private double height = 0;
        private double weight = 0;
        private UnitType unit;

        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
                this.name = name;
            this.name = "No name";
        }

        public string GetName() { return name; }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }

        public double CalculateBMI()
        {
            if (unit == UnitType.Imperial)
            {
                return (weight * 703) / (height * height);
            }
            else
                return weight / (height * height); 
        }


       public string BMIWeightCategory ()
        {
            double bmi = CalculateBMI();
            string stringout = string.Empty;
            if (bmi > 40)
                stringout = "Overweight (Obesity class III)";
            else if (bmi < 40 && bmi > 30)
                stringout = "Might still be overweight, but better than Obesity level III";
            else stringout = "Good BMI"; 
            return stringout; 
        }

       



        public UnitType getUnit()
        {
            return unit;
        }

        internal void SetUnit(UnitType type)
        {
            this.unit = type;
        }
    }
}



