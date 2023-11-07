
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CourseWork
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Size previousClientSize;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ClientPage = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ClientDataGrid = new DataGridView();
            tableLayoutPanel11 = new TableLayoutPanel();
            ClientLastNameInput = new TextBox();
            ClientPhoneNumberInput = new TextBox();
            ClientDateOfBirthInput = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            ClientFirstNameInput = new TextBox();
            label7 = new Label();
            UpdateClientBtn = new Button();
            AddClientBtn = new Button();
            DeleteClientBtn = new Button();
            ClearClientInputsBtn = new Button();
            DeleteAllClientsBtn = new Button();
            tableLayoutPanel12 = new TableLayoutPanel();
            ClientSearchInput = new TextBox();
            ClientLogo = new Label();
            ClientSearchBtn = new Button();
            TabControl = new TabControl();
            EmployeePage = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel13 = new TableLayoutPanel();
            EmployeeDataGrid = new DataGridView();
            tableLayoutPanel14 = new TableLayoutPanel();
            EmployeeLastNameInput = new TextBox();
            EmployeePhoneNumberInput = new TextBox();
            EmployeeDateOfBirthInput = new DateTimePicker();
            label6 = new Label();
            label14 = new Label();
            label15 = new Label();
            EmployeeFirstNameInput = new TextBox();
            label16 = new Label();
            UpdateEmployeeBtn = new Button();
            AddEmployeeBtn = new Button();
            DeleteEmployeeBtn = new Button();
            ClearEmployeeInputsBtn = new Button();
            DeleteAllEmployeesBtn = new Button();
            tableLayoutPanel15 = new TableLayoutPanel();
            EmployeeSearchInput = new TextBox();
            EmployeeLogo = new Label();
            EmployeeSearchBtn = new Button();
            AppointmentPage = new TabPage();
            tableLayoutPanel16 = new TableLayoutPanel();
            tableLayoutPanel17 = new TableLayoutPanel();
            AppointmentLogo = new Label();
            ChoosenClientLabel = new Label();
            ChoosenEmployeeLabel = new Label();
            tableLayoutPanel18 = new TableLayoutPanel();
            AppointmentDataGrid = new DataGridView();
            tableLayoutPanel19 = new TableLayoutPanel();
            DeleteAllAppointmentsBtn = new Button();
            AppointmentDateInput = new DateTimePicker();
            GetAvailableTimeBtn = new Button();
            FreeTimeListBox = new ListBox();
            label1 = new Label();
            AddAppointmentBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox3 = new TextBox();
            label5 = new Label();
            errorProvider = new ErrorProvider(components);
            ClientPage.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClientDataGrid).BeginInit();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            TabControl.SuspendLayout();
            EmployeePage.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGrid).BeginInit();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            AppointmentPage.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            tableLayoutPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AppointmentDataGrid).BeginInit();
            tableLayoutPanel19.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // ClientPage
            // 
            ClientPage.Controls.Add(tableLayoutPanel2);
            ClientPage.Location = new Point(4, 29);
            ClientPage.Name = "ClientPage";
            ClientPage.Size = new Size(1124, 721);
            ClientPage.TabIndex = 3;
            ClientPage.Text = "клиенты";
            ClientPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(255, 245, 251);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel12, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.93481255F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 93.0651855F));
            tableLayoutPanel2.Size = new Size(1124, 721);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel3.Controls.Add(ClientDataGrid, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel11, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 53);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1118, 665);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // ClientDataGrid
            // 
            ClientDataGrid.AllowUserToAddRows = false;
            ClientDataGrid.AllowUserToDeleteRows = false;
            ClientDataGrid.AllowUserToResizeColumns = false;
            ClientDataGrid.AllowUserToResizeRows = false;
            ClientDataGrid.BackgroundColor = Color.AliceBlue;
            ClientDataGrid.BorderStyle = BorderStyle.None;
            ClientDataGrid.ColumnHeadersHeight = 29;
            ClientDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.SlateGray;
            dataGridViewCellStyle1.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = Color.SlateGray;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            ClientDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            ClientDataGrid.Dock = DockStyle.Fill;
            ClientDataGrid.GridColor = Color.Thistle;
            ClientDataGrid.Location = new Point(3, 4);
            ClientDataGrid.Margin = new Padding(3, 4, 3, 4);
            ClientDataGrid.MultiSelect = false;
            ClientDataGrid.Name = "ClientDataGrid";
            ClientDataGrid.ReadOnly = true;
            ClientDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ClientDataGrid.RowHeadersVisible = false;
            ClientDataGrid.RowHeadersWidth = 51;
            ClientDataGrid.RowTemplate.Height = 24;
            ClientDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClientDataGrid.Size = new Size(812, 657);
            ClientDataGrid.TabIndex = 9;
            ClientDataGrid.CellDoubleClick += DataGridClients_CellDoubleClick;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel11.Controls.Add(ClientLastNameInput, 0, 3);
            tableLayoutPanel11.Controls.Add(ClientPhoneNumberInput, 0, 5);
            tableLayoutPanel11.Controls.Add(ClientDateOfBirthInput, 0, 7);
            tableLayoutPanel11.Controls.Add(label9, 0, 6);
            tableLayoutPanel11.Controls.Add(label10, 0, 4);
            tableLayoutPanel11.Controls.Add(label8, 0, 2);
            tableLayoutPanel11.Controls.Add(ClientFirstNameInput, 0, 1);
            tableLayoutPanel11.Controls.Add(label7, 0, 0);
            tableLayoutPanel11.Controls.Add(UpdateClientBtn, 0, 10);
            tableLayoutPanel11.Controls.Add(AddClientBtn, 0, 9);
            tableLayoutPanel11.Controls.Add(DeleteClientBtn, 0, 11);
            tableLayoutPanel11.Controls.Add(ClearClientInputsBtn, 0, 8);
            tableLayoutPanel11.Controls.Add(DeleteAllClientsBtn, 0, 12);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(821, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 14;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 3.49549079F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 5.623181F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 3.191535F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 5.471203F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 3.34351277F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 5.1672473F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 3.64746881F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 5.01526928F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 8.966694F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 7.446915F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 6.839003F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 13.2220745F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 7.58725357F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 21.0925636F));
            tableLayoutPanel11.Size = new Size(294, 659);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // ClientLastNameInput
            // 
            ClientLastNameInput.BackColor = SystemColors.Window;
            ClientLastNameInput.Dock = DockStyle.Left;
            ClientLastNameInput.Location = new Point(3, 85);
            ClientLastNameInput.Margin = new Padding(3, 4, 3, 4);
            ClientLastNameInput.Name = "ClientLastNameInput";
            ClientLastNameInput.Size = new Size(250, 28);
            ClientLastNameInput.TabIndex = 20;
            // 
            // ClientPhoneNumberInput
            // 
            ClientPhoneNumberInput.BackColor = SystemColors.Window;
            ClientPhoneNumberInput.Dock = DockStyle.Left;
            ClientPhoneNumberInput.Location = new Point(3, 143);
            ClientPhoneNumberInput.Margin = new Padding(3, 4, 3, 4);
            ClientPhoneNumberInput.Name = "ClientPhoneNumberInput";
            ClientPhoneNumberInput.Size = new Size(250, 28);
            ClientPhoneNumberInput.TabIndex = 21;
            // 
            // ClientDateOfBirthInput
            // 
            ClientDateOfBirthInput.CalendarForeColor = Color.SlateGray;
            ClientDateOfBirthInput.CalendarTitleForeColor = Color.SlateGray;
            ClientDateOfBirthInput.Dock = DockStyle.Left;
            ClientDateOfBirthInput.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClientDateOfBirthInput.Location = new Point(3, 201);
            ClientDateOfBirthInput.Margin = new Padding(3, 4, 3, 4);
            ClientDateOfBirthInput.MaxDate = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            ClientDateOfBirthInput.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            ClientDateOfBirthInput.Name = "ClientDateOfBirthInput";
            ClientDateOfBirthInput.ShowUpDown = true;
            ClientDateOfBirthInput.Size = new Size(250, 28);
            ClientDateOfBirthInput.TabIndex = 22;
            ClientDateOfBirthInput.Value = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 175);
            label9.Name = "label9";
            label9.Size = new Size(114, 20);
            label9.TabIndex = 26;
            label9.Text = "дата рождения";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(3, 118);
            label10.Name = "label10";
            label10.Size = new Size(127, 20);
            label10.TabIndex = 25;
            label10.Text = "номер телефона";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 60);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 24;
            label8.Text = "фамилия";
            // 
            // ClientFirstNameInput
            // 
            ClientFirstNameInput.BackColor = SystemColors.Window;
            ClientFirstNameInput.Dock = DockStyle.Left;
            ClientFirstNameInput.Location = new Point(3, 27);
            ClientFirstNameInput.Margin = new Padding(3, 4, 3, 4);
            ClientFirstNameInput.Name = "ClientFirstNameInput";
            ClientFirstNameInput.Size = new Size(250, 28);
            ClientFirstNameInput.TabIndex = 19;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.ForeColor = Color.SlateGray;
            label7.Location = new Point(3, 1);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 23;
            label7.Text = "имя";
            // 
            // UpdateClientBtn
            // 
            UpdateClientBtn.Anchor = AnchorStyles.Left;
            UpdateClientBtn.BackColor = Color.Lavender;
            UpdateClientBtn.Location = new Point(3, 343);
            UpdateClientBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateClientBtn.Name = "UpdateClientBtn";
            UpdateClientBtn.Size = new Size(250, 35);
            UpdateClientBtn.TabIndex = 28;
            UpdateClientBtn.Text = "редактировать";
            UpdateClientBtn.UseVisualStyleBackColor = false;
            UpdateClientBtn.Click += UpdateClientBtn_Click;
            // 
            // AddClientBtn
            // 
            AddClientBtn.Anchor = AnchorStyles.Left;
            AddClientBtn.BackColor = Color.Lavender;
            AddClientBtn.Location = new Point(3, 296);
            AddClientBtn.Margin = new Padding(3, 4, 3, 4);
            AddClientBtn.Name = "AddClientBtn";
            AddClientBtn.Size = new Size(250, 35);
            AddClientBtn.TabIndex = 27;
            AddClientBtn.Text = "добавить";
            AddClientBtn.UseVisualStyleBackColor = false;
            AddClientBtn.Click += AddClientBtn_Click;
            // 
            // DeleteClientBtn
            // 
            DeleteClientBtn.Anchor = AnchorStyles.Left;
            DeleteClientBtn.BackColor = Color.Thistle;
            DeleteClientBtn.ForeColor = Color.SlateGray;
            DeleteClientBtn.Location = new Point(3, 409);
            DeleteClientBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteClientBtn.Name = "DeleteClientBtn";
            DeleteClientBtn.Size = new Size(250, 35);
            DeleteClientBtn.TabIndex = 29;
            DeleteClientBtn.Text = "удалить";
            DeleteClientBtn.UseVisualStyleBackColor = false;
            DeleteClientBtn.Click += DeleteClientBtn_Click;
            // 
            // ClearClientInputsBtn
            // 
            ClearClientInputsBtn.BackColor = Color.Thistle;
            ClearClientInputsBtn.Location = new Point(3, 233);
            ClearClientInputsBtn.Name = "ClearClientInputsBtn";
            ClearClientInputsBtn.Size = new Size(250, 32);
            ClearClientInputsBtn.TabIndex = 31;
            ClearClientInputsBtn.Text = "очистить поля";
            ClearClientInputsBtn.UseVisualStyleBackColor = false;
            ClearClientInputsBtn.Click += ClearClientInputsBtn_Click;
            // 
            // DeleteAllClientsBtn
            // 
            DeleteAllClientsBtn.Anchor = AnchorStyles.Left;
            DeleteAllClientsBtn.BackColor = Color.Thistle;
            DeleteAllClientsBtn.ForeColor = Color.SlateGray;
            DeleteAllClientsBtn.Location = new Point(3, 477);
            DeleteAllClientsBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteAllClientsBtn.Name = "DeleteAllClientsBtn";
            DeleteAllClientsBtn.Size = new Size(250, 35);
            DeleteAllClientsBtn.TabIndex = 32;
            DeleteAllClientsBtn.Text = "удалить все";
            DeleteAllClientsBtn.UseVisualStyleBackColor = false;
            DeleteAllClientsBtn.Click += DeleteAllClientsBtn_Click;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel12.ColumnCount = 3;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.67931F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.3206854F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel12.Controls.Add(ClientSearchInput, 0, 0);
            tableLayoutPanel12.Controls.Add(ClientLogo, 2, 0);
            tableLayoutPanel12.Controls.Add(ClientSearchBtn, 1, 0);
            tableLayoutPanel12.Location = new Point(3, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(1118, 44);
            tableLayoutPanel12.TabIndex = 1;
            // 
            // ClientSearchInput
            // 
            ClientSearchInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ClientSearchInput.Font = new Font("Ebrima", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ClientSearchInput.Location = new Point(3, 10);
            ClientSearchInput.Name = "ClientSearchInput";
            ClientSearchInput.Size = new Size(694, 31);
            ClientSearchInput.TabIndex = 27;
            // 
            // ClientLogo
            // 
            ClientLogo.AutoSize = true;
            ClientLogo.Dock = DockStyle.Left;
            ClientLogo.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            ClientLogo.ForeColor = Color.FromArgb(255, 112, 165);
            ClientLogo.Location = new Point(820, 0);
            ClientLogo.Name = "ClientLogo";
            ClientLogo.Size = new Size(171, 44);
            ClientLogo.TabIndex = 2;
            ClientLogo.Text = "MANiCURE";
            ClientLogo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // ClientSearchBtn
            // 
            ClientSearchBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ClientSearchBtn.BackColor = Color.Thistle;
            ClientSearchBtn.Location = new Point(703, 6);
            ClientSearchBtn.Name = "ClientSearchBtn";
            ClientSearchBtn.Size = new Size(111, 35);
            ClientSearchBtn.TabIndex = 28;
            ClientSearchBtn.Text = "поиск";
            ClientSearchBtn.UseVisualStyleBackColor = false;
            ClientSearchBtn.Click += ClientSearchBtn_Click;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(ClientPage);
            TabControl.Controls.Add(EmployeePage);
            TabControl.Controls.Add(AppointmentPage);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Margin = new Padding(3, 4, 3, 4);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1132, 754);
            TabControl.TabIndex = 17;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // EmployeePage
            // 
            EmployeePage.Controls.Add(tableLayoutPanel4);
            EmployeePage.Location = new Point(4, 29);
            EmployeePage.Name = "EmployeePage";
            EmployeePage.Size = new Size(1124, 721);
            EmployeePage.TabIndex = 4;
            EmployeePage.Text = "мастера";
            EmployeePage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(255, 245, 251);
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel13, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel15, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 6.93481255F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 93.0651855F));
            tableLayoutPanel4.Size = new Size(1124, 721);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel13.Controls.Add(EmployeeDataGrid, 0, 0);
            tableLayoutPanel13.Controls.Add(tableLayoutPanel14, 1, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 53);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Size = new Size(1118, 665);
            tableLayoutPanel13.TabIndex = 0;
            // 
            // EmployeeDataGrid
            // 
            EmployeeDataGrid.AllowUserToAddRows = false;
            EmployeeDataGrid.AllowUserToDeleteRows = false;
            EmployeeDataGrid.AllowUserToResizeColumns = false;
            EmployeeDataGrid.AllowUserToResizeRows = false;
            EmployeeDataGrid.BackgroundColor = Color.AliceBlue;
            EmployeeDataGrid.BorderStyle = BorderStyle.None;
            EmployeeDataGrid.ColumnHeadersHeight = 29;
            EmployeeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.SlateGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = Color.SlateGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            EmployeeDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            EmployeeDataGrid.Dock = DockStyle.Fill;
            EmployeeDataGrid.GridColor = Color.Thistle;
            EmployeeDataGrid.Location = new Point(3, 4);
            EmployeeDataGrid.Margin = new Padding(3, 4, 3, 4);
            EmployeeDataGrid.MultiSelect = false;
            EmployeeDataGrid.Name = "EmployeeDataGrid";
            EmployeeDataGrid.ReadOnly = true;
            EmployeeDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            EmployeeDataGrid.RowHeadersVisible = false;
            EmployeeDataGrid.RowHeadersWidth = 51;
            EmployeeDataGrid.RowTemplate.Height = 24;
            EmployeeDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeDataGrid.Size = new Size(812, 657);
            EmployeeDataGrid.TabIndex = 10;
            EmployeeDataGrid.CellDoubleClick += EmployeeDataGrid_CellDoubleClick;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 1;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel14.Controls.Add(EmployeeLastNameInput, 0, 3);
            tableLayoutPanel14.Controls.Add(EmployeePhoneNumberInput, 0, 5);
            tableLayoutPanel14.Controls.Add(EmployeeDateOfBirthInput, 0, 7);
            tableLayoutPanel14.Controls.Add(label6, 0, 6);
            tableLayoutPanel14.Controls.Add(label14, 0, 4);
            tableLayoutPanel14.Controls.Add(label15, 0, 2);
            tableLayoutPanel14.Controls.Add(EmployeeFirstNameInput, 0, 1);
            tableLayoutPanel14.Controls.Add(label16, 0, 0);
            tableLayoutPanel14.Controls.Add(UpdateEmployeeBtn, 0, 10);
            tableLayoutPanel14.Controls.Add(AddEmployeeBtn, 0, 9);
            tableLayoutPanel14.Controls.Add(DeleteEmployeeBtn, 0, 11);
            tableLayoutPanel14.Controls.Add(ClearEmployeeInputsBtn, 0, 8);
            tableLayoutPanel14.Controls.Add(DeleteAllEmployeesBtn, 0, 12);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(821, 3);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 14;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 3.49549079F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 5.623181F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 3.191535F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 5.471203F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 3.34351277F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 5.1672473F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 3.64746881F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 5.01526928F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 8.966694F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 7.446915F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 6.839003F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 13.2220745F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 7.58725357F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 21.0925636F));
            tableLayoutPanel14.Size = new Size(294, 659);
            tableLayoutPanel14.TabIndex = 0;
            // 
            // EmployeeLastNameInput
            // 
            EmployeeLastNameInput.Dock = DockStyle.Left;
            EmployeeLastNameInput.Location = new Point(3, 85);
            EmployeeLastNameInput.Margin = new Padding(3, 4, 3, 4);
            EmployeeLastNameInput.Name = "EmployeeLastNameInput";
            EmployeeLastNameInput.Size = new Size(250, 28);
            EmployeeLastNameInput.TabIndex = 20;
            // 
            // EmployeePhoneNumberInput
            // 
            EmployeePhoneNumberInput.Dock = DockStyle.Left;
            EmployeePhoneNumberInput.Location = new Point(3, 143);
            EmployeePhoneNumberInput.Margin = new Padding(3, 4, 3, 4);
            EmployeePhoneNumberInput.Name = "EmployeePhoneNumberInput";
            EmployeePhoneNumberInput.Size = new Size(250, 28);
            EmployeePhoneNumberInput.TabIndex = 21;
            // 
            // EmployeeDateOfBirthInput
            // 
            EmployeeDateOfBirthInput.CalendarForeColor = Color.SlateGray;
            EmployeeDateOfBirthInput.CalendarTitleForeColor = Color.SlateGray;
            EmployeeDateOfBirthInput.Dock = DockStyle.Left;
            EmployeeDateOfBirthInput.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeDateOfBirthInput.Location = new Point(3, 201);
            EmployeeDateOfBirthInput.Margin = new Padding(3, 4, 3, 4);
            EmployeeDateOfBirthInput.MaxDate = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            EmployeeDateOfBirthInput.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            EmployeeDateOfBirthInput.Name = "EmployeeDateOfBirthInput";
            EmployeeDateOfBirthInput.ShowUpDown = true;
            EmployeeDateOfBirthInput.Size = new Size(250, 28);
            EmployeeDateOfBirthInput.TabIndex = 22;
            EmployeeDateOfBirthInput.Value = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 175);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 26;
            label6.Text = "дата рождения";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Location = new Point(3, 118);
            label14.Name = "label14";
            label14.Size = new Size(127, 20);
            label14.TabIndex = 25;
            label14.Text = "номер телефона";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new Point(3, 60);
            label15.Name = "label15";
            label15.Size = new Size(74, 20);
            label15.TabIndex = 24;
            label15.Text = "фамилия";
            // 
            // EmployeeFirstNameInput
            // 
            EmployeeFirstNameInput.BackColor = SystemColors.Window;
            EmployeeFirstNameInput.Dock = DockStyle.Left;
            EmployeeFirstNameInput.Location = new Point(3, 27);
            EmployeeFirstNameInput.Margin = new Padding(3, 4, 3, 4);
            EmployeeFirstNameInput.Name = "EmployeeFirstNameInput";
            EmployeeFirstNameInput.Size = new Size(250, 28);
            EmployeeFirstNameInput.TabIndex = 19;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Location = new Point(3, 1);
            label16.Name = "label16";
            label16.Size = new Size(36, 20);
            label16.TabIndex = 23;
            label16.Text = "имя";
            // 
            // UpdateEmployeeBtn
            // 
            UpdateEmployeeBtn.Anchor = AnchorStyles.Left;
            UpdateEmployeeBtn.BackColor = Color.Lavender;
            UpdateEmployeeBtn.Location = new Point(3, 343);
            UpdateEmployeeBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateEmployeeBtn.Name = "UpdateEmployeeBtn";
            UpdateEmployeeBtn.Size = new Size(250, 35);
            UpdateEmployeeBtn.TabIndex = 28;
            UpdateEmployeeBtn.Text = "редактировать";
            UpdateEmployeeBtn.UseVisualStyleBackColor = false;
            UpdateEmployeeBtn.Click += UpdateEmployeeBtn_Click;
            // 
            // AddEmployeeBtn
            // 
            AddEmployeeBtn.Anchor = AnchorStyles.Left;
            AddEmployeeBtn.BackColor = Color.Lavender;
            AddEmployeeBtn.Location = new Point(3, 296);
            AddEmployeeBtn.Margin = new Padding(3, 4, 3, 4);
            AddEmployeeBtn.Name = "AddEmployeeBtn";
            AddEmployeeBtn.Size = new Size(250, 35);
            AddEmployeeBtn.TabIndex = 27;
            AddEmployeeBtn.Text = "добавить";
            AddEmployeeBtn.UseVisualStyleBackColor = false;
            AddEmployeeBtn.Click += AddEmployeeBtn_Click;
            // 
            // DeleteEmployeeBtn
            // 
            DeleteEmployeeBtn.Anchor = AnchorStyles.Left;
            DeleteEmployeeBtn.BackColor = Color.Thistle;
            DeleteEmployeeBtn.ForeColor = Color.SlateGray;
            DeleteEmployeeBtn.Location = new Point(3, 409);
            DeleteEmployeeBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteEmployeeBtn.Name = "DeleteEmployeeBtn";
            DeleteEmployeeBtn.Size = new Size(250, 35);
            DeleteEmployeeBtn.TabIndex = 29;
            DeleteEmployeeBtn.Text = "удалить";
            DeleteEmployeeBtn.UseVisualStyleBackColor = false;
            DeleteEmployeeBtn.Click += DeleteEmployeeBtn_Click;
            // 
            // ClearEmployeeInputsBtn
            // 
            ClearEmployeeInputsBtn.BackColor = Color.Thistle;
            ClearEmployeeInputsBtn.Location = new Point(3, 233);
            ClearEmployeeInputsBtn.Name = "ClearEmployeeInputsBtn";
            ClearEmployeeInputsBtn.Size = new Size(250, 32);
            ClearEmployeeInputsBtn.TabIndex = 30;
            ClearEmployeeInputsBtn.Text = "очистить поля";
            ClearEmployeeInputsBtn.UseVisualStyleBackColor = false;
            ClearEmployeeInputsBtn.Click += ClearEmployeeInputsBtn_Click;
            // 
            // DeleteAllEmployeesBtn
            // 
            DeleteAllEmployeesBtn.Anchor = AnchorStyles.Left;
            DeleteAllEmployeesBtn.BackColor = Color.Thistle;
            DeleteAllEmployeesBtn.ForeColor = Color.SlateGray;
            DeleteAllEmployeesBtn.Location = new Point(3, 477);
            DeleteAllEmployeesBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteAllEmployeesBtn.Name = "DeleteAllEmployeesBtn";
            DeleteAllEmployeesBtn.Size = new Size(250, 35);
            DeleteAllEmployeesBtn.TabIndex = 33;
            DeleteAllEmployeesBtn.Text = "удалить все";
            DeleteAllEmployeesBtn.UseVisualStyleBackColor = false;
            DeleteAllEmployeesBtn.Click += DeleteAllEmployeesBtn_Click;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel15.ColumnCount = 3;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.67931F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.3206854F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel15.Controls.Add(EmployeeSearchInput, 0, 0);
            tableLayoutPanel15.Controls.Add(EmployeeLogo, 2, 0);
            tableLayoutPanel15.Controls.Add(EmployeeSearchBtn, 1, 0);
            tableLayoutPanel15.Location = new Point(3, 3);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 1;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel15.Size = new Size(1118, 44);
            tableLayoutPanel15.TabIndex = 1;
            // 
            // EmployeeSearchInput
            // 
            EmployeeSearchInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmployeeSearchInput.Font = new Font("Ebrima", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeSearchInput.Location = new Point(3, 10);
            EmployeeSearchInput.Name = "EmployeeSearchInput";
            EmployeeSearchInput.Size = new Size(694, 31);
            EmployeeSearchInput.TabIndex = 27;
            // 
            // EmployeeLogo
            // 
            EmployeeLogo.AutoSize = true;
            EmployeeLogo.Dock = DockStyle.Left;
            EmployeeLogo.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeLogo.ForeColor = Color.FromArgb(255, 112, 165);
            EmployeeLogo.Location = new Point(820, 0);
            EmployeeLogo.Name = "EmployeeLogo";
            EmployeeLogo.Size = new Size(171, 44);
            EmployeeLogo.TabIndex = 2;
            EmployeeLogo.Text = "MANiCURE";
            EmployeeLogo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // EmployeeSearchBtn
            // 
            EmployeeSearchBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmployeeSearchBtn.BackColor = Color.Thistle;
            EmployeeSearchBtn.Location = new Point(703, 6);
            EmployeeSearchBtn.Name = "EmployeeSearchBtn";
            EmployeeSearchBtn.Size = new Size(111, 35);
            EmployeeSearchBtn.TabIndex = 28;
            EmployeeSearchBtn.Text = "поиск";
            EmployeeSearchBtn.UseVisualStyleBackColor = false;
            EmployeeSearchBtn.Click += EmployeeSearchBtn_Click;
            // 
            // AppointmentPage
            // 
            AppointmentPage.Controls.Add(tableLayoutPanel16);
            AppointmentPage.Location = new Point(4, 29);
            AppointmentPage.Name = "AppointmentPage";
            AppointmentPage.Size = new Size(1124, 721);
            AppointmentPage.TabIndex = 5;
            AppointmentPage.Text = "записи";
            AppointmentPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.BackColor = Color.FromArgb(255, 245, 251);
            tableLayoutPanel16.ColumnCount = 1;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.Controls.Add(tableLayoutPanel17, 0, 0);
            tableLayoutPanel16.Controls.Add(tableLayoutPanel18, 0, 1);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(0, 0);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 2;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 6.93481255F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 93.0651855F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel16.Size = new Size(1124, 721);
            tableLayoutPanel16.TabIndex = 0;
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.ColumnCount = 3;
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel17.Controls.Add(AppointmentLogo, 0, 0);
            tableLayoutPanel17.Controls.Add(ChoosenClientLabel, 0, 0);
            tableLayoutPanel17.Controls.Add(ChoosenEmployeeLabel, 0, 0);
            tableLayoutPanel17.Dock = DockStyle.Fill;
            tableLayoutPanel17.Location = new Point(3, 3);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 1;
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel17.Size = new Size(1118, 44);
            tableLayoutPanel17.TabIndex = 0;
            // 
            // AppointmentLogo
            // 
            AppointmentLogo.AutoSize = true;
            AppointmentLogo.Dock = DockStyle.Left;
            AppointmentLogo.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            AppointmentLogo.ForeColor = Color.FromArgb(255, 112, 165);
            AppointmentLogo.Location = new Point(821, 0);
            AppointmentLogo.Name = "AppointmentLogo";
            AppointmentLogo.Size = new Size(171, 44);
            AppointmentLogo.TabIndex = 23;
            AppointmentLogo.Text = "MANiCURE";
            AppointmentLogo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // ChoosenClientLabel
            // 
            ChoosenClientLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ChoosenClientLabel.AutoSize = true;
            ChoosenClientLabel.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ChoosenClientLabel.Location = new Point(412, 21);
            ChoosenClientLabel.Name = "ChoosenClientLabel";
            ChoosenClientLabel.Size = new Size(59, 23);
            ChoosenClientLabel.TabIndex = 22;
            ChoosenClientLabel.Text = "label4";
            // 
            // ChoosenEmployeeLabel
            // 
            ChoosenEmployeeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ChoosenEmployeeLabel.AutoSize = true;
            ChoosenEmployeeLabel.Font = new Font("Ebrima", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ChoosenEmployeeLabel.Location = new Point(3, 21);
            ChoosenEmployeeLabel.Name = "ChoosenEmployeeLabel";
            ChoosenEmployeeLabel.Size = new Size(59, 23);
            ChoosenEmployeeLabel.TabIndex = 21;
            ChoosenEmployeeLabel.Text = "label4";
            // 
            // tableLayoutPanel18
            // 
            tableLayoutPanel18.ColumnCount = 2;
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel18.Controls.Add(AppointmentDataGrid, 0, 0);
            tableLayoutPanel18.Controls.Add(tableLayoutPanel19, 1, 0);
            tableLayoutPanel18.Dock = DockStyle.Fill;
            tableLayoutPanel18.Location = new Point(3, 53);
            tableLayoutPanel18.Name = "tableLayoutPanel18";
            tableLayoutPanel18.RowCount = 1;
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel18.Size = new Size(1118, 665);
            tableLayoutPanel18.TabIndex = 1;
            // 
            // AppointmentDataGrid
            // 
            AppointmentDataGrid.AllowUserToAddRows = false;
            AppointmentDataGrid.AllowUserToDeleteRows = false;
            AppointmentDataGrid.AllowUserToResizeColumns = false;
            AppointmentDataGrid.AllowUserToResizeRows = false;
            AppointmentDataGrid.BackgroundColor = Color.AliceBlue;
            AppointmentDataGrid.BorderStyle = BorderStyle.None;
            AppointmentDataGrid.ColumnHeadersHeight = 29;
            AppointmentDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.SlateGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = Color.SlateGray;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AppointmentDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            AppointmentDataGrid.Dock = DockStyle.Fill;
            AppointmentDataGrid.GridColor = Color.Thistle;
            AppointmentDataGrid.Location = new Point(3, 4);
            AppointmentDataGrid.Margin = new Padding(3, 4, 3, 4);
            AppointmentDataGrid.MultiSelect = false;
            AppointmentDataGrid.Name = "AppointmentDataGrid";
            AppointmentDataGrid.ReadOnly = true;
            AppointmentDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            AppointmentDataGrid.RowHeadersVisible = false;
            AppointmentDataGrid.RowHeadersWidth = 51;
            AppointmentDataGrid.RowTemplate.Height = 24;
            AppointmentDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppointmentDataGrid.Size = new Size(812, 657);
            AppointmentDataGrid.TabIndex = 10;
            // 
            // tableLayoutPanel19
            // 
            tableLayoutPanel19.ColumnCount = 1;
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel19.Controls.Add(DeleteAllAppointmentsBtn, 0, 5);
            tableLayoutPanel19.Controls.Add(AppointmentDateInput, 0, 0);
            tableLayoutPanel19.Controls.Add(GetAvailableTimeBtn, 0, 1);
            tableLayoutPanel19.Controls.Add(FreeTimeListBox, 0, 3);
            tableLayoutPanel19.Controls.Add(label1, 0, 2);
            tableLayoutPanel19.Controls.Add(AddAppointmentBtn, 0, 4);
            tableLayoutPanel19.Dock = DockStyle.Fill;
            tableLayoutPanel19.Location = new Point(821, 3);
            tableLayoutPanel19.Name = "tableLayoutPanel19";
            tableLayoutPanel19.RowCount = 6;
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 6.646655F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 7.099836F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 3.1722672F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 66.46655F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 8.650787F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 7.96390152F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel19.Size = new Size(294, 659);
            tableLayoutPanel19.TabIndex = 0;
            // 
            // DeleteAllAppointmentsBtn
            // 
            DeleteAllAppointmentsBtn.Anchor = AnchorStyles.Left;
            DeleteAllAppointmentsBtn.BackColor = Color.Thistle;
            DeleteAllAppointmentsBtn.ForeColor = Color.SlateGray;
            DeleteAllAppointmentsBtn.Location = new Point(3, 614);
            DeleteAllAppointmentsBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteAllAppointmentsBtn.Name = "DeleteAllAppointmentsBtn";
            DeleteAllAppointmentsBtn.Size = new Size(250, 35);
            DeleteAllAppointmentsBtn.TabIndex = 33;
            DeleteAllAppointmentsBtn.Text = "удалить все";
            DeleteAllAppointmentsBtn.UseVisualStyleBackColor = false;
            DeleteAllAppointmentsBtn.Click += DeleteAllAppointmentsBtn_Click;
            // 
            // AppointmentDateInput
            // 
            AppointmentDateInput.CalendarForeColor = Color.SlateGray;
            AppointmentDateInput.Dock = DockStyle.Left;
            AppointmentDateInput.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AppointmentDateInput.Location = new Point(3, 4);
            AppointmentDateInput.Margin = new Padding(3, 4, 3, 4);
            AppointmentDateInput.Name = "AppointmentDateInput";
            AppointmentDateInput.ShowUpDown = true;
            AppointmentDateInput.Size = new Size(250, 28);
            AppointmentDateInput.TabIndex = 24;
            AppointmentDateInput.ValueChanged += AppointmentDateInput_ValueChanged;
            // 
            // GetAvailableTimeBtn
            // 
            GetAvailableTimeBtn.BackColor = Color.Lavender;
            GetAvailableTimeBtn.Location = new Point(3, 47);
            GetAvailableTimeBtn.Margin = new Padding(3, 4, 3, 4);
            GetAvailableTimeBtn.Name = "GetAvailableTimeBtn";
            GetAvailableTimeBtn.Size = new Size(250, 35);
            GetAvailableTimeBtn.TabIndex = 32;
            GetAvailableTimeBtn.Text = "получить свободное время";
            GetAvailableTimeBtn.UseVisualStyleBackColor = false;
            GetAvailableTimeBtn.Click += GetAvailableTimeBtn_Click;
            // 
            // FreeTimeListBox
            // 
            FreeTimeListBox.Dock = DockStyle.Left;
            FreeTimeListBox.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FreeTimeListBox.ForeColor = Color.SlateGray;
            FreeTimeListBox.FormattingEnabled = true;
            FreeTimeListBox.ItemHeight = 28;
            FreeTimeListBox.Location = new Point(3, 113);
            FreeTimeListBox.Margin = new Padding(3, 4, 3, 4);
            FreeTimeListBox.Name = "FreeTimeListBox";
            FreeTimeListBox.Size = new Size(250, 430);
            FreeTimeListBox.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 89);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 25;
            label1.Text = "свободное время на дату :";
            // 
            // AddAppointmentBtn
            // 
            AddAppointmentBtn.BackColor = Color.Lavender;
            AddAppointmentBtn.Location = new Point(3, 551);
            AddAppointmentBtn.Margin = new Padding(3, 4, 3, 4);
            AddAppointmentBtn.Name = "AddAppointmentBtn";
            AddAppointmentBtn.Size = new Size(250, 35);
            AddAppointmentBtn.TabIndex = 31;
            AddAppointmentBtn.Text = "добавить";
            AddAppointmentBtn.UseVisualStyleBackColor = false;
            AddAppointmentBtn.Click += AddAppointmentBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.67931F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.3206854F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.Controls.Add(textBox3, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Ebrima", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(3, 66);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1, 31);
            textBox3.TabIndex = 27;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 112, 165);
            label5.Location = new Point(-96, 27);
            label5.Name = "label5";
            label5.Size = new Size(171, 45);
            label5.TabIndex = 2;
            label5.Text = "MANiCURE";
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 245, 251);
            ClientSize = new Size(1132, 754);
            Controls.Add(TabControl);
            Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.SlateGray;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(650, 801);
            Name = "MainForm";
            Text = "MANiCURE";
            ClientPage.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ClientDataGrid).EndInit();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            TabControl.ResumeLayout(false);
            EmployeePage.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGrid).EndInit();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            AppointmentPage.ResumeLayout(false);
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel17.PerformLayout();
            tableLayoutPanel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AppointmentDataGrid).EndInit();
            tableLayoutPanel19.ResumeLayout(false);
            tableLayoutPanel19.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // this.BackColor = Color.FromArgb(255, 255, 192, 203);
            //LinearGradientBrush gradientBrush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(255,255, 192,203), Color.FromArgb(255,255,105,180),
            ///  LinearGradientMode.Vertical);
            //e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);  
        }

        #endregion
        private TabControl TabControl;
        private TabPage EmployeesPage;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label2;
        private TextBox EmployeePhoneNumberInput;
        private DateTimePicker DateOfBirthEmployees;
        private TextBox FirstNameEmployeeInput;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox LastNameEmployees;
        private Button DeleteEmployeeBtn;
        private Button AddEmployeeBtn;
        private Button EditEmployeeBtn;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private TabPage AppointmentPage;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel8;
        private TabPage ClientPage;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel11;
        private TextBox ClientLastNameInput;
        private TextBox ClientPhoneNumberInput;
        private DateTimePicker ClientDateOfBirthInput;
        private Label label9;
        private Label label10;
        private Label label8;
        private TextBox ClientFirstNameInput;
        private Label label7;
        private Button UpdateClientBtn;
        private Button AddClientBtn;
        private Button DeleteClientBtn;
        private TableLayoutPanel tableLayoutPanel12;
        private TextBox ClientSearchInput;
        private Label ClientLogo;
        private Button ClientSearchBtn;
        private TabPage EmployeePage;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel13;
        private TableLayoutPanel tableLayoutPanel14;
        private TextBox EmployeeLastNameInput;
        private TextBox textBox5;
        private DateTimePicker EmployeeDateOfBirthInput;
        private Label label6;
        private Label label14;
        private Label label15;
        private TextBox EmployeeFirstNameInput;
        private Label label16;
        private Button UpdateEmployeeBtn;
        private Button button3;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel15;
        private TextBox EmployeeSearchInput;
        private Label EmployeeLogo;
        private Button EmployeeSearchBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox3;
        private Label label5;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel16;
        private TableLayoutPanel tableLayoutPanel17;
        private TableLayoutPanel tableLayoutPanel18;
        private TableLayoutPanel tableLayoutPanel19;
        private Label AppointmentLogo;
        private Label ChoosenClientLabel;
        private Label ChoosenEmployeeLabel;
        private DateTimePicker AppointmentDateInput;
        private ListBox FreeTimeListBox;
        private Label label1;
        private Button GetAvailableTimeBtn;
        private Button AddAppointmentBtn;
        private Button ClearClientInputsBtn;
        private Button ClearEmployeeInputsBtn;
        private ErrorProvider errorProvider;
        private Button DeleteAllClientsBtn;
        private Button DeleteAllEmployeesBtn;
        private Button DeleteAllAppointmentsBtn;
        private DataGridView ClientDataGrid;
        private DataGridView EmployeeDataGrid;
        private DataGridView AppointmentDataGrid;
    }
}


