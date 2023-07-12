namespace TrackerUI
{
	partial class CreateTeamForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
			headerLabel = new System.Windows.Forms.Label();
			teamNameValue = new System.Windows.Forms.TextBox();
			teamNameLabel = new System.Windows.Forms.Label();
			addMemberButton = new System.Windows.Forms.Button();
			createNewTeamLink = new System.Windows.Forms.LinkLabel();
			selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
			selectTeamMemberLabel = new System.Windows.Forms.Label();
			addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
			createMemberButton = new System.Windows.Forms.Button();
			cellphoneValue = new System.Windows.Forms.TextBox();
			cellphoneLabel = new System.Windows.Forms.Label();
			emailValue = new System.Windows.Forms.TextBox();
			emailLabel = new System.Windows.Forms.Label();
			lastNameValue = new System.Windows.Forms.TextBox();
			lastNameLabel = new System.Windows.Forms.Label();
			firstNameValue = new System.Windows.Forms.TextBox();
			firstNameLabel = new System.Windows.Forms.Label();
			teamMembersListBox = new System.Windows.Forms.ListBox();
			deleteSelectedMemberButton = new System.Windows.Forms.Button();
			createTeamButton = new System.Windows.Forms.Button();
			addNewMemberGroupBox.SuspendLayout();
			SuspendLayout();
			// 
			// headerLabel
			// 
			headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			headerLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			headerLabel.Location = new System.Drawing.Point(26, 9);
			headerLabel.Name = "headerLabel";
			headerLabel.Size = new System.Drawing.Size(272, 62);
			headerLabel.TabIndex = 2;
			headerLabel.Text = "Create Team";
			// 
			// teamNameValue
			// 
			teamNameValue.Location = new System.Drawing.Point(37, 157);
			teamNameValue.Name = "teamNameValue";
			teamNameValue.Size = new System.Drawing.Size(438, 43);
			teamNameValue.TabIndex = 12;
			// 
			// teamNameLabel
			// 
			teamNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			teamNameLabel.Location = new System.Drawing.Point(29, 97);
			teamNameLabel.Name = "teamNameLabel";
			teamNameLabel.Size = new System.Drawing.Size(184, 45);
			teamNameLabel.TabIndex = 11;
			teamNameLabel.Text = "Team Name";
			// 
			// addMemberButton
			// 
			addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
			addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
			addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			addMemberButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			addMemberButton.Location = new System.Drawing.Point(128, 350);
			addMemberButton.Name = "addMemberButton";
			addMemberButton.Size = new System.Drawing.Size(258, 51);
			addMemberButton.TabIndex = 20;
			addMemberButton.Text = "Add Member";
			addMemberButton.UseVisualStyleBackColor = true;
			addMemberButton.Click += addMemberButton_Click;
			// 
			// createNewTeamLink
			// 
			createNewTeamLink.Location = new System.Drawing.Point(266, 245);
			createNewTeamLink.Name = "createNewTeamLink";
			createNewTeamLink.Size = new System.Drawing.Size(0, 38);
			createNewTeamLink.TabIndex = 19;
			// 
			// selectTeamMemberDropDown
			// 
			selectTeamMemberDropDown.FormattingEnabled = true;
			selectTeamMemberDropDown.Location = new System.Drawing.Point(37, 287);
			selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
			selectTeamMemberDropDown.Size = new System.Drawing.Size(438, 45);
			selectTeamMemberDropDown.TabIndex = 18;
			// 
			// selectTeamMemberLabel
			// 
			selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			selectTeamMemberLabel.Location = new System.Drawing.Point(29, 239);
			selectTeamMemberLabel.Name = "selectTeamMemberLabel";
			selectTeamMemberLabel.Size = new System.Drawing.Size(309, 45);
			selectTeamMemberLabel.TabIndex = 17;
			selectTeamMemberLabel.Text = "Select Team Member";
			// 
			// addNewMemberGroupBox
			// 
			addNewMemberGroupBox.Controls.Add(createMemberButton);
			addNewMemberGroupBox.Controls.Add(cellphoneValue);
			addNewMemberGroupBox.Controls.Add(cellphoneLabel);
			addNewMemberGroupBox.Controls.Add(emailValue);
			addNewMemberGroupBox.Controls.Add(emailLabel);
			addNewMemberGroupBox.Controls.Add(lastNameValue);
			addNewMemberGroupBox.Controls.Add(lastNameLabel);
			addNewMemberGroupBox.Controls.Add(firstNameValue);
			addNewMemberGroupBox.Controls.Add(firstNameLabel);
			addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			addNewMemberGroupBox.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			addNewMemberGroupBox.Location = new System.Drawing.Point(37, 421);
			addNewMemberGroupBox.Name = "addNewMemberGroupBox";
			addNewMemberGroupBox.Size = new System.Drawing.Size(439, 515);
			addNewMemberGroupBox.TabIndex = 21;
			addNewMemberGroupBox.TabStop = false;
			addNewMemberGroupBox.Text = "Add New Member";
			// 
			// createMemberButton
			// 
			createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
			createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
			createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			createMemberButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			createMemberButton.Location = new System.Drawing.Point(91, 407);
			createMemberButton.Name = "createMemberButton";
			createMemberButton.Size = new System.Drawing.Size(258, 51);
			createMemberButton.TabIndex = 22;
			createMemberButton.Text = "Create Member";
			createMemberButton.UseVisualStyleBackColor = true;
			createMemberButton.Click += createMemberButton_Click;
			// 
			// cellphoneValue
			// 
			cellphoneValue.Location = new System.Drawing.Point(183, 297);
			cellphoneValue.Name = "cellphoneValue";
			cellphoneValue.Size = new System.Drawing.Size(205, 51);
			cellphoneValue.TabIndex = 16;
			// 
			// cellphoneLabel
			// 
			cellphoneLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			cellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			cellphoneLabel.Location = new System.Drawing.Point(11, 303);
			cellphoneLabel.Name = "cellphoneLabel";
			cellphoneLabel.Size = new System.Drawing.Size(161, 45);
			cellphoneLabel.TabIndex = 15;
			cellphoneLabel.Text = "Cellphone";
			// 
			// emailValue
			// 
			emailValue.Location = new System.Drawing.Point(183, 219);
			emailValue.Name = "emailValue";
			emailValue.Size = new System.Drawing.Size(205, 51);
			emailValue.TabIndex = 14;
			// 
			// emailLabel
			// 
			emailLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			emailLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			emailLabel.Location = new System.Drawing.Point(11, 225);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new System.Drawing.Size(94, 45);
			emailLabel.TabIndex = 13;
			emailLabel.Text = "Email";
			// 
			// lastNameValue
			// 
			lastNameValue.Location = new System.Drawing.Point(183, 140);
			lastNameValue.Name = "lastNameValue";
			lastNameValue.Size = new System.Drawing.Size(205, 51);
			lastNameValue.TabIndex = 12;
			// 
			// lastNameLabel
			// 
			lastNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			lastNameLabel.Location = new System.Drawing.Point(10, 143);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new System.Drawing.Size(166, 45);
			lastNameLabel.TabIndex = 11;
			lastNameLabel.Text = "Last Name";
			// 
			// firstNameValue
			// 
			firstNameValue.Location = new System.Drawing.Point(183, 55);
			firstNameValue.Name = "firstNameValue";
			firstNameValue.Size = new System.Drawing.Size(205, 51);
			firstNameValue.TabIndex = 10;
			// 
			// firstNameLabel
			// 
			firstNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			firstNameLabel.Location = new System.Drawing.Point(9, 58);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new System.Drawing.Size(168, 45);
			firstNameLabel.TabIndex = 9;
			firstNameLabel.Text = "First Name";
			// 
			// teamMembersListBox
			// 
			teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			teamMembersListBox.FormattingEnabled = true;
			teamMembersListBox.ItemHeight = 37;
			teamMembersListBox.Location = new System.Drawing.Point(606, 157);
			teamMembersListBox.Name = "teamMembersListBox";
			teamMembersListBox.Size = new System.Drawing.Size(388, 742);
			teamMembersListBox.TabIndex = 22;
			// 
			// deleteSelectedMemberButton
			// 
			deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
			deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
			deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			deleteSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			deleteSelectedMemberButton.Location = new System.Drawing.Point(1015, 508);
			deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
			deleteSelectedMemberButton.Size = new System.Drawing.Size(153, 101);
			deleteSelectedMemberButton.TabIndex = 23;
			deleteSelectedMemberButton.Text = "Delete Selected";
			deleteSelectedMemberButton.UseVisualStyleBackColor = true;
			// 
			// createTeamButton
			// 
			createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(102, 102, 102);
			createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
			createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			createTeamButton.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
			createTeamButton.Location = new System.Drawing.Point(415, 974);
			createTeamButton.Name = "createTeamButton";
			createTeamButton.Size = new System.Drawing.Size(297, 51);
			createTeamButton.TabIndex = 25;
			createTeamButton.Text = "Create Team";
			createTeamButton.UseVisualStyleBackColor = true;
			// 
			// CreateTeamForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(14F, 37F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			ClientSize = new System.Drawing.Size(1104, 722);
			Controls.Add(createTeamButton);
			Controls.Add(deleteSelectedMemberButton);
			Controls.Add(teamMembersListBox);
			Controls.Add(addNewMemberGroupBox);
			Controls.Add(addMemberButton);
			Controls.Add(createNewTeamLink);
			Controls.Add(selectTeamMemberDropDown);
			Controls.Add(selectTeamMemberLabel);
			Controls.Add(teamNameValue);
			Controls.Add(teamNameLabel);
			Controls.Add(headerLabel);
			Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			Name = "CreateTeamForm";
			Text = "Create Team";
			addNewMemberGroupBox.ResumeLayout(false);
			addNewMemberGroupBox.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.TextBox teamNameValue;
		private System.Windows.Forms.Label teamNameLabel;
		private System.Windows.Forms.Button addMemberButton;
		private System.Windows.Forms.LinkLabel createNewTeamLink;
		private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
		private System.Windows.Forms.Label selectTeamMemberLabel;
		private System.Windows.Forms.GroupBox addNewMemberGroupBox;
		private System.Windows.Forms.Button createMemberButton;
		private System.Windows.Forms.TextBox cellphoneValue;
		private System.Windows.Forms.Label cellphoneLabel;
		private System.Windows.Forms.TextBox emailValue;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.TextBox lastNameValue;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.TextBox firstNameValue;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.ListBox teamMembersListBox;
		private System.Windows.Forms.Button deleteSelectedMemberButton;
		private System.Windows.Forms.Button createTeamButton;
	}
}