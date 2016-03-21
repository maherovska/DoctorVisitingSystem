using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using DoctorVisitingSystem.Repositories;
using DoctorVisitingSystem.Entities;
using DoctorVisitingSystem.DesktopUI.Code;

namespace DoctorVisitingSystem.DesktopUI.Forms
{
    public partial class MainForm : Form
    {
        #region Private Fields

        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IDoctorRepository _doctorRepository;
        private readonly IPatientRepository _patientRepository;

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["DoctorVisitingSystemConnection"].ConnectionString;

            _appointmentRepository = new SqlAppointmentRepository(connectionString);
            _doctorRepository = new SqlDoctorRepository(connectionString);
            _patientRepository = new SqlPatientRepository(connectionString);
        }

        #endregion

        #region MainForm Load

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = String.Format("[Doctor Visiting System] Reseptionist: {0} {1}", CurrentReceptionist.FirstName, CurrentReceptionist.LastName);

            cb_ChooseDoctor.SelectedIndexChanged -= new EventHandler(cb_ChooseDoctor_SelectedIndexChanged);
            cb_ChooseDoctor.DataSource = _doctorRepository.GetAllDoctors().ToList();
            cb_ChooseDoctor.ValueMember = "Id";
            cb_ChooseDoctor.DisplayMember = "Name";
            cb_ChooseDoctor.SelectedItem = null;
            cb_ChooseDoctor.SelectedIndexChanged += new EventHandler(cb_ChooseDoctor_SelectedIndexChanged);

            dtp_AppointmentChooseDate.MinDate = DateTime.Now;
            dtp_AppointmentChooseDate.Value = DateTime.Now; ;
            dtp_AppointmentChooseTime.Value = DateTime.Now;

            dgv_AppointmentAvailableDoctors.Font = new Font("Microsoft Sans Serif", 18);
            dgv_PatientAppointment.Font = new Font("Microsoft Sans Serif", 16);
            dgv_PatientPatients.Font = new Font("Microsoft Sans Serif", 14);        
        }

        #endregion

        #region Main tab control

        private void tc_Main_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (tc_Main.SelectedTab == tc_Main.TabPages["tp_Appointment"])
            {
                DisplayAvailableDoctors();
            }
            else if (tc_Main.SelectedTab == tc_Main.TabPages["tp_DoctorInfo"])
            {
                DisplayDoctorRating();
            }
            else if (tc_Main.SelectedTab == tc_Main.TabPages["pb_PatientInfo"])
            {
                DisplayPatientsByLastName();
                dgv_PatientPatients.ClearSelection();
                dgv_PatientPatients.CurrentCell = null;
            }
        }

        #endregion
        
        #region Main tab control.Tab page : Make an appointment

        private void dtp_AppointmentChooseDate_ValueChanged(object sender, EventArgs e)
        {
            DisplayAvailableDoctors();
        }

        private void dtp_AppointmentChooseTime_ValueChanged(object sender, EventArgs e)
        {
            DisplayAvailableDoctors();
        }

        private void btn_AppointmentNewAppointment_Click(object sender, EventArgs e)
        {
            DateTime desiredDateTime = GetDesiredDateForAppointment();

            if (desiredDateTime >= DateTime.Now.AddMinutes(-5))
            {
                AppointmentForm frmAppointment = new AppointmentForm(_appointmentRepository, _doctorRepository, desiredDateTime);

                if (frmAppointment.ShowDialog() == DialogResult.OK)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show(this, "Time should not be in the past!", "Time Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_AppointmentChooseTime.Value = DateTime.Now;
            }
        }

        private void DisplayAvailableDoctors()
        {
            dgv_AppointmentAvailableDoctors.Rows.Clear();

            DateTime dateTime = GetDesiredDateForAppointment();
            List<string> availableDoctors = _doctorRepository.GetAvaiableDoctorByDateTime(dateTime).ToList();

            for (int i = 0; i < availableDoctors.Count; i++)
            {
                dgv_AppointmentAvailableDoctors.Rows.Add();
                dgv_AppointmentAvailableDoctors.Rows[i].Cells["Doctor"].Value = availableDoctors[i];
            }
        }

        private DateTime GetDesiredDateForAppointment()
        {
            DateTime dateTime = dtp_AppointmentChooseDate.Value.Date;
            string time = dtp_AppointmentChooseTime.Value.ToShortTimeString();
            dateTime += TimeSpan.Parse(time);

            return dateTime;
        }

        #endregion

        #region Main tab control.Tab page : Doctor information

        private void tc_DoctorFulInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc_DoctorFulInfo.SelectedTab == tc_DoctorFulInfo.TabPages["tp_DoctorRating"])
            {
                lbl_ChooseDoctor.Visible = false;
                cb_ChooseDoctor.Visible = false;
            }
            else
            {
                lbl_ChooseDoctor.Visible = true;
                cb_ChooseDoctor.Visible = true;
            }
        }

        private void cb_ChooseDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ChooseDoctor.SelectedItem != null)
            {
                DisplayDoctorFullInformation();
                DisplayPatientsToDoctor();
            }
        }

        #region Doctor tab control.Tab page : DoctorFullInformation

        private void DisplayDoctorFullInformation()
        {
            int doctorId = (int)cb_ChooseDoctor.SelectedValue;
            Doctor doctor = _doctorRepository.GetDoctorById(doctorId);

            lbl_DoctorName.Text = doctor.Name;
            lbl_DoctorWorkingHour.Text = String.Format("{0} - {1}", doctor.ArrivingTime.ToString(@"hh\:mm"), doctor.LeavingTime.ToString(@"hh\:mm"));
            lbl_DoctorLunchBreak.Text = String.Format("{0} - {1}", doctor.StartingTimeOfBreak.ToString(@"hh\:mm"), doctor.FinishingTimeOfBreak.ToString(@"hh\:mm"));
            lbl_DoctorAppointment.Text = String.Format("{0}", doctor.AppointmentDuration.ToString(@"hh\:mm"));
        }

        #endregion

        #region Doctor tab control.Tab page : DoctorPatients

        private void dtp_DoctorAppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            if (cb_ChooseDoctor.SelectedItem != null)
            {
                DisplayPatientsToDoctor();
            }
        }

        private void DisplayPatientsToDoctor()
        {
            dgv_DoctorPatients.AutoGenerateColumns = false;
            dgv_DoctorPatients.Rows.Clear();

            int doctorId = (int)cb_ChooseDoctor.SelectedValue;
            DateTime date = dtp_DoctorAppointmentDate.Value;

            List<Appointment> patients = _patientRepository.GetPatientsByDoctorIdAndDate(doctorId, date).ToList();

            for (int i = 0; i < patients.Count; i++)
            {
                dgv_DoctorPatients.Rows.Add();
                dgv_DoctorPatients.Rows[i].Cells["Patient"].Value = String.Format("{0} {1}", patients[i].PatientEntity.FirstName, patients[i].PatientEntity.LastName);
                dgv_DoctorPatients.Rows[i].Cells["AppointmentTime"].Value = patients[i].AppointmentDateTimeStart.ToString("HH:mm");
            }

            tb_DoctorPatientsCount.Text = _patientRepository.GetPatientsCountByDoctorIdAndDate(doctorId, date).ToString();

        }

        #endregion

        #region Doctor tab control.Tab page : DoctorRating

        private void dtp_DoctorRatingFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_DoctorRatingToDate.Value < dtp_DoctorRatingFromDate.Value)
            {
                dtp_DoctorRatingFromDate.Value = dtp_DoctorRatingToDate.Value;
            }

            DisplayDoctorRating();
        }

        private void dtp_DoctorRatingToDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_DoctorRatingToDate.Value < dtp_DoctorRatingFromDate.Value)
            {
                dtp_DoctorRatingToDate.Value = dtp_DoctorRatingFromDate.Value;
            }

            DisplayDoctorRating();
        }

        private void DisplayDoctorRating()
        {
            dgv_DoctorRating.Rows.Clear();

            DateTime dateFrom = dtp_DoctorRatingFromDate.Value;
            DateTime dateTo = dtp_DoctorRatingToDate.Value;

            Dictionary<string, int> rating = _doctorRepository.GetDoctorsRating(dateFrom, dateTo).ToDictionary(key => key.Key, value => value.Value);

            for (int i = 0; i < rating.Count; i++)
            {
                dgv_DoctorRating.Rows.Add();
                var item = rating.ElementAt(i);
                dgv_DoctorRating.Rows[i].Cells["DoctorName"].Value = item.Key;
                dgv_DoctorRating.Rows[i].Cells["PatientsCount"].Value = item.Value;
            }
        }

        #endregion

        #endregion

        #region Main tab control.Tab page : Patient information        

        private void tb_TypePatientLastName_TextChanged(object sender, EventArgs e)
        {
            DisplayPatientsByLastName();
        }

        private void btn_PatientAppointment_Click(object sender, EventArgs e)
        {
            if (dgv_PatientPatients.CurrentCell != null)
            {
                DisplayPatientsAppointment();
            }
            else
            {
                MessageBox.Show(this, "Choose patient!", "Patient was not chosen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisplayPatientsByLastName()
        {
            List<Patient> patients = _patientRepository.GetPatientsByLastName(tb_TypePatientLastName.Text).ToList();
            dgv_PatientPatients.Rows.Clear();

            for (int i = 0; i < patients.Count; i++)
            {
                dgv_PatientPatients.Rows.Add();
                dgv_PatientPatients.Rows[i].Cells["LastName"].Value = patients[i].LastName;
                dgv_PatientPatients.Rows[i].Cells["FirstName"].Value = patients[i].FirstName;
                dgv_PatientPatients.Rows[i].Cells["DateOfBirth"].Value = patients[i].DateOfBirth.ToShortDateString();
                dgv_PatientPatients.Rows[i].Cells["Address"].Value = patients[i].Address;
            }
        }

        private void DisplayPatientsAppointment()
        {
            int selectedRowIndex = dgv_PatientPatients.CurrentCell.RowIndex;

            string firstName = (string)dgv_PatientPatients.Rows[selectedRowIndex].Cells["FirstName"].Value;
            string lastName = (string)dgv_PatientPatients.Rows[selectedRowIndex].Cells["LastName"].Value;
            string stringDateOfBirth = (string)dgv_PatientPatients.Rows[selectedRowIndex].Cells["DateOfBirth"].Value;
            DateTime dateOfBirth = DateTime.ParseExact(stringDateOfBirth, "dd.MM.yyyy", null);
            string address = (string)dgv_PatientPatients.Rows[selectedRowIndex].Cells["Address"].Value;

            lbl_PatientFirstName.Text = firstName;
            lbl_PatientLastName.Text = lastName;
            lbl_PatientDateOfBirth.Text = dateOfBirth.ToShortDateString();
            lbl_PatientAddress.Text = address;

            List<Appointment> appointments = _appointmentRepository.GetAllApointmentByPatientName(firstName, lastName, dateOfBirth, address).ToList();
            dgv_PatientAppointment.Rows.Clear();

            for (int i = 0; i < appointments.Count; i++)
            {
                dgv_PatientAppointment.Rows.Add();
                dgv_PatientAppointment.Rows[i].Cells["AppointmentDate"].Value = appointments[i].AppointmentDateTimeStart.ToShortDateString();
                dgv_PatientAppointment.Rows[i].Cells["AppointmentStart"].Value = appointments[i].AppointmentDateTimeStart.ToShortTimeString();
                dgv_PatientAppointment.Rows[i].Cells["AppointmentEnd"].Value = appointments[i].AppointmentDateTimeFinish.ToShortTimeString();
                dgv_PatientAppointment.Rows[i].Cells["DoctorsName"].Value = appointments[i].DoctorEntity.Name;
            }
        }

        #endregion

        #region MainForm Closing

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show(this, "Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        #endregion
    }
}
