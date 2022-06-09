namespace Assignment4AB
{
    class RecipeManager
    {
        private Recipe[] recipeList; 
        private int amountOfRecipies = 0; 

        public RecipeManager (int MAX_NUMBER_OF_RECIPES)
        {
            recipeList = new Recipe[MAX_NUMBER_OF_RECIPES];
        }


        public bool AddRecipeToList (Recipe recipe)
        {
            if (amountOfRecipies < recipeList.Length)
            {
                recipeList[amountOfRecipies] = recipe;
                amountOfRecipies++;
                return true;
            }
            return false;
        }


        public bool DeleteRecipe(int index)
        {
            if (index != -1)
            {
                recipeList[index] = null; 
                amountOfRecipies--;
                ShiftElementLeft(index);
                return true;
            }
            return false;
        }

        private void ShiftElementLeft(int index)
        {
            for (int i = index + 1; i < recipeList.Length; i++)
            {
                recipeList[i - 1] = recipeList[i];
                recipeList[i] = null;
            }
        }

        public bool EditRecipeAtIndex(int index, Recipe editedRecipe)
        {
            recipeList[index] = editedRecipe;
            return true;
        }



        public Recipe[] GetRecepieList() { return recipeList; }


        public Recipe GetRecipe (int index) 
        { 
            if (index > -1)
                return recipeList[index];
            return null;
        }
    }
}