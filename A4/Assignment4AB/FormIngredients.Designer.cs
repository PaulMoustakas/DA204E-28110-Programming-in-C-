namespace Assignment4AB
{
    partial class FormIngredient
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
            this.GBIngredients = new System.Windows.Forms.GroupBox();
            this.btnIngEdit = new System.Windows.Forms.Button();
            this.btnIngDelete = new System.Windows.Forms.Button();
            this.btnIngAdd = new System.Windows.Forms.Button();
            this.LBIngredients = new System.Windows.Forms.ListBox();
            this.TBNameOfIngredient = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.GBIngredients.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBIngredients
            // 
            this.GBIngredients.Controls.Add(this.btnIngEdit);
            this.GBIngredients.Controls.Add(this.btnIngDelete);
            this.GBIngredients.Controls.Add(this.btnIngAdd);
            this.GBIngredients.Controls.Add(this.LBIngredients);
            this.GBIngredients.Controls.Add(this.TBNameOfIngredient);
            this.GBIngredients.Location = new System.Drawing.Point(9, 9);
            this.GBIngredients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBIngredients.Name = "GBIngredients";
            this.GBIngredients.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBIngredients.Size = new System.Drawing.Size(505, 423);
            this.GBIngredients.TabIndex = 0;
            this.GBIngredients.TabStop = false;
            this.GBIngredients.Text = "Ingredient";
            
            // 
            // btnIngEdit
            // 
            this.btnIngEdit.Location = new System.Drawing.Point(379, 117);
            this.btnIngEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngEdit.Name = "btnIngEdit";
            this.btnIngEdit.Size = new System.Drawing.Size(115, 36);
            this.btnIngEdit.TabIndex = 11;
            this.btnIngEdit.Text = "Edit";
            this.btnIngEdit.UseVisualStyleBackColor = true;
            this.btnIngEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnIngDelete
            // 
            this.btnIngDelete.Location = new System.Drawing.Point(379, 158);
            this.btnIngDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngDelete.Name = "btnIngDelete";
            this.btnIngDelete.Size = new System.Drawing.Size(115, 36);
            this.btnIngDelete.TabIndex = 10;
            this.btnIngDelete.Text = "Delete";
            this.btnIngDelete.UseVisualStyleBackColor = true;
            this.btnIngDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnIngAdd
            // 
            this.btnIngAdd.Location = new System.Drawing.Point(379, 77);
            this.btnIngAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngAdd.Name = "btnIngAdd";
            this.btnIngAdd.Size = new System.Drawing.Size(115, 36);
            this.btnIngAdd.TabIndex = 9;
            this.btnIngAdd.Text = "Add";
            this.btnIngAdd.UseVisualStyleBackColor = true;
            this.btnIngAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LBIngredients
            // 
            this.LBIngredients.FormattingEnabled = true;
            this.LBIngredients.ItemHeight = 25;
            this.LBIngredients.Location = new System.Drawing.Point(13, 77);
            this.LBIngredients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LBIngredients.Name = "LBIngredients";
            this.LBIngredients.Size = new System.Drawing.Size(362, 329);
            this.LBIngredients.TabIndex = 8;
            // 
            // TBNameOfIngredient
            // 
            this.TBNameOfIngredient.Location = new System.Drawing.Point(13, 34);
            this.TBNameOfIngredient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBNameOfIngredient.Name = "TBNameOfIngredient";
            this.TBNameOfIngredient.Size = new System.Drawing.Size(362, 31);
            this.TBNameOfIngredient.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(82, 437);
            this.OK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(115, 36);
            this.OK.TabIndex = 6;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(202, 437);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 514);
            this.Controls.Add(this.GBIngredients);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.OK);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormIngredient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add ingredients";
            this.GBIngredients.ResumeLayout(false);
            this.GBIngredients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GBIngredients;
        private TextBox TBNameOfIngredient;
        private Button OK;
        private Button btnCancel;
        private ListBox LBIngredients;
        private Button btnIngAdd;
        private Button btnIngDelete;
        private Button btnIngEdit;
    }
}