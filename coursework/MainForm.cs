using CourseWork.Source.Entities;
using CourseWork.Source.Services;

using System.Windows.Forms;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data;


namespace CourseWork
{
    public partial class MainForm : Form
    {
        EmployeeService employeeService = null;
        ClientService clientService = null;
        AppointmentService appointmentService = null;
        DataGridViewRow choosenClient = null;
        DataGridViewRow choosenEmployee = null;
        public MainForm()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            clientService = new ClientService();
            appointmentService = new AppointmentService();
            LoadClientDataGrid();
            LoadEmployeeDataGrid();
            LoadAppointmentDataGrid(DateTime.Now);
            FormatDataGrids();
        }
        #region DataGrid Methods
        private void FormatDataGrids()
        {
            var SetAutoSizeToDataGrid = (DataGridView dataGrid) =>
            {
                foreach (DataGridViewColumn column in dataGrid.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };
            SetAutoSizeToDataGrid(ClientDataGrid);
            SetAutoSizeToDataGrid(EmployeeDataGrid);
            SetAutoSizeToDataGrid(AppointmentDataGrid);

            AppointmentDataGrid.Columns[AppointmentService.ColumnMapping["Date"]].DefaultCellStyle.Format = "dd-MM-yyyy";
            AppointmentDataGrid.Columns[AppointmentService.ColumnMapping["Time"]].DefaultCellStyle.Format = "HH:mm";
            ClientDataGrid.Columns[ClientService.ColumnMapping["DateOfBirth"]].DefaultCellStyle.Format = "dd-MM-yyyy";
            EmployeeDataGrid.Columns[EmployeeService.ColumnMapping["DateOfBirth"]].DefaultCellStyle.Format = "dd-MM-yyyy";

            ClientDataGrid.Columns[ClientService.ColumnMapping["PhoneNumber"]].HeaderText = "номер телефона";
            ClientDataGrid.Columns[ClientService.ColumnMapping["FirstName"]].HeaderText = "имя";
            ClientDataGrid.Columns[ClientService.ColumnMapping["LastName"]].HeaderText = "фамилия";
            ClientDataGrid.Columns[ClientService.ColumnMapping["DateOfBirth"]].HeaderText = "дата рождения";

            EmployeeDataGrid.Columns[EmployeeService.ColumnMapping["PhoneNumber"]].HeaderText = "номер телефона";
            EmployeeDataGrid.Columns[EmployeeService.ColumnMapping["FirstName"]].HeaderText = "имя";
            EmployeeDataGrid.Columns[EmployeeService.ColumnMapping["LastName"]].HeaderText = "фамилия";
            EmployeeDataGrid.Columns[EmployeeService.ColumnMapping["DateOfBirth"]].HeaderText = "дата рождения";

            AppointmentDataGrid.Columns[AppointmentService.ColumnMapping["Client"]].HeaderText = "номер клиента";
            AppointmentDataGrid.Columns[AppointmentService.ColumnMapping["Employee"]].HeaderText = "номер мастера";
            AppointmentDataGrid.Columns[AppointmentService.ColumnMapping["Date"]].HeaderText = "дата";
            AppointmentDataGrid.Columns[AppointmentService.ColumnMapping["Time"]].HeaderText = "время";
        }
        private DataGridViewRow GetSelectedRowFromDataGrid(DataGridView dataGrid)
        {
            if (dataGrid.SelectedRows.Count == 0 || dataGrid.SelectedRows is null) return null;
            return dataGrid.SelectedRows[0];
        }
        private void ReplaceRowInDataGrid(DataGridView dataGrid, int rowToReplaceIndex, Dictionary<string, string> columnValuePairs)
        {
            var dataTable = (DataTable)dataGrid.DataSource;
            var row = dataTable.NewRow();
            foreach (KeyValuePair<string, string> cvp in columnValuePairs)
            {
                row[cvp.Key] = cvp.Value;
            }
            dataTable.Rows.RemoveAt(rowToReplaceIndex);
            dataTable.Rows.InsertAt(row, rowToReplaceIndex);
            dataGrid.Refresh();
        }
        private void AddRowToDataGrid(DataGridView dataGrid, Dictionary<string, string> columnValuePairs)
        {
            var dataTable = (DataTable)dataGrid.DataSource;
            var row = dataTable.NewRow();
            foreach (KeyValuePair<string, string> cvp in columnValuePairs)
            {
                row[cvp.Key] = cvp.Value;
            }
            dataTable.Rows.Add(row);
            dataGrid.Refresh();
        }

        private void ShowRowsWithKeyword(DataGridView dataGridView, string keyword)
        {
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridView.DataSource];
            currencyManager.SuspendBinding();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                bool keywordFound = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(keyword))
                    {
                        keywordFound = true;
                        break;
                    }
                }
                row.Visible = keywordFound;
            }
            dataGridView.Refresh();
            currencyManager.ResumeBinding();
        }
        #endregion
        #region Form Methods
        private bool CheckInput(Control input, Func<Regex> RegexGen, Func<string> RequirementsGen)
        {
            if (!RegexGen().IsMatch(input.Text))
            {
                errorProvider.SetError(input, RequirementsGen());
                return false;
            }
            else
            {
                errorProvider.SetError(input, "");
                return true;
            }
        }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab == ClientPage) { }
            if (TabControl.SelectedTab == EmployeePage) { }
            if (TabControl.SelectedTab == AppointmentPage)
            {
                AppointmentDateInput.MaxDate = (DateTime.Now).AddDays(30);
                ChoosenClientLabel.Text = choosenClient != null ?
                    $"клиент: {choosenClient.Cells[ClientService.ColumnMapping["FirstName"]].Value} {choosenClient.Cells[ClientService.ColumnMapping["LastName"]].Value}" :
                    "клиент не выбран";
                ChoosenEmployeeLabel.Text = choosenEmployee != null ?
                    $"мастер: {choosenEmployee.Cells[EmployeeService.ColumnMapping["FirstName"]].Value} {choosenEmployee.Cells[EmployeeService.ColumnMapping["LastName"]].Value}" :
                    "мастер не выбран";
            }
        }
        #endregion
        #region Client Page
        private void DeleteClientBtn_Click(object sender, EventArgs e)
        {
            if (choosenClient == null)
            {
                MessageBox.Show("Выберите клиента для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string phoneNumber = choosenClient.Cells[ClientService.ColumnMapping["PhoneNumber"]].Value.ToString();
            try
            {
                clientService.Delete(phoneNumber);
                ClientDataGrid.Rows.Remove(choosenClient);
                choosenClient = null;
                ClearClientInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddClientBtn_Click(object sender, EventArgs e)
        {
            bool isFirstNameValid = CheckInput(ClientFirstNameInput, ClientService.RegexFirstName, ClientService.GetRequirementsForFirstName);
            bool isLastNameValid = CheckInput(ClientLastNameInput, ClientService.RegexLastName, ClientService.GetRequirementsForLastName);
            bool isPhoneNumberValid = CheckInput(ClientPhoneNumberInput, ClientService.RegexPhoneNumber, ClientService.GetRequirementsForPhoneNumber);

            if (!isFirstNameValid || !isLastNameValid || !isPhoneNumberValid) return;
            Person client = new Person()
            {
                role = Person.Roles.Client,
                firstName = ClientFirstNameInput.Text,
                lastName = ClientLastNameInput.Text,
                phoneNumber = ClientPhoneNumberInput.Text,
                dateOfBirth = ClientDateOfBirthInput.Value
            };
            try
            {
                clientService.Save(client);
                AddRowToDataGrid(ClientDataGrid, clientService.LoadFields(client.phoneNumber));
                ClearClientInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateClientBtn_Click(object sender, EventArgs e)
        {
            if (choosenClient == null)
            {
                MessageBox.Show("Выберите клиента для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isFirstNameValid = CheckInput(ClientFirstNameInput, ClientService.RegexFirstName, ClientService.GetRequirementsForFirstName);
            bool isLastNameValid = CheckInput(ClientLastNameInput, ClientService.RegexLastName, ClientService.GetRequirementsForLastName);

            if (!isFirstNameValid || !isLastNameValid) return;

            string phoneNumber = choosenClient.Cells[ClientService.ColumnMapping["PhoneNumber"]].Value.ToString();
            try
            {
                Person client = clientService.GetByPhoneNumber(phoneNumber);
                client.firstName = ClientFirstNameInput.Text;
                client.lastName = ClientLastNameInput.Text;
                client.dateOfBirth = ClientDateOfBirthInput.Value;
                clientService.Update(client);
                ReplaceRowInDataGrid(ClientDataGrid, choosenClient.Index, clientService.LoadFields(client.phoneNumber));
                ClearClientInputs();
                choosenClient = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DataGridClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearClientInputs();
            choosenClient = GetSelectedRowFromDataGrid(ClientDataGrid);
            ClientPhoneNumberInput.Text = choosenClient.Cells[ClientService.ColumnMapping["PhoneNumber"]].Value.ToString();
            ClientFirstNameInput.Text = choosenClient.Cells[ClientService.ColumnMapping["FirstName"]].Value.ToString();
            ClientLastNameInput.Text = choosenClient.Cells[ClientService.ColumnMapping["LastName"]].Value.ToString();
            ClientDateOfBirthInput.Value = DateTime.Parse(
                    choosenClient.Cells[ClientService.ColumnMapping["DateOfBirth"]].Value.ToString()
                );
            ClientPhoneNumberInput.ReadOnly = true;
        }
        private void ClientSearchBtn_Click(object sender, EventArgs e)
        {
            ShowRowsWithKeyword(ClientDataGrid, ClientSearchInput.Text);
        }
        private void ClearClientInputs()
        {
            ClientFirstNameInput.Text = "";
            ClientLastNameInput.Text = "";
            ClientPhoneNumberInput.Text = "";
            ClientDateOfBirthInput.Value = ClientDateOfBirthInput.MinDate;
            ClientPhoneNumberInput.ReadOnly = false;
            errorProvider.SetError(ClientFirstNameInput, "");
            errorProvider.SetError(ClientLastNameInput, "");
            errorProvider.SetError(ClientPhoneNumberInput, "");
        }
        private void ClearClientInputsBtn_Click(object sender, EventArgs e)
        {
            ClearClientInputs();
        }
        private void DeleteAllClientsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                clientService.DeleteAll();
                LoadClientDataGrid();
                ClearClientInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadClientDataGrid()
        {
            ClientDataGrid.DataSource = clientService.GetDataTableOfAll();
        }
        #endregion

        #region Employee Page
        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (choosenEmployee == null)
            {
                MessageBox.Show("Выберите мастера для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string phoneNumber = choosenEmployee.Cells[EmployeeService.ColumnMapping["PhoneNumber"]].Value.ToString();
            try
            {
                employeeService.Delete(phoneNumber);
                ClientDataGrid.Rows.Remove(choosenEmployee);
                choosenEmployee = null;
                ClearEmployeeInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            bool isFirstNameValid = CheckInput(EmployeeFirstNameInput, ClientService.RegexFirstName, ClientService.GetRequirementsForFirstName);
            bool isLastNameValid = CheckInput(EmployeeLastNameInput, ClientService.RegexLastName, ClientService.GetRequirementsForLastName);
            bool isPhoneNumberValid = CheckInput(EmployeePhoneNumberInput, ClientService.RegexPhoneNumber, ClientService.GetRequirementsForPhoneNumber);

            if (!isFirstNameValid || !isLastNameValid || !isPhoneNumberValid) return;
            Person employee = new Person()
            {
                role = Person.Roles.Employee,
                firstName = EmployeeFirstNameInput.Text,
                lastName = EmployeeLastNameInput.Text,
                phoneNumber = EmployeePhoneNumberInput.Text,
                dateOfBirth = EmployeeDateOfBirthInput.Value
            };
            try
            {
                employeeService.Save(employee);
                AddRowToDataGrid(EmployeeDataGrid, employeeService.LoadFields(employee.phoneNumber));
                ClearEmployeeInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (choosenEmployee == null)
            {
                MessageBox.Show("Выберите мастера для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isFirstNameValid = CheckInput(EmployeeFirstNameInput, EmployeeService.RegexFirstName, EmployeeService.GetRequirementsForFirstName);
            bool isLastNameValid = CheckInput(EmployeeLastNameInput, EmployeeService.RegexLastName, EmployeeService.GetRequirementsForLastName);

            if (!isFirstNameValid || !isLastNameValid) return;

            string phoneNumber = choosenEmployee.Cells[EmployeeService.ColumnMapping["PhoneNumber"]].Value.ToString();
            try
            {
                Person employee = employeeService.GetByPhoneNumber(phoneNumber);
                employee.firstName = EmployeeFirstNameInput.Text;
                employee.lastName = EmployeeLastNameInput.Text;
                employee.dateOfBirth = EmployeeDateOfBirthInput.Value;
                employeeService.Update(employee);
                ReplaceRowInDataGrid(EmployeeDataGrid, choosenEmployee.Index, employeeService.LoadFields(employee.phoneNumber));
                ClearEmployeeInputs();
                choosenEmployee = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EmployeeDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearEmployeeInputs();
            choosenEmployee = GetSelectedRowFromDataGrid(EmployeeDataGrid);
            EmployeePhoneNumberInput.Text = choosenEmployee.Cells[EmployeeService.ColumnMapping["PhoneNumber"]].Value.ToString();
            EmployeeFirstNameInput.Text = choosenEmployee.Cells[EmployeeService.ColumnMapping["FirstName"]].Value.ToString();
            EmployeeLastNameInput.Text = choosenEmployee.Cells[EmployeeService.ColumnMapping["LastName"]].Value.ToString();
            EmployeeDateOfBirthInput.Value = DateTime.Parse(
                    choosenEmployee.Cells[EmployeeService.ColumnMapping["DateOfBirth"]].Value.ToString()
                );
            EmployeePhoneNumberInput.ReadOnly = true;
        }
        private void ClearEmployeeInputs()
        {
            EmployeeFirstNameInput.Text = "";
            EmployeeLastNameInput.Text = "";
            EmployeePhoneNumberInput.Text = "";
            EmployeeDateOfBirthInput.Value = EmployeeDateOfBirthInput.MinDate;
            EmployeePhoneNumberInput.ReadOnly = false;
            errorProvider.SetError(EmployeeFirstNameInput, "");
            errorProvider.SetError(EmployeeLastNameInput, "");
            errorProvider.SetError(EmployeePhoneNumberInput, "");
        }
        private void ClearEmployeeInputsBtn_Click(object sender, EventArgs e)
        {
            ClearEmployeeInputs();
        }
        private void EmployeeSearchBtn_Click(object sender, EventArgs e)
        {
            ShowRowsWithKeyword(EmployeeDataGrid, EmployeeSearchInput.Text);
        }
        private void DeleteAllEmployeesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                employeeService.DeleteAll();
                LoadEmployeeDataGrid();
                ClearEmployeeInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadEmployeeDataGrid()
        {
            EmployeeDataGrid.DataSource = employeeService.GetDataTableOfAll();
        }
        #endregion
        #region Appointment Page
        private void AddAppointmentBtn_Click(object sender, EventArgs e)
        {
            if (choosenClient == null)
            {
                MessageBox.Show("Выберите клиента для записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (choosenEmployee == null)
            {
                MessageBox.Show("Выберите мастера для записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (FreeTimeListBox.Items.Count == 0)
            {
                MessageBox.Show("Выберите свободное время для записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var time = DateTime.Parse(FreeTimeListBox.SelectedItem.ToString());
            var appointment = new Appointment()
            {
                clientPhoneNumber = choosenClient.Cells[ClientService.ColumnMapping["PhoneNumber"]].Value.ToString(),
                employeePhoneNumber = choosenEmployee.Cells[EmployeeService.ColumnMapping["PhoneNumber"]].Value.ToString(),
                dateTime = new DateTime(AppointmentDateInput.Value.Year, AppointmentDateInput.Value.Month, AppointmentDateInput.Value.Day,
                                                            time.Hour, time.Minute, 0)
            };

            try
            {
                appointmentService.Save(appointment);
                FreeTimeListBox.Items.Remove(FreeTimeListBox.SelectedItem);
                LoadAppointmentDataGrid(AppointmentDateInput.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AppointmentDateInput_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = AppointmentDateInput.Value;
            LoadAppointmentDataGrid(date);
            FreeTimeListBox.Items.Clear();
        }

        private void GetAvailableTimeBtn_Click(object sender, EventArgs e)
        {
            if (choosenEmployee == null)
            {
                MessageBox.Show("Выберите мастера для получения свободного времени.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FreeTimeListBox.Items.Clear();
            DateTime date = AppointmentDateInput.Value;
            var freetime = appointmentService.GetAvailableTimeForAppointment(
                    choosenEmployee.Cells[EmployeeService.ColumnMapping["PhoneNumber"]].Value.ToString(),
                    date
                );
            if (freetime.Count == 0)
            {
                MessageBox.Show("У мастера нет свободного времени на эту дату.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var time in freetime)
            {
                FreeTimeListBox.Items.Add(time);
            }

        }
        private void LoadAppointmentDataGrid(DateTime date)
        {
            AppointmentDataGrid.DataSource = appointmentService.GetDataTableForTheDate(date);
        }
        private void DeleteAllAppointmentsBtn_Click(object sender, EventArgs e)
        {
            DateTime date = AppointmentDateInput.Value;
            try
            {
                appointmentService.DeleteAll();
                LoadAppointmentDataGrid(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
