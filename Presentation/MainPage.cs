using Microsoft.Extensions.DependencyInjection;
using PatientTestManagerWinApp.ApplicationLayer.Dtos.Request.Patients;
using PatientTestManagerWinApp.ApplicationLayer.Dtos.Response.Patients;
using PatientTestManagerWinApp.ApplicationLayer.Services.Abstract;
using PatientTestManagerWinApp.Presentation;
using PatientTestManagerWinApp.Presentation.Helpers;
using System.ComponentModel;
using System.Windows.Forms;

namespace PatientTestManagerWinApp
{
    public partial class MainPage : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IPatientsService _patientsService;
        private int? currentPatientID = null;



        public MainPage(IServiceProvider serviceProvider,
                        IPatientsService patientsService)
        {
            _serviceProvider = serviceProvider;
            _patientsService = patientsService;

            InitializeComponent();
        }

        private async void MainPage_Load(object sender, EventArgs e)
        {
            try
            {
                await ReloadPatientGrid();
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

        private async void PatientCreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidatePatientData() is false)
                {
                    return;
                }

                var patientCreateRequest = new CreatePatientRequest()
                {
                    Name = PatientNameTextBox.Text,
                    DateOfBirth = PatientDateOfBirthDateTimePicker.Value,
                    Gender = PatientGenderComboBox.Text
                };

                var result = await _patientsService.CreateAsync(patientCreateRequest);

                if (result.Success is false)
                {
                    MessageBox.Show(
                        result.Message,
                        MessageBoxCaptions.DatabaseError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                await ReloadPatientGrid();

                MessageBox.Show(
                    "Patient info was added",
                    MessageBoxCaptions.OperationSucceed,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
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


        private async void PatientUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidatePatientData() is false)
                {
                    return;
                }

                if (currentPatientID is null)
                {
                    MessageBox.Show(
                        "There is not a selected patient",
                        MessageBoxCaptions.ValidationError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                var updateRequest = new UpdatePatientRequest()
                {
                    ID = currentPatientID.Value,
                    Name = PatientNameTextBox.Text,
                    DateOfBirth = PatientDateOfBirthDateTimePicker.Value,
                    Gender = PatientGenderComboBox.Text
                };

                var result = await _patientsService.UpdateAsync(updateRequest);

                if (result.Success is false)
                {
                    MessageBox.Show(
                        result.Message,
                        MessageBoxCaptions.DatabaseError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                await ReloadPatientGrid();

                MessageBox.Show(
                    "Patient info was updated",
                    MessageBoxCaptions.OperationSucceed,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
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

        private async void PatientDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidatePatientData() is false)
                {
                    return;
                }

                if (currentPatientID is null)
                {
                    MessageBox.Show(
                        "There is not a selected patient",
                        MessageBoxCaptions.ValidationError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                var result = await _patientsService.DeleteAsync(currentPatientID.Value);

                if (result.Success is false)
                {
                    MessageBox.Show(
                        result.Message,
                        MessageBoxCaptions.DatabaseError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                await ReloadPatientGrid();

                MessageBox.Show(
                    "Patient info was deleted",
                    MessageBoxCaptions.OperationSucceed,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
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

        private void PatientGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (PatientGrid.CurrentRow?.DataBoundItem is PatientDto selectedPatientData)
                {
                    currentPatientID = selectedPatientData.ID;
                    PatientNameTextBox.Text = selectedPatientData.Name;
                    PatientDateOfBirthDateTimePicker.Value = selectedPatientData.DateOfBirth;
                    PatientGenderComboBox.Text = selectedPatientData.Gender;
                }
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


        private void PatientShowTestsButton_Click(object sender, EventArgs e)
        {
            try
            {
                var testPage = _serviceProvider.GetRequiredService<TestPage>();

                testPage.PatientID = currentPatientID!.Value;

                testPage.ShowDialog();
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

        private async void PatientReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                var getReportResponse = await _patientsService.GetReport(new GetReportRequest()
                {
                    PerformedOnFrom = TestPerformedOnFromDateTimePicker.Value.Date,
                    PerformedOnToExcluded = TestPerformedOnToDateTimePicker.Value.Date.AddDays(1)
                });

                if (getReportResponse.Success is true)
                {
                    var reportPage = _serviceProvider.GetRequiredService<ReportPage>();

                    reportPage.ReloadGrid(getReportResponse.Data);

                    reportPage.ShowDialog();
                }
                else
                {
                    MessageBox.Show(
                        "Report can not be retrieved",
                        MessageBoxCaptions.DatabaseError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
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

        private async Task ReloadPatientGrid()
        {
            var patients = await _patientsService.GetAsync(new GetPatientsRequest());
            if (patients.Success is false || patients.Data is null)
            {
                return;
            }

            PatientGrid.DataSource = new List<PatientDto>(patients.Data!);
        }

        private bool ValidatePatientData()
        {
            if (string.IsNullOrEmpty(PatientNameTextBox.Text))
            {
                MessageBox.Show(
                    "Please fill patient name",
                    MessageBoxCaptions.ValidationError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            else if (PatientDateOfBirthDateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show(
                    "Please select a valid Birth Date",
                    MessageBoxCaptions.ValidationError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            else if (PatientGenderComboBox.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a valid gender from the list",
                    MessageBoxCaptions.ValidationError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            return true;
        }
    }
}
