namespace Kameleon_Opdracht
{
	partial class Kameleons
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
			this.components = new System.ComponentModel.Container();
			this.pnlVisualisation = new System.Windows.Forms.Panel();
			this.btnStart = new System.Windows.Forms.Button();
			this.numUDRedChameleon = new System.Windows.Forms.NumericUpDown();
			this.numUDBlueChameleon = new System.Windows.Forms.NumericUpDown();
			this.numUDGreenChameleon = new System.Windows.Forms.NumericUpDown();
			this.bntReset = new System.Windows.Forms.Button();
			this.lblRedChameleon = new System.Windows.Forms.Label();
			this.lblBlueChameleon = new System.Windows.Forms.Label();
			this.lblGreenChameleon = new System.Windows.Forms.Label();
			this.tmrMain = new System.Windows.Forms.Timer(this.components);
			this.tboxCoordinates = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numUDRedChameleon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUDBlueChameleon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUDGreenChameleon)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlVisualisation
			// 
			this.pnlVisualisation.BackColor = System.Drawing.SystemColors.HighlightText;
			this.pnlVisualisation.Location = new System.Drawing.Point(222, 13);
			this.pnlVisualisation.Name = "pnlVisualisation";
			this.pnlVisualisation.Size = new System.Drawing.Size(973, 748);
			this.pnlVisualisation.TabIndex = 0;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(13, 681);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(203, 80);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start Simulation";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.Start_Simulation_Click);
			// 
			// numUDRedChameleon
			// 
			this.numUDRedChameleon.Location = new System.Drawing.Point(12, 36);
			this.numUDRedChameleon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numUDRedChameleon.Name = "numUDRedChameleon";
			this.numUDRedChameleon.Size = new System.Drawing.Size(203, 22);
			this.numUDRedChameleon.TabIndex = 2;
			this.numUDRedChameleon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numUDBlueChameleon
			// 
			this.numUDBlueChameleon.Location = new System.Drawing.Point(12, 85);
			this.numUDBlueChameleon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numUDBlueChameleon.Name = "numUDBlueChameleon";
			this.numUDBlueChameleon.Size = new System.Drawing.Size(203, 22);
			this.numUDBlueChameleon.TabIndex = 3;
			this.numUDBlueChameleon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numUDGreenChameleon
			// 
			this.numUDGreenChameleon.Location = new System.Drawing.Point(13, 137);
			this.numUDGreenChameleon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numUDGreenChameleon.Name = "numUDGreenChameleon";
			this.numUDGreenChameleon.Size = new System.Drawing.Size(203, 22);
			this.numUDGreenChameleon.TabIndex = 4;
			this.numUDGreenChameleon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// bntReset
			// 
			this.bntReset.Location = new System.Drawing.Point(13, 620);
			this.bntReset.Name = "bntReset";
			this.bntReset.Size = new System.Drawing.Size(203, 55);
			this.bntReset.TabIndex = 5;
			this.bntReset.Text = "Reset";
			this.bntReset.UseVisualStyleBackColor = true;
			this.bntReset.Click += new System.EventHandler(this.Reset_Click);
			// 
			// lblRedChameleon
			// 
			this.lblRedChameleon.AutoSize = true;
			this.lblRedChameleon.Location = new System.Drawing.Point(10, 13);
			this.lblRedChameleon.Name = "lblRedChameleon";
			this.lblRedChameleon.Size = new System.Drawing.Size(116, 17);
			this.lblRedChameleon.TabIndex = 6;
			this.lblRedChameleon.Text = "Red Chameleons";
			// 
			// lblBlueChameleon
			// 
			this.lblBlueChameleon.AutoSize = true;
			this.lblBlueChameleon.Location = new System.Drawing.Point(10, 65);
			this.lblBlueChameleon.Name = "lblBlueChameleon";
			this.lblBlueChameleon.Size = new System.Drawing.Size(118, 17);
			this.lblBlueChameleon.TabIndex = 7;
			this.lblBlueChameleon.Text = "Blue Chameleons";
			// 
			// lblGreenChameleon
			// 
			this.lblGreenChameleon.AutoSize = true;
			this.lblGreenChameleon.Location = new System.Drawing.Point(10, 117);
			this.lblGreenChameleon.Name = "lblGreenChameleon";
			this.lblGreenChameleon.Size = new System.Drawing.Size(130, 17);
			this.lblGreenChameleon.TabIndex = 8;
			this.lblGreenChameleon.Text = "Green Chameleons";
			// 
			// tmrMain
			// 
			this.tmrMain.Interval = 40;
			this.tmrMain.Tick += new System.EventHandler(this.TmrMain_Tick);
			// 
			// tboxCoordinates
			// 
			this.tboxCoordinates.Location = new System.Drawing.Point(12, 165);
			this.tboxCoordinates.Multiline = true;
			this.tboxCoordinates.Name = "tboxCoordinates";
			this.tboxCoordinates.Size = new System.Drawing.Size(203, 449);
			this.tboxCoordinates.TabIndex = 9;
			// 
			// Kameleons
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1207, 773);
			this.Controls.Add(this.tboxCoordinates);
			this.Controls.Add(this.lblGreenChameleon);
			this.Controls.Add(this.lblBlueChameleon);
			this.Controls.Add(this.lblRedChameleon);
			this.Controls.Add(this.bntReset);
			this.Controls.Add(this.numUDGreenChameleon);
			this.Controls.Add(this.numUDBlueChameleon);
			this.Controls.Add(this.numUDRedChameleon);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.pnlVisualisation);
			this.Name = "Kameleons";
			this.Text = "ChameleonIsland";
			((System.ComponentModel.ISupportInitialize)(this.numUDRedChameleon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUDBlueChameleon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUDGreenChameleon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlVisualisation;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.NumericUpDown numUDRedChameleon;
		private System.Windows.Forms.NumericUpDown numUDBlueChameleon;
		private System.Windows.Forms.NumericUpDown numUDGreenChameleon;
		private System.Windows.Forms.Button bntReset;
		private System.Windows.Forms.Label lblRedChameleon;
		private System.Windows.Forms.Label lblBlueChameleon;
		private System.Windows.Forms.Label lblGreenChameleon;
		private System.Windows.Forms.Timer tmrMain;
		private System.Windows.Forms.TextBox tboxCoordinates;
	}
}

