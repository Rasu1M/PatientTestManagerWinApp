using System.Windows.Forms;

namespace PatientTestManagerWinApp.Presentation
{
    partial class ReportPage
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
            DataGridViewCellStyle ReportGridColumnHeadersCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle ReportGridCellStyle = new DataGridViewCellStyle();
            ReportGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ReportGrid).BeginInit();
            SuspendLayout();
            // 
            // ReportGrid
            // 
            ReportGrid.AllowUserToAddRows = false;
            ReportGrid.AllowUserToDeleteRows = false;
            ReportGrid.AllowUserToResizeColumns = false;
            ReportGrid.AllowUserToResizeRows = false;
            ReportGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ReportGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReportGridColumnHeadersCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ReportGridColumnHeadersCellStyle.BackColor = SystemColors.Control;
            ReportGridColumnHeadersCellStyle.Font = new Font("Segoe UI", 9F);
            ReportGridColumnHeadersCellStyle.ForeColor = SystemColors.WindowText;
            ReportGridColumnHeadersCellStyle.SelectionBackColor = SystemColors.Highlight;
            ReportGridColumnHeadersCellStyle.SelectionForeColor = SystemColors.HighlightText;
            ReportGridColumnHeadersCellStyle.WrapMode = DataGridViewTriState.True;
            ReportGrid.ColumnHeadersDefaultCellStyle = ReportGridColumnHeadersCellStyle;
            ReportGridCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ReportGridCellStyle.BackColor = SystemColors.Window;
            ReportGridCellStyle.Font = new Font("Segoe UI", 9F);
            ReportGridCellStyle.ForeColor = SystemColors.ControlText;
            ReportGridCellStyle.NullValue = "-";
            ReportGridCellStyle.SelectionBackColor = Color.DarkOrange;
            ReportGridCellStyle.SelectionForeColor = Color.White;
            ReportGridCellStyle.WrapMode = DataGridViewTriState.False;
            ReportGrid.DefaultCellStyle = ReportGridCellStyle;
            ReportGrid.MultiSelect = false;
            ReportGrid.Name = "ReportGrid";
            ReportGrid.ReadOnly = true;
            ReportGrid.RowHeadersVisible = false;
            ReportGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReportGrid.Location = new Point(0, 0);
            ReportGrid.Name = "ReportGrid";
            ReportGrid.ReadOnly = true;
            ReportGrid.Size = new Size(802, 455);
            ReportGrid.TabIndex = 0;
            // 
            // ReportPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReportGrid);
            Name = "ReportPage";
            Text = "ReportPage";
            ((System.ComponentModel.ISupportInitialize)ReportGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ReportGrid;
    }
}