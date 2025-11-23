namespace PatientTestManagerWinApp
{
    partial class MainPage
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
            PatientsGrid = new DataGridView();
            PatientNameLabel = new Label();
            PatientNameTextBox = new TextBox();
            PatientDateOfBirthLabel = new Label();
            PatientGenderLabel = new Label();
            PatientDateOfBirthDateTimePicker = new DateTimePicker();
            PatientGenderComboBox = new ComboBox();
            PatientCreateButton = new Button();
            PatientUpdateButton = new Button();
            PatientDeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PatientsGrid).BeginInit();
            SuspendLayout();
            // 
            // PatientsGrid
            // 
            PatientsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PatientsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            PatientsGrid.BackgroundColor = SystemColors.ActiveCaption;
            PatientsGrid.Location = new Point(492, 29);
            PatientsGrid.Margin = new Padding(3, 40, 3, 3);
            PatientsGrid.Name = "PatientsGrid";
            PatientsGrid.Size = new Size(482, 350);
            PatientsGrid.TabIndex = 0;
            PatientsGrid.SelectionChanged += PatientsGrid_SelectionChanged;
            // 
            // PatientNameLabel
            // 
            PatientNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientNameLabel.AutoSize = true;
            PatientNameLabel.Location = new Point(91, 49);
            PatientNameLabel.Name = "PatientNameLabel";
            PatientNameLabel.Size = new Size(39, 15);
            PatientNameLabel.TabIndex = 1;
            PatientNameLabel.Text = "Name";
            // 
            // PatientNameTextBox
            // 
            PatientNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientNameTextBox.Location = new Point(199, 46);
            PatientNameTextBox.Name = "PatientNameTextBox";
            PatientNameTextBox.Size = new Size(152, 23);
            PatientNameTextBox.TabIndex = 2;
            // 
            // PatientDateOfBirthLabel
            // 
            PatientDateOfBirthLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientDateOfBirthLabel.AutoSize = true;
            PatientDateOfBirthLabel.Location = new Point(91, 75);
            PatientDateOfBirthLabel.Name = "PatientDateOfBirthLabel";
            PatientDateOfBirthLabel.Size = new Size(69, 15);
            PatientDateOfBirthLabel.TabIndex = 3;
            PatientDateOfBirthLabel.Text = "DateOfBirth";
            // 
            // PatientGenderLabel
            // 
            PatientGenderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientGenderLabel.AutoSize = true;
            PatientGenderLabel.Location = new Point(91, 107);
            PatientGenderLabel.Name = "PatientGenderLabel";
            PatientGenderLabel.Size = new Size(45, 15);
            PatientGenderLabel.TabIndex = 9;
            PatientGenderLabel.Text = "Gender";
            // 
            // PatientDateOfBirthDateTimePicker
            // 
            PatientDateOfBirthDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientDateOfBirthDateTimePicker.CalendarForeColor = Color.DarkCyan;
            PatientDateOfBirthDateTimePicker.Format = DateTimePickerFormat.Short;
            PatientDateOfBirthDateTimePicker.Location = new Point(199, 75);
            PatientDateOfBirthDateTimePicker.Name = "PatientDateOfBirthDateTimePicker";
            PatientDateOfBirthDateTimePicker.Size = new Size(147, 23);
            PatientDateOfBirthDateTimePicker.TabIndex = 11;
            // 
            // PatientGenderComboBox
            // 
            PatientGenderComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientGenderComboBox.FormattingEnabled = true;
            PatientGenderComboBox.Items.AddRange(new object[] { "Male", "Female" });
            PatientGenderComboBox.Location = new Point(199, 104);
            PatientGenderComboBox.Name = "PatientGenderComboBox";
            PatientGenderComboBox.Size = new Size(173, 23);
            PatientGenderComboBox.TabIndex = 12;
            // 
            // PatientCreateButton
            // 
            PatientCreateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientCreateButton.BackColor = Color.Cyan;
            PatientCreateButton.ForeColor = Color.Green;
            PatientCreateButton.Location = new Point(41, 133);
            PatientCreateButton.Name = "PatientCreateButton";
            PatientCreateButton.Size = new Size(104, 25);
            PatientCreateButton.TabIndex = 13;
            PatientCreateButton.Text = "Create";
            PatientCreateButton.UseVisualStyleBackColor = false;
            PatientCreateButton.Click += PatientCreateButton_Click;
            // 
            // PatientUpdateButton
            // 
            PatientUpdateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientUpdateButton.BackColor = Color.Yellow;
            PatientUpdateButton.ForeColor = Color.Black;
            PatientUpdateButton.Location = new Point(174, 133);
            PatientUpdateButton.Name = "PatientUpdateButton";
            PatientUpdateButton.Size = new Size(104, 25);
            PatientUpdateButton.TabIndex = 14;
            PatientUpdateButton.Text = "Update";
            PatientUpdateButton.UseVisualStyleBackColor = false;
            PatientUpdateButton.Click += PatientUpdateButton_Click;
            // 
            // PatientDeleteButton
            // 
            PatientDeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientDeleteButton.BackColor = Color.Red;
            PatientDeleteButton.ForeColor = Color.Black;
            PatientDeleteButton.Location = new Point(307, 133);
            PatientDeleteButton.Name = "PatientDeleteButton";
            PatientDeleteButton.Size = new Size(104, 25);
            PatientDeleteButton.TabIndex = 15;
            PatientDeleteButton.Text = "Delete";
            PatientDeleteButton.UseVisualStyleBackColor = false;
            PatientDeleteButton.Click += PatientDeleteButton_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 494);
            Controls.Add(PatientDeleteButton);
            Controls.Add(PatientUpdateButton);
            Controls.Add(PatientCreateButton);
            Controls.Add(PatientGenderComboBox);
            Controls.Add(PatientDateOfBirthDateTimePicker);
            Controls.Add(PatientGenderLabel);
            Controls.Add(PatientDateOfBirthLabel);
            Controls.Add(PatientNameTextBox);
            Controls.Add(PatientNameLabel);
            Controls.Add(PatientsGrid);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)PatientsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PatientsGrid;
        private Label PatientNameLabel;
        private TextBox PatientNameTextBox;
        private Label PatientDateOfBirthLabel;
        private Label PatientGenderLabel;
        private DateTimePicker PatientDateOfBirthDateTimePicker;
        private ComboBox PatientGenderComboBox;
        private Button PatientCreateButton;
        private Button PatientUpdateButton;
        private Button PatientDeleteButton;
    }
}
