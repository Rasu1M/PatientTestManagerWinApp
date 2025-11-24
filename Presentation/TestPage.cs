using PatientTestManagerWinApp.ApplicationLayer.Dtos.Request;
using PatientTestManagerWinApp.ApplicationLayer.Dtos.Request.Tests;
using PatientTestManagerWinApp.ApplicationLayer.Dtos.Response.Tests;
using PatientTestManagerWinApp.ApplicationLayer.Services.Abstract;
using PatientTestManagerWinApp.Presentation.Helpers;

namespace PatientTestManagerWinApp.Presentation
{
    public partial class TestPage : Form
    {

        public int PatientID;

        private readonly ITestsService _testsService;
        private int? currentTestID = null;

        public TestPage(ITestsService testsService)
        {
            _testsService = testsService;

            InitializeComponent();
        }

        private async void TestPage_Load(object sender, EventArgs e)
        {
            try
            {
                var Tests = await _testsService.GetAsync(new GetTestsRequest()
                {
                    PatientID = PatientID
                });

                if (Tests.Success is false || Tests.Data is null)
                {
                    return;
                }

                TestGrid.DataSource = new List<TestDto>(Tests.Data!);
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

        private async void TestCreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateTestData() is false)
                {
                    return;
                }

                var TestCreateRequest = new CreateTestRequest()
                {
                    PatientID = PatientID,
                    Name = TestNameTextBox.Text,
                    PerformedOn = TestPerformedOnDateTimePicker.Value,
                    Result = TestResultNumericUpDown.Value,
                    IsWithinThreshold = TestIsWithinThresholdCheckBox.Checked
                };

                var result = await _testsService.CreateAsync(TestCreateRequest);

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

                await ReloadTestGrid();

                MessageBox.Show(
                    "Test info was added",
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

        private async void TestUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateTestData() is false)
                {
                    return;
                }

                if (currentTestID is null)
                {
                    MessageBox.Show(
                        "There is not a selected Test",
                        MessageBoxCaptions.ValidationError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                var updateRequest = new UpdateTestRequest()
                {
                    ID = currentTestID.Value,
                    Name = TestNameTextBox.Text,
                    PerformedOn = TestPerformedOnDateTimePicker.Value,
                    Result = TestResultNumericUpDown.Value,
                    IsWithinThreshold = TestIsWithinThresholdCheckBox.Checked
                };

                var result = await _testsService.UpdateAsync(updateRequest);

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

                await ReloadTestGrid();

                MessageBox.Show(
                    "Test info was updated",
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

        private async void TestDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateTestData() is false)
                {
                    return;
                }

                if (currentTestID is null)
                {
                    MessageBox.Show(
                        "There is not a selected Test",
                        MessageBoxCaptions.ValidationError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                var result = await _testsService.DeleteAsync(currentTestID.Value);

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

                await ReloadTestGrid();

                MessageBox.Show(
                    "Test info was deleted",
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

        private void TestGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (TestGrid.CurrentRow?.DataBoundItem is TestDto selectedTestData)
                {
                    currentTestID = selectedTestData.ID;
                    TestNameTextBox.Text = selectedTestData.Name;
                    TestPerformedOnDateTimePicker.Value = selectedTestData.PerformedOn;
                    TestResultNumericUpDown.Value = selectedTestData.Result;
                    TestIsWithinThresholdCheckBox.Checked = selectedTestData.IsWithinThreshold;
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

        private async void TestFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                await ReloadTestGrid();
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

        private async Task ReloadTestGrid()
        {
            var Tests = await _testsService.GetAsync(new GetTestsRequest()
            {
                PatientID = PatientID,
                PerformedOnFrom = TestPerformedOnFromDateTimePicker.Value.Date,
                PerformedOnToExcluded = TestPerformedOnToDateTimePicker.Value.Date.AddDays(1)
            });

            if (Tests.Success is false || Tests.Data is null)
            {
                return;
            }

            TestGrid.DataSource = new List<TestDto>(Tests.Data!);
        }

        private bool ValidateTestData()
        {
            if (string.IsNullOrEmpty(TestNameTextBox.Text))
            {

                MessageBox.Show(
                    "Please fill test name",
                    MessageBoxCaptions.ValidationError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            else if (TestPerformedOnDateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show(
                    "Please select a valid Birth Date",
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
