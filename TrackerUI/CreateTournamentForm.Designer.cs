﻿namespace TrackerUI
{
	partial class CreateTournamentForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
			headerLabel = new System.Windows.Forms.Label();
			tournamentNameValue = new System.Windows.Forms.TextBox();
			tournamentNameLabel = new System.Windows.Forms.Label();
			entryFeeValue = new System.Windows.Forms.TextBox();
			entryFeeLabel = new System.Windows.Forms.Label();
			selectTeamDropDown = new System.Windows.Forms.ComboBox();
			selectTeamLabel = new System.Windows.Forms.Label();
			createNewTeamLink = new System.Windows.Forms.LinkLabel();
			addTeamButton = new System.Windows.Forms.Button();
			createPrizeButton = new System.Windows.Forms.Button();
			tournamentTeamsListBox = new System.Windows.Forms.ListBox();
			tournamentPlayersLabel = new System.Windows.Forms.Label();
			removeSelectedPlayersButton = new System.Windows.Forms.Button();
			removeSelectedPrizeButton = new System.Windows.Forms.Button();
			prizesLabel = new System.Windows.Forms.Label();
			prizesListBox = new System.Windows.Forms.ListBox();
			createTournamentButton = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// headerLabel
			// 
			headerLabel.AutoSize = true;
			headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			headerLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			headerLabel.Location = new System.Drawing.Point(12, 9);
			headerLabel.Name = "headerLabel";
			headerLabel.Size = new System.Drawing.Size(403, 62);
			headerLabel.TabIndex = 1;
			headerLabel.Text = "Create Tournament";
			// 
			// tournamentNameValue
			// 
			tournamentNameValue.Location = new System.Drawing.Point(43, 185);
			tournamentNameValue.Name = "tournamentNameValue";
			tournamentNameValue.Size = new System.Drawing.Size(372, 43);
			tournamentNameValue.TabIndex = 10;
			// 
			// tournamentNameLabel
			// 
			tournamentNameLabel.AutoSize = true;
			tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			tournamentNameLabel.Location = new System.Drawing.Point(35, 125);
			tournamentNameLabel.Name = "tournamentNameLabel";
			tournamentNameLabel.Size = new System.Drawing.Size(278, 45);
			tournamentNameLabel.TabIndex = 9;
			tournamentNameLabel.Text = "Tournament Name";
			// 
			// entryFeeValue
			// 
			entryFeeValue.Location = new System.Drawing.Point(193, 274);
			entryFeeValue.Name = "entryFeeValue";
			entryFeeValue.Size = new System.Drawing.Size(120, 43);
			entryFeeValue.TabIndex = 12;
			entryFeeValue.Text = "0";
			// 
			// entryFeeLabel
			// 
			entryFeeLabel.AutoSize = true;
			entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			entryFeeLabel.Location = new System.Drawing.Point(35, 271);
			entryFeeLabel.Name = "entryFeeLabel";
			entryFeeLabel.Size = new System.Drawing.Size(151, 45);
			entryFeeLabel.TabIndex = 11;
			entryFeeLabel.Text = "Entry Fee";
			// 
			// selectTeamDropDown
			// 
			selectTeamDropDown.FormattingEnabled = true;
			selectTeamDropDown.Location = new System.Drawing.Point(43, 397);
			selectTeamDropDown.Name = "selectTeamDropDown";
			selectTeamDropDown.Size = new System.Drawing.Size(372, 45);
			selectTeamDropDown.TabIndex = 14;
			// 
			// selectTeamLabel
			// 
			selectTeamLabel.AutoSize = true;
			selectTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			selectTeamLabel.Location = new System.Drawing.Point(35, 349);
			selectTeamLabel.Name = "selectTeamLabel";
			selectTeamLabel.Size = new System.Drawing.Size(183, 45);
			selectTeamLabel.TabIndex = 13;
			selectTeamLabel.Text = "Select Team";
			// 
			// createNewTeamLink
			// 
			createNewTeamLink.AutoSize = true;
			createNewTeamLink.Location = new System.Drawing.Point(272, 355);
			createNewTeamLink.Name = "createNewTeamLink";
			createNewTeamLink.Size = new System.Drawing.Size(143, 38);
			createNewTeamLink.TabIndex = 15;
			createNewTeamLink.TabStop = true;
			createNewTeamLink.Text = "create new";
			createNewTeamLink.LinkClicked += createNewTeamLink_LinkClicked;
			// 
			// addTeamButton
			// 
			addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
			addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
			addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			addTeamButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			addTeamButton.Location = new System.Drawing.Point(98, 458);
			addTeamButton.Name = "addTeamButton";
			addTeamButton.Size = new System.Drawing.Size(275, 51);
			addTeamButton.TabIndex = 16;
			addTeamButton.Text = "Add Team";
			addTeamButton.UseVisualStyleBackColor = true;
			addTeamButton.Click += addTeamButton_Click;
			// 
			// createPrizeButton
			// 
			createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
			createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
			createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			createPrizeButton.Location = new System.Drawing.Point(98, 529);
			createPrizeButton.Name = "createPrizeButton";
			createPrizeButton.Size = new System.Drawing.Size(275, 51);
			createPrizeButton.TabIndex = 17;
			createPrizeButton.Text = "Create Prize";
			createPrizeButton.UseVisualStyleBackColor = true;
			createPrizeButton.Click += createPrizeButton_Click;
			// 
			// tournamentTeamsListBox
			// 
			tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			tournamentTeamsListBox.FormattingEnabled = true;
			tournamentTeamsListBox.ItemHeight = 37;
			tournamentTeamsListBox.Location = new System.Drawing.Point(554, 185);
			tournamentTeamsListBox.Name = "tournamentTeamsListBox";
			tournamentTeamsListBox.Size = new System.Drawing.Size(349, 187);
			tournamentTeamsListBox.TabIndex = 18;
			// 
			// tournamentPlayersLabel
			// 
			tournamentPlayersLabel.AutoSize = true;
			tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			tournamentPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			tournamentPlayersLabel.Location = new System.Drawing.Point(546, 125);
			tournamentPlayersLabel.Name = "tournamentPlayersLabel";
			tournamentPlayersLabel.Size = new System.Drawing.Size(201, 45);
			tournamentPlayersLabel.TabIndex = 19;
			tournamentPlayersLabel.Text = "Team/Players";
			// 
			// removeSelectedPlayersButton
			// 
			removeSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			removeSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
			removeSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
			removeSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			removeSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			removeSelectedPlayersButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			removeSelectedPlayersButton.Location = new System.Drawing.Point(943, 225);
			removeSelectedPlayersButton.Name = "removeSelectedPlayersButton";
			removeSelectedPlayersButton.Size = new System.Drawing.Size(153, 101);
			removeSelectedPlayersButton.TabIndex = 20;
			removeSelectedPlayersButton.Text = "Remove Selected";
			removeSelectedPlayersButton.UseVisualStyleBackColor = true;
			removeSelectedPlayersButton.Click += removeSelectedPlayersButton_Click;
			// 
			// removeSelectedPrizeButton
			// 
			removeSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
			removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
			removeSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			removeSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			removeSelectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			removeSelectedPrizeButton.Location = new System.Drawing.Point(943, 480);
			removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
			removeSelectedPrizeButton.Size = new System.Drawing.Size(153, 100);
			removeSelectedPrizeButton.TabIndex = 23;
			removeSelectedPrizeButton.Text = "Remove Selected";
			removeSelectedPrizeButton.UseVisualStyleBackColor = true;
			removeSelectedPrizeButton.Click += removeSelectedPrizeButton_Click;
			// 
			// prizesLabel
			// 
			prizesLabel.AutoSize = true;
			prizesLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			prizesLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			prizesLabel.Location = new System.Drawing.Point(546, 388);
			prizesLabel.Name = "prizesLabel";
			prizesLabel.Size = new System.Drawing.Size(101, 45);
			prizesLabel.TabIndex = 22;
			prizesLabel.Text = "Prizes";
			// 
			// prizesListBox
			// 
			prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			prizesListBox.FormattingEnabled = true;
			prizesListBox.ItemHeight = 37;
			prizesListBox.Location = new System.Drawing.Point(554, 442);
			prizesListBox.Name = "prizesListBox";
			prizesListBox.Size = new System.Drawing.Size(349, 187);
			prizesListBox.TabIndex = 21;
			// 
			// createTournamentButton
			// 
			createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
			createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
			createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			createTournamentButton.Location = new System.Drawing.Point(403, 663);
			createTournamentButton.Name = "createTournamentButton";
			createTournamentButton.Size = new System.Drawing.Size(297, 69);
			createTournamentButton.TabIndex = 24;
			createTournamentButton.Text = "Create Tournament";
			createTournamentButton.UseVisualStyleBackColor = true;
			createTournamentButton.Click += createTournamentButton_Click;
			// 
			// CreateTournamentForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(14F, 37F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			ClientSize = new System.Drawing.Size(1111, 744);
			Controls.Add(createTournamentButton);
			Controls.Add(removeSelectedPrizeButton);
			Controls.Add(prizesLabel);
			Controls.Add(prizesListBox);
			Controls.Add(removeSelectedPlayersButton);
			Controls.Add(tournamentPlayersLabel);
			Controls.Add(tournamentTeamsListBox);
			Controls.Add(createPrizeButton);
			Controls.Add(addTeamButton);
			Controls.Add(createNewTeamLink);
			Controls.Add(selectTeamDropDown);
			Controls.Add(selectTeamLabel);
			Controls.Add(entryFeeValue);
			Controls.Add(entryFeeLabel);
			Controls.Add(tournamentNameValue);
			Controls.Add(tournamentNameLabel);
			Controls.Add(headerLabel);
			Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
			Name = "CreateTournamentForm";
			Text = "Create Tournament";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.TextBox tournamentNameValue;
		private System.Windows.Forms.Label tournamentNameLabel;
		private System.Windows.Forms.TextBox entryFeeValue;
		private System.Windows.Forms.Label entryFeeLabel;
		private System.Windows.Forms.ComboBox selectTeamDropDown;
		private System.Windows.Forms.Label selectTeamLabel;
		private System.Windows.Forms.LinkLabel createNewTeamLink;
		private System.Windows.Forms.Button addTeamButton;
		private System.Windows.Forms.Button createPrizeButton;
		private System.Windows.Forms.ListBox tournamentTeamsListBox;
		private System.Windows.Forms.Label tournamentPlayersLabel;
		private System.Windows.Forms.Button removeSelectedPlayersButton;
		private System.Windows.Forms.Button removeSelectedPrizeButton;
		private System.Windows.Forms.Label prizesLabel;
		private System.Windows.Forms.ListBox prizesListBox;
		private System.Windows.Forms.Button createTournamentButton;
	}
}