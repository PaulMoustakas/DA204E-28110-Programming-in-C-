namespace Assignment4AB
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBRecipe = new System.Windows.Forms.GroupBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.RTDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddIngredients = new System.Windows.Forms.Button();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.TBNameOfRecipe = new System.Windows.Forms.TextBox();
            this.lblNameRecipe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditBegin = new System.Windows.Forms.Button();
            this.btnEditFinish = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.LBRecipies = new System.Windows.Forms.ListBox();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.GBRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBRecipe
            // 
            this.GBRecipe.Controls.Add(this.btnAddRecipe);
            this.GBRecipe.Controls.Add(this.RTDescription);
            this.GBRecipe.Controls.Add(this.btnAddIngredients);
            this.GBRecipe.Controls.Add(this.CBCategory);
            this.GBRecipe.Controls.Add(this.lblCategory);
            this.GBRecipe.Controls.Add(this.TBNameOfRecipe);
            this.GBRecipe.Controls.Add(this.lblNameRecipe);
            this.GBRecipe.Location = new System.Drawing.Point(55, 76);
            this.GBRecipe.Name = "GBRecipe";
            this.GBRecipe.Size = new System.Drawing.Size(667, 612);
            this.GBRecipe.TabIndex = 0;
            this.GBRecipe.TabStop = false;
            this.GBRecipe.Text = "Add new recipe";
            this.GBRecipe.Enter += new System.EventHandler(this.GrpAddRecipe);
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(17, 550);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(630, 46);
            this.btnAddRecipe.TabIndex = 5;
            this.btnAddRecipe.Text = "Add recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.BtnAddRecipie_Click);
            // 
            // RTDescription
            // 
            this.RTDescription.Location = new System.Drawing.Point(17, 211);
            this.RTDescription.Name = "RTDescription";
            this.RTDescription.Size = new System.Drawing.Size(631, 321);
            this.RTDescription.TabIndex = 1;
            this.RTDescription.Text = "";
            // 
            // btnAddIngredients
            // 
            this.btnAddIngredients.Location = new System.Drawing.Point(458, 136);
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.Size = new System.Drawing.Size(204, 42);
            this.btnAddIngredients.TabIndex = 4;
            this.btnAddIngredients.Text = "Add Ingredients";
            this.btnAddIngredients.UseVisualStyleBackColor = true;
            this.btnAddIngredients.Click += new System.EventHandler(this.BtnAddIngredient);
            // 
            // CBCategory
            // 
            this.CBCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(191, 136);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(261, 40);
            this.CBCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 143);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(110, 32);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TBNameOfRecipe
            // 
            this.TBNameOfRecipe.Location = new System.Drawing.Point(191, 65);
            this.TBNameOfRecipe.Name = "TBNameOfRecipe";
            this.TBNameOfRecipe.Size = new System.Drawing.Size(469, 39);
            this.TBNameOfRecipe.TabIndex = 1;
            // 
            // lblNameRecipe
            // 
            this.lblNameRecipe.AutoSize = true;
            this.lblNameRecipe.Location = new System.Drawing.Point(6, 65);
            this.lblNameRecipe.Name = "lblNameRecipe";
            this.lblNameRecipe.Size = new System.Drawing.Size(179, 32);
            this.lblNameRecipe.TabIndex = 0;
            this.lblNameRecipe.Text = "Name of recipe";
            this.lblNameRecipe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(789, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1065, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1308, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "No. of ingredients";
            // 
            // btnEditBegin
            // 
            this.btnEditBegin.Location = new System.Drawing.Point(789, 625);
            this.btnEditBegin.Name = "btnEditBegin";
            this.btnEditBegin.Size = new System.Drawing.Size(150, 46);
            this.btnEditBegin.TabIndex = 5;
            this.btnEditBegin.Text = "Edit-begin";
            this.btnEditBegin.UseVisualStyleBackColor = true;
            this.btnEditBegin.Click += new System.EventHandler(this.BtnEditBegin_Click);
            // 
            // btnEditFinish
            // 
            this.btnEditFinish.Location = new System.Drawing.Point(945, 625);
            this.btnEditFinish.Name = "btnEditFinish";
            this.btnEditFinish.Size = new System.Drawing.Size(150, 46);
            this.btnEditFinish.TabIndex = 6;
            this.btnEditFinish.Text = "Edit-Finish";
            this.btnEditFinish.UseVisualStyleBackColor = true;
            this.btnEditFinish.Click += new System.EventHandler(this.BtnEditFinish_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1101, 625);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 46);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDeleteRecipe_Click);
            // 
            // LBRecipies
            // 
            this.LBRecipies.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBRecipies.FormattingEnabled = true;
            this.LBRecipies.ItemHeight = 27;
            this.LBRecipies.Location = new System.Drawing.Point(789, 124);
            this.LBRecipies.Name = "LBRecipies";
            this.LBRecipies.Size = new System.Drawing.Size(726, 463);
            this.LBRecipies.TabIndex = 9;
            this.LBRecipies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LBRecipies_MouseDoubleClick);
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Location = new System.Drawing.Point(1329, 625);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(186, 46);
            this.btnClearSelection.TabIndex = 10;
            this.btnClearSelection.Text = "btnClear-Selection";
            this.btnClearSelection.UseVisualStyleBackColor = true;
            this.btnClearSelection.Click += new System.EventHandler(this.BtnClear);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 726);
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.LBRecipies);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditFinish);
            this.Controls.Add(this.btnEditBegin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GBRecipe);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apu Recipe Book By Paul Moustakas";
            this.GBRecipe.ResumeLayout(false);
            this.GBRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox GBRecipe;
        private Button btnAddIngredients;
        private ComboBox CBCategory;
        private Label lblCategory;
        private TextBox TBNameOfRecipe;
        private Label lblNameRecipe;
        private Button btnAddRecipe;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnEditBegin;
        private Button btnEditFinish;
        private Button btnDelete;
        private ListBox LBRecipies;
        private Button btnClearSelection;
        private RichTextBox RTDescription;
    }
}