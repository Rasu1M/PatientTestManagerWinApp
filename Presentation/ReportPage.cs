using PatientTestManagerWinApp.ApplicationLayer.Dtos.Response.Patients;
using PatientTestManagerWinApp.Presentation.Helpers;

namespace PatientTestManagerWinApp.Presentation
{
    public partial class ReportPage : Form
    {
        public List<ReportDto>? ReportDtoList;
        public ReportPage()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                ex.Message,
                MessageBoxCaptions.UnknownError,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            }
        }

        public void ReloadGrid(List<ReportDto>? ReportDtoList)
        {
            ReportGrid.DataSource = ReportDtoList;
        }
    }
}
