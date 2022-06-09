namespace Assignment4AB
{
    public class Recipe
    {
     
        private string name  = ""; 
        private string description = "";
        private string [] ingredients; 
        private FoodCategory category;
        private int amountOfIngredients = 0; 
        


        public Recipe(int MAX_NUMBER_OF_INGREDIENTS)
        {
            ingredients = new string[MAX_NUMBER_OF_INGREDIENTS]; 
        }

       
        public bool AddIngedient (string ingredient)
        {
           if (amountOfIngredients < ingredients.Length)
            {
                ingredients[amountOfIngredients] = ingredient;
                amountOfIngredients++;
                return true;
            }
            return false;
        }

        public bool EditIngredientAtIndex (int index, string value) 
        {
            ingredients[index] = value;
             return true;
        }

        public bool DeleteIngedient(int index)
        {
            if (index != -1 ) {
                ingredients[index] = string.Empty;
                amountOfIngredients--;
                ShiftElementLeft(index);
                return true;
            }
            else return false; 
        }

        private void ShiftElementLeft(int index)
        {
            for (int i = index+1; i < ingredients.Length; i++)
            {
                ingredients[i-1] = ingredients[i];
                ingredients[i] = string.Empty;
            }
        }

        public bool AddDescription(string description)
        {
            if (description != string.Empty)
            {
                this.description = description;
                return true;
            }
            return false; 
        }


        public bool SetCategory (FoodCategory foodCategory)
        {
            
            if (Enum.TryParse<FoodCategory>(foodCategory.ToString(), out foodCategory))
            {
                this.category = foodCategory;
                return true; 
            }
            return false; 
        }

        public FoodCategory GetFoodCategory ()
        {
            return this.category;
        }



        public string[] GetIngredients() { return ingredients; }

        public int GetCurrentAmountOfIngredients () {  return amountOfIngredients; }

        public bool SetNameRecipe(String name) 
        { 
            if (name != string.Empty)
            {
                this.name = name;
                return true;
            }
            return false;
        }

        public string GetName ()
        {
            return name;
        }

        public string GetDescription()
        {
            return description; 
        }

        override
        public string ToString()
        {
            string strOut = "";
            strOut += String.Format("{0,-20}", name);
            strOut += String.Format("{0,-26}", category);
            strOut += String.Format("{0,1}", amountOfIngredients);

            return strOut; 
        }


      public string ToStringLong()
        {
            string strOut = "";
            strOut += "INGREDIENTS \n";
            foreach (string ingredient in this.ingredients)
            {
                strOut += ingredient + " ";
            }
            strOut += "\n" + description;
   
            return strOut;
        }
    }
}