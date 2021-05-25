namespace Pannekoeken_Sorter
{
	partial class Pancakes
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
			this.numUDCount = new System.Windows.Forms.NumericUpDown();
			this.pnlPancakes = new System.Windows.Forms.Panel();
			this.SolveButton = new System.Windows.Forms.Button();
			this.btnSetPancakes = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numUDCount)).BeginInit();
			this.SuspendLayout();
			// 
			// numUDCount
			// 
			this.numUDCount.Location = new System.Drawing.Point(13, 13);
			this.numUDCount.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.numUDCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.numUDCount.Name = "numUDCount";
			this.numUDCount.Size = new System.Drawing.Size(335, 22);
			this.numUDCount.TabIndex = 0;
			this.numUDCount.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
			// 
			// pnlPancakes
			// 
			this.pnlPancakes.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pnlPancakes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlPancakes.Location = new System.Drawing.Point(354, 12);
			this.pnlPancakes.Name = "pnlPancakes";
			this.pnlPancakes.Size = new System.Drawing.Size(600, 600);
			this.pnlPancakes.TabIndex = 1;
			// 
			// SolveButton
			// 
			this.SolveButton.Location = new System.Drawing.Point(12, 547);
			this.SolveButton.Name = "SolveButton";
			this.SolveButton.Size = new System.Drawing.Size(336, 65);
			this.SolveButton.TabIndex = 2;
			this.SolveButton.Text = "Solve";
			this.SolveButton.UseVisualStyleBackColor = true;
			this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
			// 
			// btnSetPancakes
			// 
			this.btnSetPancakes.Location = new System.Drawing.Point(12, 487);
			this.btnSetPancakes.Name = "btnSetPancakes";
			this.btnSetPancakes.Size = new System.Drawing.Size(336, 32);
			this.btnSetPancakes.TabIndex = 3;
			this.btnSetPancakes.Text = "set pancakes";
			this.btnSetPancakes.UseVisualStyleBackColor = true;
			this.btnSetPancakes.Click += new System.EventHandler(this.Set_Pancakes_Click);
			// 
			// Pancakes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(966, 621);
			this.Controls.Add(this.btnSetPancakes);
			this.Controls.Add(this.SolveButton);
			this.Controls.Add(this.pnlPancakes);
			this.Controls.Add(this.numUDCount);
			this.Name = "Pancakes";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numUDCount)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numUDCount;
		private System.Windows.Forms.Panel pnlPancakes;
		private System.Windows.Forms.Button SolveButton;
		private System.Windows.Forms.Button btnSetPancakes;
	}
}

