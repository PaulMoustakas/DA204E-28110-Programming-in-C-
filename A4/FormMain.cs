namespace Assignment4AB
{
    public partial class FormMain : Form
    {
        private static readonly int MAX_NUMBER_OF_INGREDIENTS = 50;
        private static int MAX_NUMBER_OF_RECIPES = 200;
        private RecipeManager _recipeManager; 
        private Recipe currentRecipe; 
        

        public FormMain()
        {
            _recipeManager = new RecipeManager(MAX_NUMBER_OF_RECIPES);
            currentRecipe = new Recipe(MAX_NUMBER_OF_INGREDIENTS);
            InitializeComponent();
            InitializeGUI();
        }


        // Sets the initial state of the GUI
        private void InitializeGUI ()
        {
            CBCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
            btnEditFinish.Enabled = false;  
        }



        //Opens ingredient Form to add ingredients
        private void BtnAddIngredient(object sender, EventArgs e)
        {
            FormIngredient FI = new FormIngredient(currentRecipe);
            DialogResult dlgResult = FI.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {  
                if(currentRecipe.GetCurrentAmountOfIngredients() <= 0)
                {
                    MessageBox.Show("No ingredients specified", "error");
                }
            }
        }



        // Handles all recipes (new, edit)
        private bool TheRecipeHandler ( )
        {
            bool OK = false;

            // Name check
            if (currentRecipe.SetNameRecipe(TBNameOfRecipe.Text))
            {   // Category check
                if (currentRecipe.SetCategory((FoodCategory)CBCategory.SelectedItem))
                {   // Description check
                    if (currentRecipe.AddDescription(RTDescription.Text))
                    {   // Ingredient check
                        if (currentRecipe.GetCurrentAmountOfIngredients() > 0)
                        {
                            OK = true;

                        }
                        else MessageBox.Show("No Ingredients was added, please add ingredients", "error");

                    }
                    else MessageBox.Show("No description was added, please fill out the description", "error");

                }
                else MessageBox.Show("No category was choosed, please choose recipe category", "error");

            }
            else MessageBox.Show("No recipe name was entered, please enter the name for the recipe", "error");

            return OK;
        }


        //Adds the recipe to recipe list
        private void BtnAddRecipie_Click(object sender, EventArgs e)
        {
            if (TheRecipeHandler())
            {
                _recipeManager.AddRecipeToList(currentRecipe);
                currentRecipe = new Recipe(MAX_NUMBER_OF_INGREDIENTS);
                UpdateGUI();
            }
        }


        // Updates and reset the GUI
        private void UpdateGUI ()
        {
            TBNameOfRecipe.Text = String.Empty; 
            CBCategory.Text = String.Empty;
            RTDescription.Text = String.Empty;
            btnEditFinish.Enabled = false;

            LBRecipies.Items.Clear();
            foreach (Recipe recipe in _recipeManager.GetRecepieList())
            {
                if (recipe != null)
                LBRecipies.Items.Add(recipe.ToString());
            }
        }


    
        //Clears the Highlighted (selected) recipe 
        private void BtnClear(object sender, EventArgs e)
        {
            LBRecipies.ClearSelected();
            UpdateGUI();
        }


        //The recipe input group
        private void GrpAddRecipe(object sender, EventArgs e)
        {
            
        }

        // Capture selected recipe from ListBox
        private void LBRecipies_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int index = LBRecipies.SelectedIndex;
            Recipe selected = _recipeManager.GetRecipe(index);
            if (selected != null)
                MessageBox.Show(selected.ToStringLong(), "Cooking Instructions");
        }

        // Delete selected Recipe 
        private void BtnDeleteRecipe_Click(object sender, EventArgs e)
        {
            int index = LBRecipies.SelectedIndex;
            if (_recipeManager.DeleteRecipe(index))
                UpdateGUI ();
            
            else MessageBox.Show("Could not remove the selected ingredient");

        }

        // Saves the edited recipe 
        private void BtnEditFinish_Click(object sender, EventArgs e)
        {
            int index = LBRecipies.SelectedIndex;
            TheRecipeHandler();
            if (_recipeManager.EditRecipeAtIndex(index, currentRecipe))
            {
                UpdateGUI();
                currentRecipe = new Recipe(MAX_NUMBER_OF_INGREDIENTS);
            }
                
            else MessageBox.Show("Could not remove the selected ingredient");
        }

        // Populates the GUI with info from selected Recipe 
        private void RePopulateGUI ()
        {
            TBNameOfRecipe.Text = currentRecipe.GetName();
            RTDescription.Text = currentRecipe.GetDescription();
        }

        // Initiate Recipe edit on selected Recipe and enables Edit Finish
        private void BtnEditBegin_Click(object sender, EventArgs e)
        {
            int index = LBRecipies.SelectedIndex;
            currentRecipe = _recipeManager.GetRecipe(index);
            btnEditFinish.Enabled = true;
            RePopulateGUI();
        }
    }
}
