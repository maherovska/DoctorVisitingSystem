namespace DoctorVisitingSystem.DesktopUI.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gb_Doctor = new System.Windows.Forms.GroupBox();
            this.lbl_ChooseDoctor = new System.Windows.Forms.Label();
            this.cb_ChooseDoctor = new System.Windows.Forms.ComboBox();
            this.tc_DoctorFulInfo = new System.Windows.Forms.TabControl();
            this.tp_DoctorInformation = new System.Windows.Forms.TabPage();
            this.lbl_DoctorAppointment = new System.Windows.Forms.Label();
            this.lbl_DoctorLunchBreak = new System.Windows.Forms.Label();
            this.lbl_DoctorWorkingHour = new System.Windows.Forms.Label();
            this.lbl_DoctorName = new System.Windows.Forms.Label();
            this.lbl_DocAppointment = new System.Windows.Forms.Label();
            this.lbl_DocLunchBreak = new System.Windows.Forms.Label();
            this.lbl_DocWorkingHour = new System.Windows.Forms.Label();
            this.lbl_DocName = new System.Windows.Forms.Label();
            this.tp_DoctorPatients = new System.Windows.Forms.TabPage();
            this.tb_DoctorPatientsCount = new System.Windows.Forms.TextBox();
            this.lbl_DoctorPatientsDescription = new System.Windows.Forms.Label();
            this.lbl_DoctorPatientsCount = new System.Windows.Forms.Label();
            this.dgv_DoctorPatients = new System.Windows.Forms.DataGridView();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_DoctorAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_DoctorChooseDate = new System.Windows.Forms.Label();
            this.tp_DoctorRating = new System.Windows.Forms.TabPage();
            this.dtp_DoctorRatingToDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_DoctorRatingFromDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_DoctorRatingPeriod = new System.Windows.Forms.Label();
            this.lbl_DoctorRatingToDate = new System.Windows.Forms.Label();
            this.lbl_DoctorRatingFromDate = new System.Windows.Forms.Label();
            this.lbl_DoctorRating = new System.Windows.Forms.Label();
            this.dgv_DoctorRating = new System.Windows.Forms.DataGridView();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Appointment = new System.Windows.Forms.GroupBox();
            this.btn_AppointmentNewAppointment = new System.Windows.Forms.Button();
            this.dgv_AppointmentAvailableDoctors = new System.Windows.Forms.DataGridView();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_AppointmentChooseTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_AppointmentChooseDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_AppointmentChooseTime = new System.Windows.Forms.Label();
            this.lbl_AppointmentChooseDate = new System.Windows.Forms.Label();
            this.lbl_AppointmentAvailableDoctor = new System.Windows.Forms.Label();
            this.tc_Main = new System.Windows.Forms.TabControl();
            this.tp_Home = new System.Windows.Forms.TabPage();
            this.tp_Appointment = new System.Windows.Forms.TabPage();
            this.tp_DoctorInfo = new System.Windows.Forms.TabPage();
            this.pb_PatientInfo = new System.Windows.Forms.TabPage();
            this.gb_Patient = new System.Windows.Forms.GroupBox();
            this.btn_PatientAppointment = new System.Windows.Forms.Button();
            this.lbl_PatientAddress = new System.Windows.Forms.Label();
            this.lbl_PatientDateOfBirth = new System.Windows.Forms.Label();
            this.lbl_PatientFirstName = new System.Windows.Forms.Label();
            this.lbl_PatientLastName = new System.Windows.Forms.Label();
            this.dgv_PatientAppointment = new System.Windows.Forms.DataGridView();
            this.lbl_PatientSelectPatient = new System.Windows.Forms.Label();
            this.tb_TypePatientLastName = new System.Windows.Forms.TextBox();
            this.lbl_TypePatientLastName = new System.Windows.Forms.Label();
            this.dgv_PatientPatients = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pb_Hospital = new System.Windows.Forms.PictureBox();
            this.gb_Doctor.SuspendLayout();
            this.tc_DoctorFulInfo.SuspendLayout();
            this.tp_DoctorInformation.SuspendLayout();
            this.tp_DoctorPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoctorPatients)).BeginInit();
            this.tp_DoctorRating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoctorRating)).BeginInit();
            this.gb_Appointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AppointmentAvailableDoctors)).BeginInit();
            this.tc_Main.SuspendLayout();
            this.tp_Home.SuspendLayout();
            this.tp_Appointment.SuspendLayout();
            this.tp_DoctorInfo.SuspendLayout();
            this.pb_PatientInfo.SuspendLayout();
            this.gb_Patient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PatientAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PatientPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Hospital)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Doctor
            // 
            this.gb_Doctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Doctor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gb_Doctor.Controls.Add(this.lbl_ChooseDoctor);
            this.gb_Doctor.Controls.Add(this.cb_ChooseDoctor);
            this.gb_Doctor.Controls.Add(this.tc_DoctorFulInfo);
            this.gb_Doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Doctor.Location = new System.Drawing.Point(27, 33);
            this.gb_Doctor.Name = "gb_Doctor";
            this.gb_Doctor.Size = new System.Drawing.Size(1445, 718);
            this.gb_Doctor.TabIndex = 7;
            this.gb_Doctor.TabStop = false;
            // 
            // lbl_ChooseDoctor
            // 
            this.lbl_ChooseDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ChooseDoctor.AutoSize = true;
            this.lbl_ChooseDoctor.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ChooseDoctor.Location = new System.Drawing.Point(64, 31);
            this.lbl_ChooseDoctor.Name = "lbl_ChooseDoctor";
            this.lbl_ChooseDoctor.Size = new System.Drawing.Size(195, 32);
            this.lbl_ChooseDoctor.TabIndex = 6;
            this.lbl_ChooseDoctor.Text = "Choose doctor:";
            // 
            // cb_ChooseDoctor
            // 
            this.cb_ChooseDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ChooseDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ChooseDoctor.FormattingEnabled = true;
            this.cb_ChooseDoctor.Location = new System.Drawing.Point(329, 27);
            this.cb_ChooseDoctor.Name = "cb_ChooseDoctor";
            this.cb_ChooseDoctor.Size = new System.Drawing.Size(411, 39);
            this.cb_ChooseDoctor.TabIndex = 5;
            this.cb_ChooseDoctor.SelectedIndexChanged += new System.EventHandler(this.cb_ChooseDoctor_SelectedIndexChanged);
            // 
            // tc_DoctorFulInfo
            // 
            this.tc_DoctorFulInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_DoctorFulInfo.Controls.Add(this.tp_DoctorInformation);
            this.tc_DoctorFulInfo.Controls.Add(this.tp_DoctorPatients);
            this.tc_DoctorFulInfo.Controls.Add(this.tp_DoctorRating);
            this.tc_DoctorFulInfo.Location = new System.Drawing.Point(32, 105);
            this.tc_DoctorFulInfo.Multiline = true;
            this.tc_DoctorFulInfo.Name = "tc_DoctorFulInfo";
            this.tc_DoctorFulInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tc_DoctorFulInfo.SelectedIndex = 0;
            this.tc_DoctorFulInfo.Size = new System.Drawing.Size(1395, 576);
            this.tc_DoctorFulInfo.TabIndex = 4;
            this.tc_DoctorFulInfo.SelectedIndexChanged += new System.EventHandler(this.tc_DoctorFulInfo_SelectedIndexChanged);
            // 
            // tp_DoctorInformation
            // 
            this.tp_DoctorInformation.Controls.Add(this.lbl_DoctorAppointment);
            this.tp_DoctorInformation.Controls.Add(this.lbl_DoctorLunchBreak);
            this.tp_DoctorInformation.Controls.Add(this.lbl_DoctorWorkingHour);
            this.tp_DoctorInformation.Controls.Add(this.lbl_DoctorName);
            this.tp_DoctorInformation.Controls.Add(this.lbl_DocAppointment);
            this.tp_DoctorInformation.Controls.Add(this.lbl_DocLunchBreak);
            this.tp_DoctorInformation.Controls.Add(this.lbl_DocWorkingHour);
            this.tp_DoctorInformation.Controls.Add(this.lbl_DocName);
            this.tp_DoctorInformation.Location = new System.Drawing.Point(4, 40);
            this.tp_DoctorInformation.Name = "tp_DoctorInformation";
            this.tp_DoctorInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tp_DoctorInformation.Size = new System.Drawing.Size(1387, 532);
            this.tp_DoctorInformation.TabIndex = 0;
            this.tp_DoctorInformation.Text = "Full information";
            this.tp_DoctorInformation.UseVisualStyleBackColor = true;
            // 
            // lbl_DoctorAppointment
            // 
            this.lbl_DoctorAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DoctorAppointment.AutoSize = true;
            this.lbl_DoctorAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DoctorAppointment.Location = new System.Drawing.Point(482, 296);
            this.lbl_DoctorAppointment.Name = "lbl_DoctorAppointment";
            this.lbl_DoctorAppointment.Size = new System.Drawing.Size(0, 36);
            this.lbl_DoctorAppointment.TabIndex = 8;
            // 
            // lbl_DoctorLunchBreak
            // 
            this.lbl_DoctorLunchBreak.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DoctorLunchBreak.AutoSize = true;
            this.lbl_DoctorLunchBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DoctorLunchBreak.Location = new System.Drawing.Point(482, 211);
            this.lbl_DoctorLunchBreak.Name = "lbl_DoctorLunchBreak";
            this.lbl_DoctorLunchBreak.Size = new System.Drawing.Size(0, 36);
            this.lbl_DoctorLunchBreak.TabIndex = 7;
            // 
            // lbl_DoctorWorkingHour
            // 
            this.lbl_DoctorWorkingHour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DoctorWorkingHour.AutoSize = true;
            this.lbl_DoctorWorkingHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DoctorWorkingHour.Location = new System.Drawing.Point(482, 132);
            this.lbl_DoctorWorkingHour.Name = "lbl_DoctorWorkingHour";
            this.lbl_DoctorWorkingHour.Size = new System.Drawing.Size(0, 36);
            this.lbl_DoctorWorkingHour.TabIndex = 6;
            // 
            // lbl_DoctorName
            // 
            this.lbl_DoctorName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DoctorName.AutoSize = true;
            this.lbl_DoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DoctorName.Location = new System.Drawing.Point(482, 58);
            this.lbl_DoctorName.Name = "lbl_DoctorName";
            this.lbl_DoctorName.Size = new System.Drawing.Size(0, 36);
            this.lbl_DoctorName.TabIndex = 5;
            // 
            // lbl_DocAppointment
            // 
            this.lbl_DocAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DocAppointment.AutoSize = true;
            this.lbl_DocAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DocAppointment.Location = new System.Drawing.Point(78, 296);
            this.lbl_DocAppointment.Name = "lbl_DocAppointment";
            this.lbl_DocAppointment.Size = new System.Drawing.Size(364, 36);
            this.lbl_DocAppointment.TabIndex = 3;
            this.lbl_DocAppointment.Text = "Duration of appointment:";
            // 
            // lbl_DocLunchBreak
            // 
            this.lbl_DocLunchBreak.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DocLunchBreak.AutoSize = true;
            this.lbl_DocLunchBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DocLunchBreak.Location = new System.Drawing.Point(78, 211);
            this.lbl_DocLunchBreak.Name = "lbl_DocLunchBreak";
            this.lbl_DocLunchBreak.Size = new System.Drawing.Size(200, 36);
            this.lbl_DocLunchBreak.TabIndex = 2;
            this.lbl_DocLunchBreak.Text = "Lunch break:";
            // 
            // lbl_DocWorkingHour
            // 
            this.lbl_DocWorkingHour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DocWorkingHour.AutoSize = true;
            this.lbl_DocWorkingHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DocWorkingHour.Location = new System.Drawing.Point(78, 132);
            this.lbl_DocWorkingHour.Name = "lbl_DocWorkingHour";
            this.lbl_DocWorkingHour.Size = new System.Drawing.Size(217, 36);
            this.lbl_DocWorkingHour.TabIndex = 1;
            this.lbl_DocWorkingHour.Text = "Working hour:";
            // 
            // lbl_DocName
            // 
            this.lbl_DocName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DocName.AutoSize = true;
            this.lbl_DocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DocName.Location = new System.Drawing.Point(78, 58);
            this.lbl_DocName.Name = "lbl_DocName";
            this.lbl_DocName.Size = new System.Drawing.Size(105, 36);
            this.lbl_DocName.TabIndex = 0;
            this.lbl_DocName.Text = "Name:";
            // 
            // tp_DoctorPatients
            // 
            this.tp_DoctorPatients.Controls.Add(this.tb_DoctorPatientsCount);
            this.tp_DoctorPatients.Controls.Add(this.lbl_DoctorPatientsDescription);
            this.tp_DoctorPatients.Controls.Add(this.lbl_DoctorPatientsCount);
            this.tp_DoctorPatients.Controls.Add(this.dgv_DoctorPatients);
            this.tp_DoctorPatients.Controls.Add(this.dtp_DoctorAppointmentDate);
            this.tp_DoctorPatients.Controls.Add(this.lbl_DoctorChooseDate);
            this.tp_DoctorPatients.Location = new System.Drawing.Point(4, 40);
            this.tp_DoctorPatients.Name = "tp_DoctorPatients";
            this.tp_DoctorPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tp_DoctorPatients.Size = new System.Drawing.Size(1387, 532);
            this.tp_DoctorPatients.TabIndex = 1;
            this.tp_DoctorPatients.Text = "Patients";
            this.tp_DoctorPatients.UseVisualStyleBackColor = true;
            // 
            // tb_DoctorPatientsCount
            // 
            this.tb_DoctorPatientsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_DoctorPatientsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_DoctorPatientsCount.Location = new System.Drawing.Point(942, 292);
            this.tb_DoctorPatientsCount.Name = "tb_DoctorPatientsCount";
            this.tb_DoctorPatientsCount.ReadOnly = true;
            this.tb_DoctorPatientsCount.Size = new System.Drawing.Size(78, 41);
            this.tb_DoctorPatientsCount.TabIndex = 6;
            this.tb_DoctorPatientsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_DoctorPatientsDescription
            // 
            this.lbl_DoctorPatientsDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DoctorPatientsDescription.AutoSize = true;
            this.lbl_DoctorPatientsDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DoctorPatientsDescription.Location = new System.Drawing.Point(23, 68);
            this.lbl_DoctorPatientsDescription.Name = "lbl_DoctorPatientsDescription";
            this.lbl_DoctorPatientsDescription.Size = new System.Drawing.Size(738, 36);
            this.lbl_DoctorPatientsDescription.TabIndex = 5;
            this.lbl_DoctorPatientsDescription.Text = "Patients who have an appointment on chosen date:";
            // 
            // lbl_DoctorPatientsCount
            // 
            this.lbl_DoctorPatientsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DoctorPatientsCount.AutoSize = true;
            this.lbl_DoctorPatientsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DoctorPatientsCount.Location = new System.Drawing.Point(936, 248);
            this.lbl_DoctorPatientsCount.Name = "lbl_DoctorPatientsCount";
            this.lbl_DoctorPatientsCount.Size = new System.Drawing.Size(105, 32);
            this.lbl_DoctorPatientsCount.TabIndex = 4;
            this.lbl_DoctorPatientsCount.Text = "Count:";
            // 
            // dgv_DoctorPatients
            // 
            this.dgv_DoctorPatients.AllowUserToAddRows = false;
            this.dgv_DoctorPatients.AllowUserToDeleteRows = false;
            this.dgv_DoctorPatients.AllowUserToOrderColumns = true;
            this.dgv_DoctorPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DoctorPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DoctorPatients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DoctorPatients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DoctorPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DoctorPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DoctorPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patient,
            this.AppointmentTime});
            this.dgv_DoctorPatients.EnableHeadersVisualStyles = false;
            this.dgv_DoctorPatients.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_DoctorPatients.Location = new System.Drawing.Point(29, 125);
            this.dgv_DoctorPatients.Name = "dgv_DoctorPatients";
            this.dgv_DoctorPatients.ReadOnly = true;
            this.dgv_DoctorPatients.RowTemplate.Height = 24;
            this.dgv_DoctorPatients.Size = new System.Drawing.Size(772, 387);
            this.dgv_DoctorPatients.TabIndex = 2;
            // 
            // Patient
            // 
            this.Patient.HeaderText = "Patient";
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            // 
            // AppointmentTime
            // 
            this.AppointmentTime.HeaderText = "Time";
            this.AppointmentTime.Name = "AppointmentTime";
            this.AppointmentTime.ReadOnly = true;
            // 
            // dtp_DoctorAppointmentDate
            // 
            this.dtp_DoctorAppointmentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DoctorAppointmentDate.CustomFormat = "dd-MM-yyyy";
            this.dtp_DoctorAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DoctorAppointmentDate.Location = new System.Drawing.Point(311, 18);
            this.dtp_DoctorAppointmentDate.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dtp_DoctorAppointmentDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_DoctorAppointmentDate.Name = "dtp_DoctorAppointmentDate";
            this.dtp_DoctorAppointmentDate.Size = new System.Drawing.Size(203, 38);
            this.dtp_DoctorAppointmentDate.TabIndex = 1;
            this.dtp_DoctorAppointmentDate.ValueChanged += new System.EventHandler(this.dtp_DoctorAppointmentDate_ValueChanged);
            // 
            // lbl_DoctorChooseDate
            // 
            this.lbl_DoctorChooseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DoctorChooseDate.AutoSize = true;
            this.lbl_DoctorChooseDate.Location = new System.Drawing.Point(60, 18);
            this.lbl_DoctorChooseDate.Name = "lbl_DoctorChooseDate";
            this.lbl_DoctorChooseDate.Size = new System.Drawing.Size(184, 32);
            this.lbl_DoctorChooseDate.TabIndex = 0;
            this.lbl_DoctorChooseDate.Text = "Choose date:";
            // 
            // tp_DoctorRating
            // 
            this.tp_DoctorRating.Controls.Add(this.dtp_DoctorRatingToDate);
            this.tp_DoctorRating.Controls.Add(this.dtp_DoctorRatingFromDate);
            this.tp_DoctorRating.Controls.Add(this.lbl_DoctorRatingPeriod);
            this.tp_DoctorRating.Controls.Add(this.lbl_DoctorRatingToDate);
            this.tp_DoctorRating.Controls.Add(this.lbl_DoctorRatingFromDate);
            this.tp_DoctorRating.Controls.Add(this.lbl_DoctorRating);
            this.tp_DoctorRating.Controls.Add(this.dgv_DoctorRating);
            this.tp_DoctorRating.Location = new System.Drawing.Point(4, 40);
            this.tp_DoctorRating.Name = "tp_DoctorRating";
            this.tp_DoctorRating.Padding = new System.Windows.Forms.Padding(3);
            this.tp_DoctorRating.Size = new System.Drawing.Size(1387, 532);
            this.tp_DoctorRating.TabIndex = 2;
            this.tp_DoctorRating.Text = "Rating";
            this.tp_DoctorRating.UseVisualStyleBackColor = true;
            // 
            // dtp_DoctorRatingToDate
            // 
            this.dtp_DoctorRatingToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DoctorRatingToDate.CustomFormat = "dd-MM-yyyy";
            this.dtp_DoctorRatingToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DoctorRatingToDate.Location = new System.Drawing.Point(1006, 232);
            this.dtp_DoctorRatingToDate.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dtp_DoctorRatingToDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_DoctorRatingToDate.Name = "dtp_DoctorRatingToDate";
            this.dtp_DoctorRatingToDate.Size = new System.Drawing.Size(197, 38);
            this.dtp_DoctorRatingToDate.TabIndex = 7;
            this.dtp_DoctorRatingToDate.ValueChanged += new System.EventHandler(this.dtp_DoctorRatingToDate_ValueChanged);
            // 
            // dtp_DoctorRatingFromDate
            // 
            this.dtp_DoctorRatingFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DoctorRatingFromDate.CustomFormat = "dd-MM-yyyy";
            this.dtp_DoctorRatingFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DoctorRatingFromDate.Location = new System.Drawing.Point(1006, 161);
            this.dtp_DoctorRatingFromDate.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dtp_DoctorRatingFromDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_DoctorRatingFromDate.Name = "dtp_DoctorRatingFromDate";
            this.dtp_DoctorRatingFromDate.Size = new System.Drawing.Size(197, 38);
            this.dtp_DoctorRatingFromDate.TabIndex = 6;
            this.dtp_DoctorRatingFromDate.ValueChanged += new System.EventHandler(this.dtp_DoctorRatingFromDate_ValueChanged);
            // 
            // lbl_DoctorRatingPeriod
            // 
            this.lbl_DoctorRatingPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DoctorRatingPeriod.AutoSize = true;
            this.lbl_DoctorRatingPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DoctorRatingPeriod.Location = new System.Drawing.Point(899, 89);
            this.lbl_DoctorRatingPeriod.Name = "lbl_DoctorRatingPeriod";
            this.lbl_DoctorRatingPeriod.Size = new System.Drawing.Size(218, 36);
            this.lbl_DoctorRatingPeriod.TabIndex = 5;
            this.lbl_DoctorRatingPeriod.Text = "Choose period:";
            // 
            // lbl_DoctorRatingToDate
            // 
            this.lbl_DoctorRatingToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DoctorRatingToDate.AutoSize = true;
            this.lbl_DoctorRatingToDate.Location = new System.Drawing.Point(888, 238);
            this.lbl_DoctorRatingToDate.Name = "lbl_DoctorRatingToDate";
            this.lbl_DoctorRatingToDate.Size = new System.Drawing.Size(56, 32);
            this.lbl_DoctorRatingToDate.TabIndex = 4;
            this.lbl_DoctorRatingToDate.Text = "To:";
            // 
            // lbl_DoctorRatingFromDate
            // 
            this.lbl_DoctorRatingFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DoctorRatingFromDate.AutoSize = true;
            this.lbl_DoctorRatingFromDate.Location = new System.Drawing.Point(888, 161);
            this.lbl_DoctorRatingFromDate.Name = "lbl_DoctorRatingFromDate";
            this.lbl_DoctorRatingFromDate.Size = new System.Drawing.Size(88, 32);
            this.lbl_DoctorRatingFromDate.TabIndex = 3;
            this.lbl_DoctorRatingFromDate.Text = "From:";
            // 
            // lbl_DoctorRating
            // 
            this.lbl_DoctorRating.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DoctorRating.AutoSize = true;
            this.lbl_DoctorRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DoctorRating.Location = new System.Drawing.Point(23, 21);
            this.lbl_DoctorRating.Name = "lbl_DoctorRating";
            this.lbl_DoctorRating.Size = new System.Drawing.Size(519, 36);
            this.lbl_DoctorRating.TabIndex = 2;
            this.lbl_DoctorRating.Text = "Doctor\'s rating by count of patients:";
            // 
            // dgv_DoctorRating
            // 
            this.dgv_DoctorRating.AllowUserToAddRows = false;
            this.dgv_DoctorRating.AllowUserToDeleteRows = false;
            this.dgv_DoctorRating.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DoctorRating.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DoctorRating.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DoctorRating.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DoctorRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DoctorRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DoctorRating.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorName,
            this.PatientsCount});
            this.dgv_DoctorRating.EnableHeadersVisualStyles = false;
            this.dgv_DoctorRating.Location = new System.Drawing.Point(18, 89);
            this.dgv_DoctorRating.Name = "dgv_DoctorRating";
            this.dgv_DoctorRating.ReadOnly = true;
            this.dgv_DoctorRating.RowTemplate.Height = 24;
            this.dgv_DoctorRating.Size = new System.Drawing.Size(722, 420);
            this.dgv_DoctorRating.TabIndex = 1;
            // 
            // DoctorName
            // 
            this.DoctorName.FillWeight = 108.6294F;
            this.DoctorName.HeaderText = "Doctor";
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.ReadOnly = true;
            // 
            // PatientsCount
            // 
            this.PatientsCount.FillWeight = 91.37056F;
            this.PatientsCount.HeaderText = "Count of patients";
            this.PatientsCount.Name = "PatientsCount";
            this.PatientsCount.ReadOnly = true;
            // 
            // gb_Appointment
            // 
            this.gb_Appointment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Appointment.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gb_Appointment.Controls.Add(this.btn_AppointmentNewAppointment);
            this.gb_Appointment.Controls.Add(this.dgv_AppointmentAvailableDoctors);
            this.gb_Appointment.Controls.Add(this.dtp_AppointmentChooseTime);
            this.gb_Appointment.Controls.Add(this.dtp_AppointmentChooseDate);
            this.gb_Appointment.Controls.Add(this.lbl_AppointmentChooseTime);
            this.gb_Appointment.Controls.Add(this.lbl_AppointmentChooseDate);
            this.gb_Appointment.Controls.Add(this.lbl_AppointmentAvailableDoctor);
            this.gb_Appointment.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Appointment.Location = new System.Drawing.Point(20, 23);
            this.gb_Appointment.Name = "gb_Appointment";
            this.gb_Appointment.Size = new System.Drawing.Size(1460, 735);
            this.gb_Appointment.TabIndex = 9;
            this.gb_Appointment.TabStop = false;
            this.gb_Appointment.Text = "Find available doctors for date and time";
            // 
            // btn_AppointmentNewAppointment
            // 
            this.btn_AppointmentNewAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AppointmentNewAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AppointmentNewAppointment.Location = new System.Drawing.Point(230, 325);
            this.btn_AppointmentNewAppointment.Name = "btn_AppointmentNewAppointment";
            this.btn_AppointmentNewAppointment.Size = new System.Drawing.Size(256, 151);
            this.btn_AppointmentNewAppointment.TabIndex = 6;
            this.btn_AppointmentNewAppointment.Text = "New appointment";
            this.btn_AppointmentNewAppointment.UseVisualStyleBackColor = true;
            this.btn_AppointmentNewAppointment.Click += new System.EventHandler(this.btn_AppointmentNewAppointment_Click);
            // 
            // dgv_AppointmentAvailableDoctors
            // 
            this.dgv_AppointmentAvailableDoctors.AllowUserToAddRows = false;
            this.dgv_AppointmentAvailableDoctors.AllowUserToDeleteRows = false;
            this.dgv_AppointmentAvailableDoctors.AllowUserToOrderColumns = true;
            this.dgv_AppointmentAvailableDoctors.AllowUserToResizeColumns = false;
            this.dgv_AppointmentAvailableDoctors.AllowUserToResizeRows = false;
            this.dgv_AppointmentAvailableDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_AppointmentAvailableDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AppointmentAvailableDoctors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_AppointmentAvailableDoctors.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_AppointmentAvailableDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_AppointmentAvailableDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AppointmentAvailableDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doctor});
            this.dgv_AppointmentAvailableDoctors.EnableHeadersVisualStyles = false;
            this.dgv_AppointmentAvailableDoctors.Location = new System.Drawing.Point(649, 149);
            this.dgv_AppointmentAvailableDoctors.Name = "dgv_AppointmentAvailableDoctors";
            this.dgv_AppointmentAvailableDoctors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_AppointmentAvailableDoctors.RowTemplate.Height = 24;
            this.dgv_AppointmentAvailableDoctors.Size = new System.Drawing.Size(721, 391);
            this.dgv_AppointmentAvailableDoctors.TabIndex = 5;
            // 
            // Doctor
            // 
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.Name = "Doctor";
            this.Doctor.ReadOnly = true;
            // 
            // dtp_AppointmentChooseTime
            // 
            this.dtp_AppointmentChooseTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_AppointmentChooseTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_AppointmentChooseTime.CustomFormat = "";
            this.dtp_AppointmentChooseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_AppointmentChooseTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_AppointmentChooseTime.Location = new System.Drawing.Point(214, 167);
            this.dtp_AppointmentChooseTime.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dtp_AppointmentChooseTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_AppointmentChooseTime.Name = "dtp_AppointmentChooseTime";
            this.dtp_AppointmentChooseTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_AppointmentChooseTime.ShowUpDown = true;
            this.dtp_AppointmentChooseTime.Size = new System.Drawing.Size(310, 34);
            this.dtp_AppointmentChooseTime.TabIndex = 4;
            this.dtp_AppointmentChooseTime.ValueChanged += new System.EventHandler(this.dtp_AppointmentChooseTime_ValueChanged);
            // 
            // dtp_AppointmentChooseDate
            // 
            this.dtp_AppointmentChooseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_AppointmentChooseDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_AppointmentChooseDate.CustomFormat = "dd-MM-yyyy";
            this.dtp_AppointmentChooseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_AppointmentChooseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_AppointmentChooseDate.Location = new System.Drawing.Point(214, 107);
            this.dtp_AppointmentChooseDate.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dtp_AppointmentChooseDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_AppointmentChooseDate.Name = "dtp_AppointmentChooseDate";
            this.dtp_AppointmentChooseDate.Size = new System.Drawing.Size(310, 34);
            this.dtp_AppointmentChooseDate.TabIndex = 3;
            this.dtp_AppointmentChooseDate.ValueChanged += new System.EventHandler(this.dtp_AppointmentChooseDate_ValueChanged);
            // 
            // lbl_AppointmentChooseTime
            // 
            this.lbl_AppointmentChooseTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_AppointmentChooseTime.AutoSize = true;
            this.lbl_AppointmentChooseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_AppointmentChooseTime.Location = new System.Drawing.Point(40, 172);
            this.lbl_AppointmentChooseTime.Name = "lbl_AppointmentChooseTime";
            this.lbl_AppointmentChooseTime.Size = new System.Drawing.Size(155, 29);
            this.lbl_AppointmentChooseTime.TabIndex = 2;
            this.lbl_AppointmentChooseTime.Text = "Choose time:";
            // 
            // lbl_AppointmentChooseDate
            // 
            this.lbl_AppointmentChooseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_AppointmentChooseDate.AutoSize = true;
            this.lbl_AppointmentChooseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_AppointmentChooseDate.Location = new System.Drawing.Point(37, 107);
            this.lbl_AppointmentChooseDate.Name = "lbl_AppointmentChooseDate";
            this.lbl_AppointmentChooseDate.Size = new System.Drawing.Size(156, 29);
            this.lbl_AppointmentChooseDate.TabIndex = 1;
            this.lbl_AppointmentChooseDate.Text = "Choose date:";
            // 
            // lbl_AppointmentAvailableDoctor
            // 
            this.lbl_AppointmentAvailableDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_AppointmentAvailableDoctor.AutoSize = true;
            this.lbl_AppointmentAvailableDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_AppointmentAvailableDoctor.Location = new System.Drawing.Point(643, 89);
            this.lbl_AppointmentAvailableDoctor.Name = "lbl_AppointmentAvailableDoctor";
            this.lbl_AppointmentAvailableDoctor.Size = new System.Drawing.Size(241, 32);
            this.lbl_AppointmentAvailableDoctor.TabIndex = 0;
            this.lbl_AppointmentAvailableDoctor.Text = "Available doctors:";
            // 
            // tc_Main
            // 
            this.tc_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_Main.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tc_Main.Controls.Add(this.tp_Home);
            this.tc_Main.Controls.Add(this.tp_Appointment);
            this.tc_Main.Controls.Add(this.tp_DoctorInfo);
            this.tc_Main.Controls.Add(this.pb_PatientInfo);
            this.tc_Main.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_Main.Location = new System.Drawing.Point(12, 12);
            this.tc_Main.Multiline = true;
            this.tc_Main.Name = "tc_Main";
            this.tc_Main.SelectedIndex = 0;
            this.tc_Main.Size = new System.Drawing.Size(1507, 844);
            this.tc_Main.TabIndex = 10;
            this.tc_Main.SelectedIndexChanged += new System.EventHandler(this.tc_Main_SelectedIndexChanged);
            // 
            // tp_Home
            // 
            this.tp_Home.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tp_Home.Controls.Add(this.pb_Hospital);
            this.tp_Home.Location = new System.Drawing.Point(4, 61);
            this.tp_Home.Name = "tp_Home";
            this.tp_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Home.Size = new System.Drawing.Size(1499, 779);
            this.tp_Home.TabIndex = 0;
            this.tp_Home.Text = "Home";
            // 
            // tp_Appointment
            // 
            this.tp_Appointment.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tp_Appointment.Controls.Add(this.gb_Appointment);
            this.tp_Appointment.Location = new System.Drawing.Point(4, 61);
            this.tp_Appointment.Name = "tp_Appointment";
            this.tp_Appointment.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Appointment.Size = new System.Drawing.Size(1499, 779);
            this.tp_Appointment.TabIndex = 1;
            this.tp_Appointment.Text = "Make an appointment";
            // 
            // tp_DoctorInfo
            // 
            this.tp_DoctorInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tp_DoctorInfo.Controls.Add(this.gb_Doctor);
            this.tp_DoctorInfo.Location = new System.Drawing.Point(4, 61);
            this.tp_DoctorInfo.Name = "tp_DoctorInfo";
            this.tp_DoctorInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tp_DoctorInfo.Size = new System.Drawing.Size(1499, 779);
            this.tp_DoctorInfo.TabIndex = 2;
            this.tp_DoctorInfo.Text = "Doctor Information";
            // 
            // pb_PatientInfo
            // 
            this.pb_PatientInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pb_PatientInfo.Controls.Add(this.gb_Patient);
            this.pb_PatientInfo.Location = new System.Drawing.Point(4, 61);
            this.pb_PatientInfo.Name = "pb_PatientInfo";
            this.pb_PatientInfo.Padding = new System.Windows.Forms.Padding(3);
            this.pb_PatientInfo.Size = new System.Drawing.Size(1499, 779);
            this.pb_PatientInfo.TabIndex = 3;
            this.pb_PatientInfo.Text = "Patient Information";
            // 
            // gb_Patient
            // 
            this.gb_Patient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Patient.Controls.Add(this.btn_PatientAppointment);
            this.gb_Patient.Controls.Add(this.lbl_PatientAddress);
            this.gb_Patient.Controls.Add(this.lbl_PatientDateOfBirth);
            this.gb_Patient.Controls.Add(this.lbl_PatientFirstName);
            this.gb_Patient.Controls.Add(this.lbl_PatientLastName);
            this.gb_Patient.Controls.Add(this.dgv_PatientAppointment);
            this.gb_Patient.Controls.Add(this.lbl_PatientSelectPatient);
            this.gb_Patient.Controls.Add(this.tb_TypePatientLastName);
            this.gb_Patient.Controls.Add(this.lbl_TypePatientLastName);
            this.gb_Patient.Controls.Add(this.dgv_PatientPatients);
            this.gb_Patient.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Patient.Location = new System.Drawing.Point(26, 25);
            this.gb_Patient.Name = "gb_Patient";
            this.gb_Patient.Size = new System.Drawing.Size(1444, 723);
            this.gb_Patient.TabIndex = 0;
            this.gb_Patient.TabStop = false;
            this.gb_Patient.Text = "Find patient\'s appointment";
            // 
            // btn_PatientAppointment
            // 
            this.btn_PatientAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PatientAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_PatientAppointment.Location = new System.Drawing.Point(314, 641);
            this.btn_PatientAppointment.Name = "btn_PatientAppointment";
            this.btn_PatientAppointment.Size = new System.Drawing.Size(271, 53);
            this.btn_PatientAppointment.TabIndex = 9;
            this.btn_PatientAppointment.Text = "Show appointment";
            this.btn_PatientAppointment.UseVisualStyleBackColor = true;
            this.btn_PatientAppointment.Click += new System.EventHandler(this.btn_PatientAppointment_Click);
            // 
            // lbl_PatientAddress
            // 
            this.lbl_PatientAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PatientAddress.AutoSize = true;
            this.lbl_PatientAddress.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PatientAddress.Location = new System.Drawing.Point(951, 251);
            this.lbl_PatientAddress.Name = "lbl_PatientAddress";
            this.lbl_PatientAddress.Size = new System.Drawing.Size(0, 35);
            this.lbl_PatientAddress.TabIndex = 8;
            // 
            // lbl_PatientDateOfBirth
            // 
            this.lbl_PatientDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PatientDateOfBirth.AutoSize = true;
            this.lbl_PatientDateOfBirth.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PatientDateOfBirth.Location = new System.Drawing.Point(951, 184);
            this.lbl_PatientDateOfBirth.Name = "lbl_PatientDateOfBirth";
            this.lbl_PatientDateOfBirth.Size = new System.Drawing.Size(0, 35);
            this.lbl_PatientDateOfBirth.TabIndex = 7;
            // 
            // lbl_PatientFirstName
            // 
            this.lbl_PatientFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PatientFirstName.AutoSize = true;
            this.lbl_PatientFirstName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PatientFirstName.Location = new System.Drawing.Point(951, 124);
            this.lbl_PatientFirstName.Name = "lbl_PatientFirstName";
            this.lbl_PatientFirstName.Size = new System.Drawing.Size(0, 35);
            this.lbl_PatientFirstName.TabIndex = 6;
            // 
            // lbl_PatientLastName
            // 
            this.lbl_PatientLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PatientLastName.AutoSize = true;
            this.lbl_PatientLastName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PatientLastName.Location = new System.Drawing.Point(951, 57);
            this.lbl_PatientLastName.Name = "lbl_PatientLastName";
            this.lbl_PatientLastName.Size = new System.Drawing.Size(0, 35);
            this.lbl_PatientLastName.TabIndex = 5;
            // 
            // dgv_PatientAppointment
            // 
            this.dgv_PatientAppointment.AllowUserToAddRows = false;
            this.dgv_PatientAppointment.AllowUserToDeleteRows = false;
            this.dgv_PatientAppointment.AllowUserToOrderColumns = true;
            this.dgv_PatientAppointment.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_PatientAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PatientAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_PatientAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PatientAppointment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_PatientAppointment.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_PatientAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_PatientAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PatientAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentDate,
            this.AppointmentStart,
            this.AppointmentEnd,
            this.DoctorsName});
            this.dgv_PatientAppointment.EnableHeadersVisualStyles = false;
            this.dgv_PatientAppointment.Location = new System.Drawing.Point(851, 314);
            this.dgv_PatientAppointment.MultiSelect = false;
            this.dgv_PatientAppointment.Name = "dgv_PatientAppointment";
            this.dgv_PatientAppointment.ReadOnly = true;
            this.dgv_PatientAppointment.RowTemplate.Height = 24;
            this.dgv_PatientAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PatientAppointment.Size = new System.Drawing.Size(574, 380);
            this.dgv_PatientAppointment.TabIndex = 4;
            // 
            // lbl_PatientSelectPatient
            // 
            this.lbl_PatientSelectPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PatientSelectPatient.AutoSize = true;
            this.lbl_PatientSelectPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PatientSelectPatient.Location = new System.Drawing.Point(44, 127);
            this.lbl_PatientSelectPatient.Name = "lbl_PatientSelectPatient";
            this.lbl_PatientSelectPatient.Size = new System.Drawing.Size(212, 32);
            this.lbl_PatientSelectPatient.TabIndex = 3;
            this.lbl_PatientSelectPatient.Text = "Select patient:";
            // 
            // tb_TypePatientLastName
            // 
            this.tb_TypePatientLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_TypePatientLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_TypePatientLastName.Location = new System.Drawing.Point(279, 69);
            this.tb_TypePatientLastName.Name = "tb_TypePatientLastName";
            this.tb_TypePatientLastName.Size = new System.Drawing.Size(306, 38);
            this.tb_TypePatientLastName.TabIndex = 2;
            this.tb_TypePatientLastName.TextChanged += new System.EventHandler(this.tb_TypePatientLastName_TextChanged);
            // 
            // lbl_TypePatientLastName
            // 
            this.lbl_TypePatientLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TypePatientLastName.AutoSize = true;
            this.lbl_TypePatientLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_TypePatientLastName.Location = new System.Drawing.Point(44, 72);
            this.lbl_TypePatientLastName.Name = "lbl_TypePatientLastName";
            this.lbl_TypePatientLastName.Size = new System.Drawing.Size(231, 32);
            this.lbl_TypePatientLastName.TabIndex = 1;
            this.lbl_TypePatientLastName.Text = "Type last name:";
            // 
            // dgv_PatientPatients
            // 
            this.dgv_PatientPatients.AllowUserToAddRows = false;
            this.dgv_PatientPatients.AllowUserToDeleteRows = false;
            this.dgv_PatientPatients.AllowUserToOrderColumns = true;
            this.dgv_PatientPatients.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_PatientPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PatientPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_PatientPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PatientPatients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_PatientPatients.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_PatientPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_PatientPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PatientPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.DateOfBirth,
            this.Address});
            this.dgv_PatientPatients.EnableHeadersVisualStyles = false;
            this.dgv_PatientPatients.Location = new System.Drawing.Point(35, 184);
            this.dgv_PatientPatients.MultiSelect = false;
            this.dgv_PatientPatients.Name = "dgv_PatientPatients";
            this.dgv_PatientPatients.ReadOnly = true;
            this.dgv_PatientPatients.RowTemplate.Height = 24;
            this.dgv_PatientPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PatientPatients.Size = new System.Drawing.Size(773, 437);
            this.dgv_PatientPatients.TabIndex = 0;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "DateOfBirth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.FillWeight = 200F;
            this.AppointmentDate.HeaderText = "Date";
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.ReadOnly = true;
            // 
            // AppointmentStart
            // 
            this.AppointmentStart.HeaderText = "Starts";
            this.AppointmentStart.Name = "AppointmentStart";
            this.AppointmentStart.ReadOnly = true;
            // 
            // AppointmentEnd
            // 
            this.AppointmentEnd.HeaderText = "Ends";
            this.AppointmentEnd.Name = "AppointmentEnd";
            this.AppointmentEnd.ReadOnly = true;
            // 
            // DoctorsName
            // 
            this.DoctorsName.FillWeight = 200F;
            this.DoctorsName.HeaderText = "Doctor";
            this.DoctorsName.Name = "DoctorsName";
            this.DoctorsName.ReadOnly = true;
            // 
            // pb_Hospital
            // 
            this.pb_Hospital.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Hospital.Image = global::DoctorVisitingSystem.DesktopUI.Properties.Resources.HospitalImage;
            this.pb_Hospital.Location = new System.Drawing.Point(68, 132);
            this.pb_Hospital.Name = "pb_Hospital";
            this.pb_Hospital.Size = new System.Drawing.Size(1352, 601);
            this.pb_Hospital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Hospital.TabIndex = 3;
            this.pb_Hospital.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1552, 868);
            this.Controls.Add(this.tc_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gb_Doctor.ResumeLayout(false);
            this.gb_Doctor.PerformLayout();
            this.tc_DoctorFulInfo.ResumeLayout(false);
            this.tp_DoctorInformation.ResumeLayout(false);
            this.tp_DoctorInformation.PerformLayout();
            this.tp_DoctorPatients.ResumeLayout(false);
            this.tp_DoctorPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoctorPatients)).EndInit();
            this.tp_DoctorRating.ResumeLayout(false);
            this.tp_DoctorRating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoctorRating)).EndInit();
            this.gb_Appointment.ResumeLayout(false);
            this.gb_Appointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AppointmentAvailableDoctors)).EndInit();
            this.tc_Main.ResumeLayout(false);
            this.tp_Home.ResumeLayout(false);
            this.tp_Appointment.ResumeLayout(false);
            this.tp_DoctorInfo.ResumeLayout(false);
            this.pb_PatientInfo.ResumeLayout(false);
            this.gb_Patient.ResumeLayout(false);
            this.gb_Patient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PatientAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PatientPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Hospital)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Hospital;
        private System.Windows.Forms.GroupBox gb_Doctor;
        private System.Windows.Forms.Label lbl_ChooseDoctor;
        private System.Windows.Forms.ComboBox cb_ChooseDoctor;
        private System.Windows.Forms.TabControl tc_DoctorFulInfo;
        private System.Windows.Forms.TabPage tp_DoctorInformation;
        private System.Windows.Forms.Label lbl_DocAppointment;
        private System.Windows.Forms.Label lbl_DocLunchBreak;
        private System.Windows.Forms.Label lbl_DocWorkingHour;
        private System.Windows.Forms.Label lbl_DocName;
        private System.Windows.Forms.TabPage tp_DoctorPatients;
        private System.Windows.Forms.DateTimePicker dtp_DoctorAppointmentDate;
        private System.Windows.Forms.Label lbl_DoctorChooseDate;
        private System.Windows.Forms.TabPage tp_DoctorRating;
        private System.Windows.Forms.DataGridView dgv_DoctorPatients;
        private System.Windows.Forms.Label lbl_DoctorAppointment;
        private System.Windows.Forms.Label lbl_DoctorLunchBreak;
        private System.Windows.Forms.Label lbl_DoctorWorkingHour;
        private System.Windows.Forms.Label lbl_DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentTime;
        private System.Windows.Forms.Label lbl_DoctorPatientsCount;
        private System.Windows.Forms.DataGridView dgv_DoctorRating;
        private System.Windows.Forms.Label lbl_DoctorPatientsDescription;
        private System.Windows.Forms.TextBox tb_DoctorPatientsCount;
        private System.Windows.Forms.DateTimePicker dtp_DoctorRatingToDate;
        private System.Windows.Forms.DateTimePicker dtp_DoctorRatingFromDate;
        private System.Windows.Forms.Label lbl_DoctorRatingPeriod;
        private System.Windows.Forms.Label lbl_DoctorRatingToDate;
        private System.Windows.Forms.Label lbl_DoctorRatingFromDate;
        private System.Windows.Forms.Label lbl_DoctorRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientsCount;
        private System.Windows.Forms.GroupBox gb_Appointment;
        private System.Windows.Forms.Label lbl_AppointmentAvailableDoctor;
        private System.Windows.Forms.DateTimePicker dtp_AppointmentChooseDate;
        private System.Windows.Forms.Label lbl_AppointmentChooseTime;
        private System.Windows.Forms.Label lbl_AppointmentChooseDate;
        private System.Windows.Forms.DateTimePicker dtp_AppointmentChooseTime;
        private System.Windows.Forms.DataGridView dgv_AppointmentAvailableDoctors;
        private System.Windows.Forms.Button btn_AppointmentNewAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.TabControl tc_Main;
        private System.Windows.Forms.TabPage tp_Home;
        private System.Windows.Forms.TabPage tp_Appointment;
        private System.Windows.Forms.TabPage tp_DoctorInfo;
        private System.Windows.Forms.TabPage pb_PatientInfo;
        private System.Windows.Forms.GroupBox gb_Patient;
        private System.Windows.Forms.TextBox tb_TypePatientLastName;
        private System.Windows.Forms.Label lbl_TypePatientLastName;
        private System.Windows.Forms.DataGridView dgv_PatientPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridView dgv_PatientAppointment;
        private System.Windows.Forms.Label lbl_PatientSelectPatient;
        private System.Windows.Forms.Label lbl_PatientFirstName;
        private System.Windows.Forms.Label lbl_PatientLastName;
        private System.Windows.Forms.Label lbl_PatientAddress;
        private System.Windows.Forms.Label lbl_PatientDateOfBirth;
        private System.Windows.Forms.Button btn_PatientAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorsName;
    }
}

