namespace Circustrein_Matthijs
{
	partial class CircusTrein
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
			this.btnAddRandomAnimals = new System.Windows.Forms.Button();
			this.btnDistribute = new System.Windows.Forms.Button();
			this.tboxWagons = new System.Windows.Forms.TextBox();
			this.tboxAnimals = new System.Windows.Forms.TextBox();
			this.lblAnimals = new System.Windows.Forms.Label();
			this.lblWagons = new System.Windows.Forms.Label();
			this.numUDAnimalCount = new System.Windows.Forms.NumericUpDown();
			this.lblAnimalAmount = new System.Windows.Forms.Label();
			this.btnSortAnimals = new System.Windows.Forms.Button();
			this.btnAddSelectedAnimals = new System.Windows.Forms.Button();
			this.cBCarnivore = new System.Windows.Forms.ComboBox();
			this.cBSize = new System.Windows.Forms.ComboBox();
			this.lblCarnivore = new System.Windows.Forms.Label();
			this.lblSize = new System.Windows.Forms.Label();
			this.btnAddRandomHerbivores = new System.Windows.Forms.Button();
			this.btnAddRandomCarnivores = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numUDAnimalCount)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddRandomAnimals
			// 
			this.btnAddRandomAnimals.Location = new System.Drawing.Point(12, 151);
			this.btnAddRandomAnimals.Name = "btnAddRandomAnimals";
			this.btnAddRandomAnimals.Size = new System.Drawing.Size(233, 36);
			this.btnAddRandomAnimals.TabIndex = 0;
			this.btnAddRandomAnimals.Text = "Add random animals";
			this.btnAddRandomAnimals.UseVisualStyleBackColor = true;
			this.btnAddRandomAnimals.Click += new System.EventHandler(this.AddAnimals_Click);
			// 
			// btnDistribute
			// 
			this.btnDistribute.Location = new System.Drawing.Point(12, 546);
			this.btnDistribute.Name = "btnDistribute";
			this.btnDistribute.Size = new System.Drawing.Size(233, 37);
			this.btnDistribute.TabIndex = 1;
			this.btnDistribute.Text = "Distribute over wagons";
			this.btnDistribute.UseVisualStyleBackColor = true;
			this.btnDistribute.Click += new System.EventHandler(this.Distribute_Animals_Click);
			// 
			// tboxWagons
			// 
			this.tboxWagons.Location = new System.Drawing.Point(556, 34);
			this.tboxWagons.Multiline = true;
			this.tboxWagons.Name = "tboxWagons";
			this.tboxWagons.Size = new System.Drawing.Size(299, 558);
			this.tboxWagons.TabIndex = 3;
			// 
			// tboxAnimals
			// 
			this.tboxAnimals.Location = new System.Drawing.Point(251, 34);
			this.tboxAnimals.Multiline = true;
			this.tboxAnimals.Name = "tboxAnimals";
			this.tboxAnimals.Size = new System.Drawing.Size(299, 558);
			this.tboxAnimals.TabIndex = 4;
			// 
			// lblAnimals
			// 
			this.lblAnimals.AutoSize = true;
			this.lblAnimals.Location = new System.Drawing.Point(248, 14);
			this.lblAnimals.Name = "lblAnimals";
			this.lblAnimals.Size = new System.Drawing.Size(57, 17);
			this.lblAnimals.TabIndex = 5;
			this.lblAnimals.Text = "Animals";
			// 
			// lblWagons
			// 
			this.lblWagons.AutoSize = true;
			this.lblWagons.Location = new System.Drawing.Point(553, 14);
			this.lblWagons.Name = "lblWagons";
			this.lblWagons.Size = new System.Drawing.Size(60, 17);
			this.lblWagons.TabIndex = 6;
			this.lblWagons.Text = "Wagons";
			// 
			// numUDAnimalCount
			// 
			this.numUDAnimalCount.Location = new System.Drawing.Point(12, 34);
			this.numUDAnimalCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numUDAnimalCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numUDAnimalCount.Name = "numUDAnimalCount";
			this.numUDAnimalCount.Size = new System.Drawing.Size(233, 22);
			this.numUDAnimalCount.TabIndex = 7;
			this.numUDAnimalCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lblAnimalAmount
			// 
			this.lblAnimalAmount.AutoSize = true;
			this.lblAnimalAmount.Location = new System.Drawing.Point(9, 14);
			this.lblAnimalAmount.Name = "lblAnimalAmount";
			this.lblAnimalAmount.Size = new System.Drawing.Size(101, 17);
			this.lblAnimalAmount.TabIndex = 8;
			this.lblAnimalAmount.Text = "Animal amount";
			// 
			// btnSortAnimals
			// 
			this.btnSortAnimals.Location = new System.Drawing.Point(12, 503);
			this.btnSortAnimals.Name = "btnSortAnimals";
			this.btnSortAnimals.Size = new System.Drawing.Size(233, 37);
			this.btnSortAnimals.TabIndex = 9;
			this.btnSortAnimals.Text = "Sort Animals";
			this.btnSortAnimals.UseVisualStyleBackColor = true;
			this.btnSortAnimals.Click += new System.EventHandler(this.Sort_Animals_Click);
			// 
			// btnAddSelectedAnimals
			// 
			this.btnAddSelectedAnimals.Location = new System.Drawing.Point(15, 109);
			this.btnAddSelectedAnimals.Name = "btnAddSelectedAnimals";
			this.btnAddSelectedAnimals.Size = new System.Drawing.Size(233, 36);
			this.btnAddSelectedAnimals.TabIndex = 10;
			this.btnAddSelectedAnimals.Text = "Add selected animal";
			this.btnAddSelectedAnimals.UseVisualStyleBackColor = true;
			this.btnAddSelectedAnimals.Click += new System.EventHandler(this.AddSpecificAnimal_Click);
			// 
			// cBCarnivore
			// 
			this.cBCarnivore.FormattingEnabled = true;
			this.cBCarnivore.Items.AddRange(new object[] {
            "Herbivore",
            "Carnivore",
            "Omnivore"});
			this.cBCarnivore.Location = new System.Drawing.Point(12, 79);
			this.cBCarnivore.Name = "cBCarnivore";
			this.cBCarnivore.Size = new System.Drawing.Size(109, 24);
			this.cBCarnivore.TabIndex = 11;
			this.cBCarnivore.Text = "Herbivore";
			// 
			// cBSize
			// 
			this.cBSize.FormattingEnabled = true;
			this.cBSize.Items.AddRange(new object[] {
            "1",
            "3",
            "5"});
			this.cBSize.Location = new System.Drawing.Point(136, 79);
			this.cBSize.Name = "cBSize";
			this.cBSize.Size = new System.Drawing.Size(109, 24);
			this.cBSize.TabIndex = 12;
			this.cBSize.Text = "1";
			// 
			// lblCarnivore
			// 
			this.lblCarnivore.AutoSize = true;
			this.lblCarnivore.Location = new System.Drawing.Point(12, 59);
			this.lblCarnivore.Name = "lblCarnivore";
			this.lblCarnivore.Size = new System.Drawing.Size(40, 17);
			this.lblCarnivore.TabIndex = 13;
			this.lblCarnivore.Text = "Type";
			// 
			// lblSize
			// 
			this.lblSize.AutoSize = true;
			this.lblSize.Location = new System.Drawing.Point(133, 59);
			this.lblSize.Name = "lblSize";
			this.lblSize.Size = new System.Drawing.Size(35, 17);
			this.lblSize.TabIndex = 14;
			this.lblSize.Text = "Size";
			// 
			// btnAddRandomHerbivores
			// 
			this.btnAddRandomHerbivores.Location = new System.Drawing.Point(12, 193);
			this.btnAddRandomHerbivores.Name = "btnAddRandomHerbivores";
			this.btnAddRandomHerbivores.Size = new System.Drawing.Size(233, 36);
			this.btnAddRandomHerbivores.TabIndex = 15;
			this.btnAddRandomHerbivores.Text = "Add random herbivores";
			this.btnAddRandomHerbivores.UseVisualStyleBackColor = true;
			this.btnAddRandomHerbivores.Click += new System.EventHandler(this.AddHerbivores_Click);
			// 
			// btnAddRandomCarnivores
			// 
			this.btnAddRandomCarnivores.Location = new System.Drawing.Point(12, 235);
			this.btnAddRandomCarnivores.Name = "btnAddRandomCarnivores";
			this.btnAddRandomCarnivores.Size = new System.Drawing.Size(233, 36);
			this.btnAddRandomCarnivores.TabIndex = 16;
			this.btnAddRandomCarnivores.Text = "Add random carnivores";
			this.btnAddRandomCarnivores.UseVisualStyleBackColor = true;
			this.btnAddRandomCarnivores.Click += new System.EventHandler(this.AddCarnivores_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(12, 461);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(233, 36);
			this.btnClear.TabIndex = 17;
			this.btnClear.Text = "Clear allAnimals";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.ClearAnimals_Click);
			// 
			// CircusTrein
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(867, 595);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnAddRandomCarnivores);
			this.Controls.Add(this.btnAddRandomHerbivores);
			this.Controls.Add(this.lblSize);
			this.Controls.Add(this.lblCarnivore);
			this.Controls.Add(this.cBSize);
			this.Controls.Add(this.cBCarnivore);
			this.Controls.Add(this.btnAddSelectedAnimals);
			this.Controls.Add(this.btnSortAnimals);
			this.Controls.Add(this.lblAnimalAmount);
			this.Controls.Add(this.numUDAnimalCount);
			this.Controls.Add(this.lblWagons);
			this.Controls.Add(this.lblAnimals);
			this.Controls.Add(this.tboxAnimals);
			this.Controls.Add(this.tboxWagons);
			this.Controls.Add(this.btnDistribute);
			this.Controls.Add(this.btnAddRandomAnimals);
			this.Name = "CircusTrein";
			this.Text = "Wagon Distributor";
			((System.ComponentModel.ISupportInitialize)(this.numUDAnimalCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddRandomAnimals;
		private System.Windows.Forms.Button btnDistribute;
		private System.Windows.Forms.TextBox tboxWagons;
		private System.Windows.Forms.TextBox tboxAnimals;
		private System.Windows.Forms.Label lblAnimals;
		private System.Windows.Forms.Label lblWagons;
		private System.Windows.Forms.NumericUpDown numUDAnimalCount;
		private System.Windows.Forms.Label lblAnimalAmount;
		private System.Windows.Forms.Button btnSortAnimals;
		private System.Windows.Forms.Button btnAddSelectedAnimals;
		private System.Windows.Forms.ComboBox cBCarnivore;
		private System.Windows.Forms.ComboBox cBSize;
		private System.Windows.Forms.Label lblCarnivore;
		private System.Windows.Forms.Label lblSize;
		private System.Windows.Forms.Button btnAddRandomHerbivores;
		private System.Windows.Forms.Button btnAddRandomCarnivores;
		private System.Windows.Forms.Button btnClear;
	}
}

