namespace ContainerMovement_V2
{
	partial class containerMovementForm
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
			this.tboxUnassignedContainer = new System.Windows.Forms.TextBox();
			this.btnAddContainers = new System.Windows.Forms.Button();
			this.btnSolve = new System.Windows.Forms.Button();
			this.numUDContainerAmount = new System.Windows.Forms.NumericUpDown();
			this.tboxShipInfo = new System.Windows.Forms.TextBox();
			this.NumUdWidth = new System.Windows.Forms.NumericUpDown();
			this.numUdHeight = new System.Windows.Forms.NumericUpDown();
			this.btnGenerateShip = new System.Windows.Forms.Button();
			this.numUdWeight = new System.Windows.Forms.NumericUpDown();
			this.btnGenerateDefaultShip = new System.Windows.Forms.Button();
			this.flpPiles = new System.Windows.Forms.FlowLayoutPanel();
			this.lblW = new System.Windows.Forms.Label();
			this.lblH = new System.Windows.Forms.Label();
			this.lblWeight = new System.Windows.Forms.Label();
			this.numUdWeightCon = new System.Windows.Forms.NumericUpDown();
			this.gboxShipBuilder = new System.Windows.Forms.GroupBox();
			this.gboxContainerBuilder = new System.Windows.Forms.GroupBox();
			this.lblConWeight = new System.Windows.Forms.Label();
			this.lblConAmount = new System.Windows.Forms.Label();
			this.btnCustomContainer = new System.Windows.Forms.Button();
			this.comboContainerType = new System.Windows.Forms.ComboBox();
			this.lblConType = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numUDContainerAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUdWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUdHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUdWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUdWeightCon)).BeginInit();
			this.gboxShipBuilder.SuspendLayout();
			this.gboxContainerBuilder.SuspendLayout();
			this.SuspendLayout();
			// 
			// tboxUnassignedContainer
			// 
			this.tboxUnassignedContainer.BackColor = System.Drawing.Color.White;
			this.tboxUnassignedContainer.Enabled = false;
			this.tboxUnassignedContainer.Location = new System.Drawing.Point(11, 148);
			this.tboxUnassignedContainer.Multiline = true;
			this.tboxUnassignedContainer.Name = "tboxUnassignedContainer";
			this.tboxUnassignedContainer.ReadOnly = true;
			this.tboxUnassignedContainer.Size = new System.Drawing.Size(366, 600);
			this.tboxUnassignedContainer.TabIndex = 12;
			// 
			// btnAddContainers
			// 
			this.btnAddContainers.Location = new System.Drawing.Point(9, 99);
			this.btnAddContainers.Name = "btnAddContainers";
			this.btnAddContainers.Size = new System.Drawing.Size(228, 23);
			this.btnAddContainers.TabIndex = 13;
			this.btnAddContainers.Text = "Add containers";
			this.btnAddContainers.UseVisualStyleBackColor = true;
			this.btnAddContainers.Click += new System.EventHandler(this.AddContainers_Click);
			// 
			// btnSolve
			// 
			this.btnSolve.Enabled = false;
			this.btnSolve.Location = new System.Drawing.Point(637, 104);
			this.btnSolve.Name = "btnSolve";
			this.btnSolve.Size = new System.Drawing.Size(341, 38);
			this.btnSolve.TabIndex = 14;
			this.btnSolve.Text = "solve";
			this.btnSolve.UseVisualStyleBackColor = true;
			this.btnSolve.Click += new System.EventHandler(this.SolveDock_Click);
			// 
			// numUDContainerAmount
			// 
			this.numUDContainerAmount.Location = new System.Drawing.Point(131, 42);
			this.numUDContainerAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numUDContainerAmount.Name = "numUDContainerAmount";
			this.numUDContainerAmount.Size = new System.Drawing.Size(112, 22);
			this.numUDContainerAmount.TabIndex = 15;
			this.numUDContainerAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// tboxShipInfo
			// 
			this.tboxShipInfo.Enabled = false;
			this.tboxShipInfo.Location = new System.Drawing.Point(984, 12);
			this.tboxShipInfo.Multiline = true;
			this.tboxShipInfo.Name = "tboxShipInfo";
			this.tboxShipInfo.Size = new System.Drawing.Size(200, 130);
			this.tboxShipInfo.TabIndex = 16;
			// 
			// NumUdWidth
			// 
			this.NumUdWidth.Location = new System.Drawing.Point(10, 43);
			this.NumUdWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumUdWidth.Name = "NumUdWidth";
			this.NumUdWidth.Size = new System.Drawing.Size(54, 22);
			this.NumUdWidth.TabIndex = 17;
			this.NumUdWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// numUdHeight
			// 
			this.numUdHeight.Location = new System.Drawing.Point(69, 43);
			this.numUdHeight.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numUdHeight.Name = "numUdHeight";
			this.numUdHeight.Size = new System.Drawing.Size(58, 22);
			this.numUdHeight.TabIndex = 18;
			this.numUdHeight.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// btnGenerateShip
			// 
			this.btnGenerateShip.Location = new System.Drawing.Point(10, 71);
			this.btnGenerateShip.Name = "btnGenerateShip";
			this.btnGenerateShip.Size = new System.Drawing.Size(244, 23);
			this.btnGenerateShip.TabIndex = 19;
			this.btnGenerateShip.Text = "Generate Ship";
			this.btnGenerateShip.UseVisualStyleBackColor = true;
			this.btnGenerateShip.Click += new System.EventHandler(this.btnGenerateShip_Click);
			// 
			// numUdWeight
			// 
			this.numUdWeight.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numUdWeight.Location = new System.Drawing.Point(133, 43);
			this.numUdWeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numUdWeight.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numUdWeight.Name = "numUdWeight";
			this.numUdWeight.Size = new System.Drawing.Size(120, 22);
			this.numUdWeight.TabIndex = 20;
			this.numUdWeight.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			// 
			// btnGenerateDefaultShip
			// 
			this.btnGenerateDefaultShip.Location = new System.Drawing.Point(9, 100);
			this.btnGenerateDefaultShip.Name = "btnGenerateDefaultShip";
			this.btnGenerateDefaultShip.Size = new System.Drawing.Size(244, 23);
			this.btnGenerateDefaultShip.TabIndex = 21;
			this.btnGenerateDefaultShip.Text = "Generate Default Ship";
			this.btnGenerateDefaultShip.UseVisualStyleBackColor = true;
			this.btnGenerateDefaultShip.Click += new System.EventHandler(this.btnGenerateDefaultShip_Click);
			// 
			// flpPiles
			// 
			this.flpPiles.AutoScroll = true;
			this.flpPiles.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpPiles.Location = new System.Drawing.Point(384, 148);
			this.flpPiles.Name = "flpPiles";
			this.flpPiles.Size = new System.Drawing.Size(800, 600);
			this.flpPiles.TabIndex = 22;
			// 
			// lblW
			// 
			this.lblW.AutoSize = true;
			this.lblW.Location = new System.Drawing.Point(9, 21);
			this.lblW.Name = "lblW";
			this.lblW.Size = new System.Drawing.Size(25, 17);
			this.lblW.TabIndex = 23;
			this.lblW.Text = "W:";
			// 
			// lblH
			// 
			this.lblH.AutoSize = true;
			this.lblH.Location = new System.Drawing.Point(66, 20);
			this.lblH.Name = "lblH";
			this.lblH.Size = new System.Drawing.Size(22, 17);
			this.lblH.TabIndex = 24;
			this.lblH.Text = "H:";
			// 
			// lblWeight
			// 
			this.lblWeight.AutoSize = true;
			this.lblWeight.Location = new System.Drawing.Point(130, 23);
			this.lblWeight.Name = "lblWeight";
			this.lblWeight.Size = new System.Drawing.Size(56, 17);
			this.lblWeight.TabIndex = 25;
			this.lblWeight.Text = "Weight:";
			// 
			// numUdWeightCon
			// 
			this.numUdWeightCon.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.numUdWeightCon.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numUdWeightCon.Location = new System.Drawing.Point(6, 42);
			this.numUdWeightCon.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numUdWeightCon.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numUdWeightCon.Name = "numUdWeightCon";
			this.numUdWeightCon.Size = new System.Drawing.Size(120, 22);
			this.numUdWeightCon.TabIndex = 26;
			this.numUdWeightCon.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// gboxShipBuilder
			// 
			this.gboxShipBuilder.Controls.Add(this.numUdWeight);
			this.gboxShipBuilder.Controls.Add(this.NumUdWidth);
			this.gboxShipBuilder.Controls.Add(this.lblWeight);
			this.gboxShipBuilder.Controls.Add(this.numUdHeight);
			this.gboxShipBuilder.Controls.Add(this.lblH);
			this.gboxShipBuilder.Controls.Add(this.btnGenerateShip);
			this.gboxShipBuilder.Controls.Add(this.lblW);
			this.gboxShipBuilder.Controls.Add(this.btnGenerateDefaultShip);
			this.gboxShipBuilder.Location = new System.Drawing.Point(12, 12);
			this.gboxShipBuilder.Name = "gboxShipBuilder";
			this.gboxShipBuilder.Size = new System.Drawing.Size(259, 128);
			this.gboxShipBuilder.TabIndex = 27;
			this.gboxShipBuilder.TabStop = false;
			this.gboxShipBuilder.Text = "Ship";
			// 
			// gboxContainerBuilder
			// 
			this.gboxContainerBuilder.Controls.Add(this.lblConType);
			this.gboxContainerBuilder.Controls.Add(this.comboContainerType);
			this.gboxContainerBuilder.Controls.Add(this.btnCustomContainer);
			this.gboxContainerBuilder.Controls.Add(this.lblConAmount);
			this.gboxContainerBuilder.Controls.Add(this.lblConWeight);
			this.gboxContainerBuilder.Controls.Add(this.numUdWeightCon);
			this.gboxContainerBuilder.Controls.Add(this.btnAddContainers);
			this.gboxContainerBuilder.Controls.Add(this.numUDContainerAmount);
			this.gboxContainerBuilder.Enabled = false;
			this.gboxContainerBuilder.Location = new System.Drawing.Point(277, 12);
			this.gboxContainerBuilder.Name = "gboxContainerBuilder";
			this.gboxContainerBuilder.Size = new System.Drawing.Size(354, 128);
			this.gboxContainerBuilder.TabIndex = 28;
			this.gboxContainerBuilder.TabStop = false;
			this.gboxContainerBuilder.Text = "Container";
			// 
			// lblConWeight
			// 
			this.lblConWeight.AutoSize = true;
			this.lblConWeight.Location = new System.Drawing.Point(6, 22);
			this.lblConWeight.Name = "lblConWeight";
			this.lblConWeight.Size = new System.Drawing.Size(56, 17);
			this.lblConWeight.TabIndex = 26;
			this.lblConWeight.Text = "Weight:";
			// 
			// lblConAmount
			// 
			this.lblConAmount.AutoSize = true;
			this.lblConAmount.Location = new System.Drawing.Point(130, 22);
			this.lblConAmount.Name = "lblConAmount";
			this.lblConAmount.Size = new System.Drawing.Size(60, 17);
			this.lblConAmount.TabIndex = 28;
			this.lblConAmount.Text = "Amount:";
			// 
			// btnCustomContainer
			// 
			this.btnCustomContainer.Location = new System.Drawing.Point(9, 70);
			this.btnCustomContainer.Name = "btnCustomContainer";
			this.btnCustomContainer.Size = new System.Drawing.Size(228, 23);
			this.btnCustomContainer.TabIndex = 29;
			this.btnCustomContainer.Text = "Add Custom containers";
			this.btnCustomContainer.UseVisualStyleBackColor = true;
			this.btnCustomContainer.Click += new System.EventHandler(this.btnCustomContainer_Click);
			// 
			// comboContainerType
			// 
			this.comboContainerType.FormattingEnabled = true;
			this.comboContainerType.Items.AddRange(new object[] {
            "Regular",
            "Cooled",
            "Valueable"});
			this.comboContainerType.Location = new System.Drawing.Point(250, 42);
			this.comboContainerType.Name = "comboContainerType";
			this.comboContainerType.Size = new System.Drawing.Size(98, 24);
			this.comboContainerType.TabIndex = 30;
			this.comboContainerType.Text = "Regular";
			// 
			// lblConType
			// 
			this.lblConType.AutoSize = true;
			this.lblConType.Location = new System.Drawing.Point(249, 23);
			this.lblConType.Name = "lblConType";
			this.lblConType.Size = new System.Drawing.Size(44, 17);
			this.lblConType.TabIndex = 31;
			this.lblConType.Text = "Type:";
			// 
			// containerMovementForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1194, 756);
			this.Controls.Add(this.gboxContainerBuilder);
			this.Controls.Add(this.gboxShipBuilder);
			this.Controls.Add(this.flpPiles);
			this.Controls.Add(this.tboxShipInfo);
			this.Controls.Add(this.btnSolve);
			this.Controls.Add(this.tboxUnassignedContainer);
			this.Name = "containerMovementForm";
			this.Text = "Ship distributor";
			((System.ComponentModel.ISupportInitialize)(this.numUDContainerAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUdWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUdHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUdWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUdWeightCon)).EndInit();
			this.gboxShipBuilder.ResumeLayout(false);
			this.gboxShipBuilder.PerformLayout();
			this.gboxContainerBuilder.ResumeLayout(false);
			this.gboxContainerBuilder.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox tboxUnassignedContainer;
		private System.Windows.Forms.Button btnAddContainers;
		private System.Windows.Forms.Button btnSolve;
		private System.Windows.Forms.NumericUpDown numUDContainerAmount;
		private System.Windows.Forms.TextBox tboxShipInfo;
		private System.Windows.Forms.NumericUpDown NumUdWidth;
		private System.Windows.Forms.NumericUpDown numUdHeight;
		private System.Windows.Forms.Button btnGenerateShip;
		private System.Windows.Forms.NumericUpDown numUdWeight;
		private System.Windows.Forms.Button btnGenerateDefaultShip;
		private System.Windows.Forms.FlowLayoutPanel flpPiles;
		private System.Windows.Forms.Label lblW;
		private System.Windows.Forms.Label lblH;
		private System.Windows.Forms.Label lblWeight;
		private System.Windows.Forms.NumericUpDown numUdWeightCon;
		private System.Windows.Forms.GroupBox gboxShipBuilder;
		private System.Windows.Forms.GroupBox gboxContainerBuilder;
		private System.Windows.Forms.Label lblConAmount;
		private System.Windows.Forms.Label lblConWeight;
		private System.Windows.Forms.Label lblConType;
		private System.Windows.Forms.ComboBox comboContainerType;
		private System.Windows.Forms.Button btnCustomContainer;
	}
}

