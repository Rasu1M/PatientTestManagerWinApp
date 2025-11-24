namespace PatientTestManagerWinApp.Presentation
{
    partial class TestPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            TestNameLabel = new Label();
            TestNameTextBox = new TextBox();
            TestPerformedOnLabel = new Label();
            TestResultLabel = new Label();
            TestPerformedOnDateTimePicker = new DateTimePicker();
            TestCreateButton = new Button();
            TestUpdateButton = new Button();
            TestDeleteButton = new Button();
            TestGrid = new DataGridView();
            TestIsWithinThresholdCheckBox = new CheckBox();
            TestIsWithinThresholdLable = new Label();
            TestPerformedOnFromDateTimePicker = new DateTimePicker();
            TestPerformedOnFromLabel = new Label();
            TestPerformedOnToDateTimePicker = new DateTimePicker();
            TestPerformedOnToLabel = new Label();
            TestFilterButton = new Button();
            TestResultNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)TestGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TestResultNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // TestNameLabel
            // 
            TestNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TestNameLabel.AutoSize = true;
            TestNameLabel.Location = new Point(91, 49);
            TestNameLabel.Name = "TestNameLabel";
            TestNameLabel.Size = new Size(39, 15);
            TestNameLabel.TabIndex = 1;
            TestNameLabel.Text = "Name";
            // 
            // TestNameTextBox
            // 
            TestNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TestNameTextBox.Location = new Point(199, 46);
            TestNameTextBox.Name = "TestNameTextBox";
            TestNameTextBox.Size = new Size(152, 23);
            TestNameTextBox.TabIndex = 2;
            // 
            // TestPerformedOnLabel
            // 
            TestPerformedOnLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TestPerformedOnLabel.AutoSize = true;
            TestPerformedOnLabel.Location = new Point(91, 81);
            TestPerformedOnLabel.Name = "TestPerformedOnLabel";
            TestPerformedOnLabel.Size = new Size(79, 15);
            TestPerformedOnLabel.TabIndex = 3;
            TestPerformedOnLabel.Text = "PerformedOn";
            // 
            // TestResultLabel
            // 
            TestResultLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TestResultLabel.AutoSize = true;
            TestResultLabel.Location = new Point(91, 107);
            TestResultLabel.Name = "TestResultLabel";
            TestResultLabel.Size = new Size(39, 15);
            TestResultLabel.TabIndex = 9;
            TestResultLabel.Text = "Result";
            // 
            // TestPerformedOnDateTimePicker
            // 
            TestPerformedOnDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TestPerformedOnDateTimePicker.CalendarForeColor = Color.DarkCyan;
            TestPerformedOnDateTimePicker.Format = DateTimePickerFormat.Short;
            TestPerformedOnDateTimePicker.Location = new Point(199, 75);
            TestPerformedOnDateTimePicker.Name = "TestPerformedOnDateTimePicker";
            TestPerformedOnDateTimePicker.Size = new Size(147, 23);
            TestPerformedOnDateTimePicker.TabIndex = 11;
            // 
            // TestCreateButton
            // 
            TestCreateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TestCreateButton.BackColor = Color.Cyan;
            TestCreateButton.ForeColor = Color.Green;
            TestCreateButton.Location = new Point(41, 188);
            TestCreateButton.Name = "TestCreateButton";
            TestCreateButton.Size = new Size(104, 25);
            TestCreateButton.TabIndex = 13;
            TestCreateButton.Text = "Create";
            TestCreateButton.UseVisualStyleBackColor = false;
            TestCreateButton.Click += TestCreateButton_Click;
            // 
            // TestUpdateButton
            // 
            TestUpdateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TestUpdateButton.BackColor = Color.Yellow;
            TestUpdateButton.ForeColor = Color.Black;
            TestUpdateButton.Location = new Point(174, 188);
            TestUpdateButton.Name = "TestUpdateButton";
            TestUpdateButton.Size = new Size(104, 25);
            TestUpdateButton.TabIndex = 14;
            TestUpdateButton.Text = "Update";
            TestUpdateButton.UseVisualStyleBackColor = false;
            TestUpdateButton.Click += TestUpdateButton_Click;
            // 
            // TestDeleteButton
            // 
            TestDeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TestDeleteButton.BackColor = Color.Red;
            TestDeleteButton.ForeColor = Color.Black;
            TestDeleteButton.Location = new Point(307, 188);
            TestDeleteButton.Name = "TestDeleteButton";
            TestDeleteButton.Size = new Size(104, 25);
            TestDeleteButton.TabIndex = 15;
            TestDeleteButton.Text = "Delete";
            TestDeleteButton.UseVisualStyleBackColor = false;
            TestDeleteButton.Click += TestDeleteButton_Click;
            // 
            // TestGrid
            // 
            TestGrid.AllowUserToAddRows = false;
            TestGrid.AllowUserToDeleteRows = false;
            TestGrid.AllowUserToResizeColumns = false;
            TestGrid.AllowUserToResizeRows = false;
            TestGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            TestGrid.DefaultCellStyle = dataGridViewCellStyle1;
            TestGrid.Location = new Point(456, 27);
            TestGrid.MultiSelect = false;
            TestGrid.Name = "TestGrid";
            TestGrid.ReadOnly = true;
            TestGrid.RowHeadersVisible = false;
            TestGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TestGrid.Size = new Size(518, 436);
            TestGrid.TabIndex = 16;
            TestGrid.SelectionChanged += TestGrid_SelectionChanged;
            // 
            // TestIsWithinThresholdCheckBox
            // 
            TestIsWithinThresholdCheckBox.AutoSize = true;
            TestIsWithinThresholdCheckBox.Location = new Point(199, 144);
            TestIsWithinThresholdCheckBox.Name = "TestIsWithinThresholdCheckBox";
            TestIsWithinThresholdCheckBox.Size = new Size(15, 14);
            TestIsWithinThresholdCheckBox.TabIndex = 17;
            TestIsWithinThresholdCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestIsWithinThresholdLable
            // 
            TestIsWithinThresholdLable.AutoSize = true;
            TestIsWithinThresholdLable.Location = new Point(91, 145);
            TestIsWithinThresholdLable.Name = "TestIsWithinThresholdLable";
            TestIsWithinThresholdLable.Size = new Size(103, 15);
            TestIsWithinThresholdLable.TabIndex = 18;
            TestIsWithinThresholdLable.Text = "IsWithinThreshold";
            // 
            // TestPerformedOnFromDateTimePicker
            // 
            TestPerformedOnFromDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TestPerformedOnFromDateTimePicker.CalendarForeColor = Color.DarkCyan;
            TestPerformedOnFromDateTimePicker.Format = DateTimePickerFormat.Short;
            TestPerformedOnFromDateTimePicker.Location = new Point(159, 317);
            TestPerformedOnFromDateTimePicker.Name = "TestPerformedOnFromDateTimePicker";
            TestPerformedOnFromDateTimePicker.Size = new Size(147, 23);
            TestPerformedOnFromDateTimePicker.TabIndex = 20;
            TestPerformedOnFromDateTimePicker.Value = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // TestPerformedOnFromLabel
            // 
            TestPerformedOnFromLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TestPerformedOnFromLabel.AutoSize = true;
            TestPerformedOnFromLabel.Location = new Point(51, 323);
            TestPerformedOnFromLabel.Name = "TestPerformedOnFromLabel";
            TestPerformedOnFromLabel.Size = new Size(107, 15);
            TestPerformedOnFromLabel.TabIndex = 19;
            TestPerformedOnFromLabel.Text = "PerformedOnFrom";
            // 
            // TestPerformedOnToDateTimePicker
            // 
            TestPerformedOnToDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TestPerformedOnToDateTimePicker.CalendarForeColor = Color.DarkCyan;
            TestPerformedOnToDateTimePicker.Format = DateTimePickerFormat.Short;
            TestPerformedOnToDateTimePicker.Location = new Point(159, 370);
            TestPerformedOnToDateTimePicker.Name = "TestPerformedOnToDateTimePicker";
            TestPerformedOnToDateTimePicker.Size = new Size(147, 23);
            TestPerformedOnToDateTimePicker.TabIndex = 22;
            // 
            // TestPerformedOnToLabel
            // 
            TestPerformedOnToLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TestPerformedOnToLabel.AutoSize = true;
            TestPerformedOnToLabel.Location = new Point(51, 376);
            TestPerformedOnToLabel.Name = "TestPerformedOnToLabel";
            TestPerformedOnToLabel.Size = new Size(92, 15);
            TestPerformedOnToLabel.TabIndex = 21;
            TestPerformedOnToLabel.Text = "PerformedOnTo";
            // 
            // TestFilterButton
            // 
            TestFilterButton.BackColor = Color.Lime;
            TestFilterButton.ForeColor = SystemColors.ControlDarkDark;
            TestFilterButton.Location = new Point(336, 346);
            TestFilterButton.Name = "TestFilterButton";
            TestFilterButton.Size = new Size(75, 26);
            TestFilterButton.TabIndex = 23;
            TestFilterButton.Text = "Filter";
            TestFilterButton.UseVisualStyleBackColor = false;
            TestFilterButton.Click += TestFilterButton_Click;
            // 
            // TestResultNumericUpDown
            // 
            TestResultNumericUpDown.Location = new Point(199, 108);
            TestResultNumericUpDown.Name = "TestResultNumericUpDown";
            TestResultNumericUpDown.Size = new Size(120, 23);
            TestResultNumericUpDown.TabIndex = 25;
            // 
            // TestPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 494);
            Controls.Add(TestResultNumericUpDown);
            Controls.Add(TestFilterButton);
            Controls.Add(TestPerformedOnToDateTimePicker);
            Controls.Add(TestPerformedOnToLabel);
            Controls.Add(TestPerformedOnFromDateTimePicker);
            Controls.Add(TestPerformedOnFromLabel);
            Controls.Add(TestIsWithinThresholdLable);
            Controls.Add(TestIsWithinThresholdCheckBox);
            Controls.Add(TestGrid);
            Controls.Add(TestDeleteButton);
            Controls.Add(TestUpdateButton);
            Controls.Add(TestCreateButton);
            Controls.Add(TestPerformedOnDateTimePicker);
            Controls.Add(TestResultLabel);
            Controls.Add(TestPerformedOnLabel);
            Controls.Add(TestNameTextBox);
            Controls.Add(TestNameLabel);
            Name = "TestPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            Load += TestPage_Load;
            ((System.ComponentModel.ISupportInitialize)TestGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)TestResultNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TestNameLabel;
        private TextBox TestNameTextBox;
        private Label TestPerformenOnLabel;
        private Label TestResultLabel;
        private DateTimePicker TestPerformedOnDateTimePicker;
        private Button TestCreateButton;
        private Button TestUpdateButton;
        private Button TestDeleteButton;
        private DataGridView TestGrid;
        private CheckBox TestIsWithinThresholdCheckBox;
        private Label TestIsWithinThresholdLable;
        private DateTimePicker TestPerformedOnFromDateTimePicker;
        private Label TestPerformedOnFromLabel;
        private DateTimePicker TestPerformedOnToDateTimePicker;
        private Label TestPerformedOnToLabel;
        private Button TestFilterButton;
        private NumericUpDown TestResultNumericUpDown;
        private Label TestPerformedOnLabel;
    }
}
