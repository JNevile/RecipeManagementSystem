﻿namespace RecipeManagementSystem
{
    partial class RecipeDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeDetails));
            lblRecipeName = new Label();
            pbRecipe = new PictureBox();
            lblRecipeAuthor = new Label();
            label3 = new Label();
            lblCookingTime = new Label();
            label5 = new Label();
            lblPrepTime = new Label();
            label7 = new Label();
            lblDifficulty = new Label();
            label9 = new Label();
            lblCalories = new Label();
            lblIngredients = new Label();
            lblInstructions = new Label();
            label1 = new Label();
            txtIngredients = new RichTextBox();
            txtInstructions = new RichTextBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pbRecipe).BeginInit();
            SuspendLayout();
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecipeName.ForeColor = Color.SteelBlue;
            lblRecipeName.Location = new Point(477, 98);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(203, 37);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe name";
            // 
            // pbRecipe
            // 
            pbRecipe.Location = new Point(731, 258);
            pbRecipe.Name = "pbRecipe";
            pbRecipe.Size = new Size(344, 287);
            pbRecipe.TabIndex = 1;
            pbRecipe.TabStop = false;
            // 
            // lblRecipeAuthor
            // 
            lblRecipeAuthor.AutoSize = true;
            lblRecipeAuthor.Font = new Font("Microsoft Sans Serif", 9F);
            lblRecipeAuthor.ForeColor = Color.LightSlateGray;
            lblRecipeAuthor.Location = new Point(513, 157);
            lblRecipeAuthor.Name = "lblRecipeAuthor";
            lblRecipeAuthor.Size = new Size(122, 22);
            lblRecipeAuthor.TabIndex = 2;
            lblRecipeAuthor.Text = "Recipe author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(456, 292);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 3;
            label3.Text = "Time to cook:";
            // 
            // lblCookingTime
            // 
            lblCookingTime.AutoSize = true;
            lblCookingTime.Font = new Font("Microsoft Sans Serif", 10F);
            lblCookingTime.ForeColor = Color.LightSlateGray;
            lblCookingTime.Location = new Point(594, 292);
            lblCookingTime.Name = "lblCookingTime";
            lblCookingTime.Size = new Size(48, 25);
            lblCookingTime.TabIndex = 4;
            lblCookingTime.Text = "time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(456, 347);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 5;
            label5.Text = "Prep time: ";
            // 
            // lblPrepTime
            // 
            lblPrepTime.AutoSize = true;
            lblPrepTime.Font = new Font("Microsoft Sans Serif", 10F);
            lblPrepTime.ForeColor = Color.LightSlateGray;
            lblPrepTime.Location = new Point(561, 347);
            lblPrepTime.Name = "lblPrepTime";
            lblPrepTime.Size = new Size(48, 25);
            lblPrepTime.TabIndex = 6;
            lblPrepTime.Text = "time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(456, 407);
            label7.Name = "label7";
            label7.Size = new Size(135, 25);
            label7.TabIndex = 7;
            label7.Text = "Difficulty level:";
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Font = new Font("Microsoft Sans Serif", 10F);
            lblDifficulty.ForeColor = Color.LightSlateGray;
            lblDifficulty.Location = new Point(601, 407);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(81, 25);
            lblDifficulty.TabIndex = 8;
            lblDifficulty.Text = "difficulty";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(456, 468);
            label9.Name = "label9";
            label9.Size = new Size(90, 25);
            label9.TabIndex = 9;
            label9.Text = "Calories:";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Font = new Font("Microsoft Sans Serif", 10F);
            lblCalories.ForeColor = Color.LightSlateGray;
            lblCalories.Location = new Point(551, 468);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(79, 25);
            lblCalories.TabIndex = 10;
            lblCalories.Text = "calories";
            // 
            // lblIngredients
            // 
            lblIngredients.AutoSize = true;
            lblIngredients.Font = new Font("Microsoft Sans Serif", 10F);
            lblIngredients.ForeColor = Color.SteelBlue;
            lblIngredients.Location = new Point(109, 230);
            lblIngredients.Name = "lblIngredients";
            lblIngredients.Size = new Size(114, 25);
            lblIngredients.TabIndex = 11;
            lblIngredients.Text = "Ingredients:";
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Microsoft Sans Serif", 10F);
            lblInstructions.ForeColor = Color.SteelBlue;
            lblInstructions.Location = new Point(106, 543);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(117, 25);
            lblInstructions.TabIndex = 12;
            lblInstructions.Text = "Instructions:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(177, 64);
            label1.TabIndex = 13;
            label1.Text = "Mealz";
            // 
            // txtIngredients
            // 
            txtIngredients.BackColor = Color.AliceBlue;
            txtIngredients.Location = new Point(124, 258);
            txtIngredients.Name = "txtIngredients";
            txtIngredients.Size = new Size(307, 284);
            txtIngredients.TabIndex = 14;
            txtIngredients.Text = "";
            // 
            // txtInstructions
            // 
            txtInstructions.BackColor = Color.AliceBlue;
            txtInstructions.Location = new Point(121, 572);
            txtInstructions.Name = "txtInstructions";
            txtInstructions.Size = new Size(953, 284);
            txtInstructions.TabIndex = 15;
            txtInstructions.Text = "";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.AliceBlue;
            btnSave.Location = new Point(917, 183);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(159, 45);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save recipe";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // RecipeDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1270, 987);
            Controls.Add(btnSave);
            Controls.Add(txtInstructions);
            Controls.Add(txtIngredients);
            Controls.Add(label1);
            Controls.Add(lblInstructions);
            Controls.Add(lblIngredients);
            Controls.Add(lblCalories);
            Controls.Add(label9);
            Controls.Add(lblDifficulty);
            Controls.Add(label7);
            Controls.Add(lblPrepTime);
            Controls.Add(label5);
            Controls.Add(lblCookingTime);
            Controls.Add(label3);
            Controls.Add(lblRecipeAuthor);
            Controls.Add(pbRecipe);
            Controls.Add(lblRecipeName);
            Name = "RecipeDetails";
            Text = "Recipes";
            ((System.ComponentModel.ISupportInitialize)pbRecipe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //private Label lblRecipeName;
        //private PictureBox pbRecipe;
        //private Label lblRecipeAuthor;
        private Label label3;
        //private Label lblCookingTime;
        private Label label5;
        //private Label lblPrepTime;
        private Label label7;
        //private Label lblDifficulty;
        private Label label9;
        //private Label lblCalories;
        private Label lblIngredients;
        private Label lblInstructions;
        private Label label1;
        //private RichTextBox txtIngredients;
        //private RichTextBox txtInstructions;
        private Button btnSave;

        internal Label lblRecipeName;
        internal PictureBox pbRecipe;
        internal Label lblRecipeAuthor;
        internal Label lblCalories;
        internal Label lblCookingTime;
        internal Label lblPrepTime;
        internal Label lblDifficulty;
        internal RichTextBox txtIngredients;
        internal RichTextBox txtInstructions;

    }
}