using System.Windows.Forms;

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
            DataGridViewCellStyle PatientGridColumnHeadersCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle PatientGridCellStyle = new DataGridViewCellStyle();
            PatientNameLabel = new Label();
            PatientNameTextBox = new TextBox();
            PatientDateOfBirthLabel = new Label();
            PatientGenderLabel = new Label();
            PatientDateOfBirthDateTimePicker = new DateTimePicker();
            PatientGenderComboBox = new ComboBox();
            PatientCreateButton = new Button();
            PatientUpdateButton = new Button();
            PatientDeleteButton = new Button();
            PatientGrid = new DataGridView();
            PatientShowTestsButton = new Button();
            PatientReportButton = new Button();
            TestPerformedOnToDateTimePicker = new DateTimePicker();
            PatientTestPerformedOnToLabel = new Label();
            TestPerformedOnFromDateTimePicker = new DateTimePicker();
            PatientTestPerformedOnFromLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)PatientGrid).BeginInit();
            SuspendLayout();
            // 
            // PatientNameLabel
            // 
            PatientNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientNameLabel.AutoSize = true;
            PatientNameLabel.Location = new Point(87, 83);
            PatientNameLabel.Name = "PatientNameLabel";
            PatientNameLabel.Size = new Size(39, 15);
            PatientNameLabel.TabIndex = 1;
            PatientNameLabel.Text = "Name";
            // 
            // PatientNameTextBox
            // 
            PatientNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientNameTextBox.Location = new Point(195, 80);
            PatientNameTextBox.Name = "PatientNameTextBox";
            PatientNameTextBox.Size = new Size(152, 23);
            PatientNameTextBox.TabIndex = 2;
            // 
            // PatientDateOfBirthLabel
            // 
            PatientDateOfBirthLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientDateOfBirthLabel.AutoSize = true;
            PatientDateOfBirthLabel.Location = new Point(87, 109);
            PatientDateOfBirthLabel.Name = "PatientDateOfBirthLabel";
            PatientDateOfBirthLabel.Size = new Size(69, 15);
            PatientDateOfBirthLabel.TabIndex = 3;
            PatientDateOfBirthLabel.Text = "DateOfBirth";
            // 
            // PatientGenderLabel
            // 
            PatientGenderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientGenderLabel.AutoSize = true;
            PatientGenderLabel.Location = new Point(87, 141);
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
            PatientDateOfBirthDateTimePicker.Location = new Point(195, 109);
            PatientDateOfBirthDateTimePicker.Name = "PatientDateOfBirthDateTimePicker";
            PatientDateOfBirthDateTimePicker.Size = new Size(147, 23);
            PatientDateOfBirthDateTimePicker.TabIndex = 11;
            // 
            // PatientGenderComboBox
            // 
            PatientGenderComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientGenderComboBox.FormattingEnabled = true;
            PatientGenderComboBox.Items.AddRange(new object[] { "Male", "Female" });
            PatientGenderComboBox.Location = new Point(195, 138);
            PatientGenderComboBox.Name = "PatientGenderComboBox";
            PatientGenderComboBox.Size = new Size(173, 23);
            PatientGenderComboBox.TabIndex = 12;
            // 
            // PatientCreateButton
            // 
            PatientCreateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientCreateButton.BackColor = Color.Cyan;
            PatientCreateButton.ForeColor = Color.Green;
            PatientCreateButton.Location = new Point(37, 177);
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
            PatientUpdateButton.Location = new Point(170, 177);
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
            PatientDeleteButton.Location = new Point(303, 177);
            PatientDeleteButton.Name = "PatientDeleteButton";
            PatientDeleteButton.Size = new Size(104, 25);
            PatientDeleteButton.TabIndex = 15;
            PatientDeleteButton.Text = "Delete";
            PatientDeleteButton.UseVisualStyleBackColor = false;
            PatientDeleteButton.Click += PatientDeleteButton_Click;
            // 
            // PatientGrid
            // 
            PatientGrid.AllowUserToAddRows = false;
            PatientGrid.AllowUserToDeleteRows = false;
            PatientGrid.AllowUserToResizeColumns = false;
            PatientGrid.AllowUserToResizeRows = false;
            PatientGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PatientGridColumnHeadersCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PatientGridColumnHeadersCellStyle.BackColor = SystemColors.Control;
            PatientGridColumnHeadersCellStyle.Font = new Font("Segoe UI", 9F);
            PatientGridColumnHeadersCellStyle.ForeColor = SystemColors.WindowText;
            PatientGridColumnHeadersCellStyle.SelectionBackColor = SystemColors.Highlight;
            PatientGridColumnHeadersCellStyle.SelectionForeColor = SystemColors.HighlightText;
            PatientGridColumnHeadersCellStyle.WrapMode = DataGridViewTriState.True;
            PatientGrid.ColumnHeadersDefaultCellStyle = PatientGridColumnHeadersCellStyle;
            PatientGridCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PatientGridCellStyle.BackColor = SystemColors.Window;
            PatientGridCellStyle.Font = new Font("Segoe UI", 9F);
            PatientGridCellStyle.ForeColor = SystemColors.ControlText;
            PatientGridCellStyle.NullValue = "-";
            PatientGridCellStyle.SelectionBackColor = Color.DarkOrange;
            PatientGridCellStyle.SelectionForeColor = Color.White;
            PatientGridCellStyle.WrapMode = DataGridViewTriState.False;
            PatientGrid.DefaultCellStyle = PatientGridCellStyle;
            PatientGrid.Location = new Point(456, 27);
            PatientGrid.MultiSelect = false;
            PatientGrid.Name = "PatientGrid";
            PatientGrid.ReadOnly = true;
            PatientGrid.RowHeadersVisible = false;
            PatientGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PatientGrid.Size = new Size(518, 436);
            PatientGrid.TabIndex = 16;
            PatientGrid.SelectionChanged += PatientGrid_SelectionChanged;
            // 
            // PatientShowTestsButton
            // 
            PatientShowTestsButton.BackColor = Color.RosyBrown;
            PatientShowTestsButton.ForeColor = SystemColors.ButtonHighlight;
            PatientShowTestsButton.Location = new Point(170, 226);
            PatientShowTestsButton.Name = "PatientShowTestsButton";
            PatientShowTestsButton.Size = new Size(104, 32);
            PatientShowTestsButton.TabIndex = 17;
            PatientShowTestsButton.Text = "Show Tests";
            PatientShowTestsButton.UseVisualStyleBackColor = false;
            PatientShowTestsButton.Click += PatientShowTestsButton_Click;
            // 
            // PatientReportButton
            // 
            PatientReportButton.BackColor = Color.Lime;
            PatientReportButton.ForeColor = SystemColors.ControlDarkDark;
            PatientReportButton.Location = new Point(361, 346);
            PatientReportButton.Name = "PatientReportButton";
            PatientReportButton.Size = new Size(75, 26);
            PatientReportButton.TabIndex = 28;
            PatientReportButton.Text = "Report";
            PatientReportButton.UseVisualStyleBackColor = false;
            PatientReportButton.Click += PatientReportButton_Click;
            // 
            // TestPerformedOnToDateTimePicker
            // 
            TestPerformedOnToDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TestPerformedOnToDateTimePicker.CalendarForeColor = Color.DarkCyan;
            TestPerformedOnToDateTimePicker.Format = DateTimePickerFormat.Short;
            TestPerformedOnToDateTimePicker.Location = new Point(184, 370);
            TestPerformedOnToDateTimePicker.Name = "TestPerformedOnToDateTimePicker";
            TestPerformedOnToDateTimePicker.Size = new Size(147, 23);
            TestPerformedOnToDateTimePicker.TabIndex = 27;
            // 
            // PatientTestPerformedOnToLabel
            // 
            PatientTestPerformedOnToLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientTestPerformedOnToLabel.AutoSize = true;
            PatientTestPerformedOnToLabel.Location = new Point(76, 376);
            PatientTestPerformedOnToLabel.Name = "PatientTestPerformedOnToLabel";
            PatientTestPerformedOnToLabel.Size = new Size(92, 15);
            PatientTestPerformedOnToLabel.TabIndex = 26;
            PatientTestPerformedOnToLabel.Text = "PerformedOnTo";
            // 
            // TestPerformedOnFromDateTimePicker
            // 
            TestPerformedOnFromDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TestPerformedOnFromDateTimePicker.CalendarForeColor = Color.DarkCyan;
            TestPerformedOnFromDateTimePicker.Format = DateTimePickerFormat.Short;
            TestPerformedOnFromDateTimePicker.Location = new Point(184, 317);
            TestPerformedOnFromDateTimePicker.Name = "TestPerformedOnFromDateTimePicker";
            TestPerformedOnFromDateTimePicker.Size = new Size(147, 23);
            TestPerformedOnFromDateTimePicker.TabIndex = 25;
            TestPerformedOnFromDateTimePicker.Value = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // PatientTestPerformedOnFromLabel
            // 
            PatientTestPerformedOnFromLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PatientTestPerformedOnFromLabel.AutoSize = true;
            PatientTestPerformedOnFromLabel.Location = new Point(76, 323);
            PatientTestPerformedOnFromLabel.Name = "PatientTestPerformedOnFromLabel";
            PatientTestPerformedOnFromLabel.Size = new Size(107, 15);
            PatientTestPerformedOnFromLabel.TabIndex = 24;
            PatientTestPerformedOnFromLabel.Text = "PerformedOnFrom";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 494);
            Controls.Add(PatientReportButton);
            Controls.Add(TestPerformedOnToDateTimePicker);
            Controls.Add(PatientTestPerformedOnToLabel);
            Controls.Add(TestPerformedOnFromDateTimePicker);
            Controls.Add(PatientTestPerformedOnFromLabel);
            Controls.Add(PatientShowTestsButton);
            Controls.Add(PatientGrid);
            Controls.Add(PatientDeleteButton);
            Controls.Add(PatientUpdateButton);
            Controls.Add(PatientCreateButton);
            Controls.Add(PatientGenderComboBox);
            Controls.Add(PatientDateOfBirthDateTimePicker);
            Controls.Add(PatientGenderLabel);
            Controls.Add(PatientDateOfBirthLabel);
            Controls.Add(PatientNameTextBox);
            Controls.Add(PatientNameLabel);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)PatientGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label PatientNameLabel;
        private TextBox PatientNameTextBox;
        private Label PatientDateOfBirthLabel;
        private Label PatientGenderLabel;
        private DateTimePicker PatientDateOfBirthDateTimePicker;
        private ComboBox PatientGenderComboBox;
        private Button PatientCreateButton;
        private Button PatientUpdateButton;
        private Button PatientDeleteButton;
        private DataGridView PatientGrid;
        private Button PatientShowTestsButton;
        private Button PatientReportButton;
        private DateTimePicker TestPerformedOnToDateTimePicker;
        private Label PatientTestPerformedOnToLabel;
        private DateTimePicker TestPerformedOnFromDateTimePicker;
        private Label PatientTestPerformedOnFromLabel;
    }
}
