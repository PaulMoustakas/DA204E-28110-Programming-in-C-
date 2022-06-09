namespace Assignment4AB
{
    public partial class FormIngredient : Form
    {

        private Recipe recipe;


        public FormIngredient(Recipe recipe)
        {
            InitializeComponent();
            this.recipe = recipe;
            UpdateGUI();    
        }


        // Add ingredient
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (recipe.AddIngedient(TBNameOfIngredient.Text)) { UpdateGUI(); }
            else MessageBox.Show("Could not add more ingredients");
        }


        // Update GUI based on the ingredient array
        private void UpdateGUI ()
        {
            TBNameOfIngredient.Text = String.Empty;
            LBIngredients.Items.Clear();
            string[] arr = recipe.GetIngredients(); 
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != null)
                LBIngredients.Items.Add(arr[i]);
        }
      
        // Delete Ingredient
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = LBIngredients.SelectedIndex;
            if (recipe.DeleteIngedient(index))
                UpdateGUI();  
            else MessageBox.Show("Could not remove the selected ingredient"); 
        }

        // Edit ingredient
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int index = LBIngredients.SelectedIndex;

            if (TBNameOfIngredient.Text != String.Empty && index != -1)
            {
                if (recipe.EditIngredientAtIndex(index, TBNameOfIngredient.Text)) { UpdateGUI(); }
                else MessageBox.Show("Could not edit the ingredient");
            }
            else MessageBox.Show("Enter ingredient name or select an ingredient to edit"); 
        }


        // Submitt the ingredients 
        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}