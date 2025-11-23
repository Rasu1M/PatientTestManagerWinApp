using PatientTestManagerWinApp.ApplicationLayer.Dtos.Request.Patients;
using PatientTestManagerWinApp.ApplicationLayer.Dtos.Response.Patients;
using PatientTestManagerWinApp.ApplicationLayer.Services.Abstract;
using PatientTestManagerWinApp.Presentation.Helpers;
using System.ComponentModel;

namespace PatientTestManagerWinApp
{
    public partial class MainPage : Form
    {

        private readonly IPatientsService _patientsService;
        private int? currentPatientID = null;

        public MainPage(IPatientsService patientsService)
        {
            _patientsService = patientsService;

            InitializeComponent();
        }

        private async void MainPage_Load(object sender, EventArgs e)
        {
            await ReloadPatientGrid();
        }

        private async void PatientCreateButton_Click(object sender, EventArgs e)
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

            MessageBox.Show(
                "Patient info was added",
                MessageBoxCaptions.OperationSucceed,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            await ReloadPatientGrid();
        }

        private bool ValidatePatientData()
        {
            if (PatientDateOfBirthDateTimePicker.Value > DateTime.Now)
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
                    MessageBoxCaptions.OperationSucceed,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            return true;
        }
        private async Task ReloadPatientGrid()
        {
            var patients = await _patientsService.GetAsync(new GetPatientsRequest());
            if (patients.Success is false || patients.Data is null)
            {
                return;
            }

            PatientsGrid.DataSource = new BindingList<PatientDto>(patients.Data!);
        }

        private async void PatientUpdateButton_Click(object sender, EventArgs e)
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

            MessageBox.Show(
                "Patient info was updated",
                MessageBoxCaptions.OperationSucceed,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            await ReloadPatientGrid();
        }

        private async void PatientDeleteButton_Click(object sender, EventArgs e)
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

            MessageBox.Show(
                "Patient info was deleted",
                MessageBoxCaptions.OperationSucceed,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            await ReloadPatientGrid();
        }

        private void PatientsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (PatientsGrid.CurrentRow?.DataBoundItem is PatientDto selectedPatientData)
            {
                currentPatientID = selectedPatientData.ID;
                PatientNameTextBox.Text = selectedPatientData.Name;
                PatientDateOfBirthDateTimePicker.Value = selectedPatientData.DateOfBirth;
                PatientGenderComboBox.Text = selectedPatientData.Gender;
            }
        }
    }
}
