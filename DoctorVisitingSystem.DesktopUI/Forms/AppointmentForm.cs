using System;
using System.Linq;
using System.Windows.Forms;
using DoctorVisitingSystem.Repositories;
using System.Data.SqlClient;
using DoctorVisitingSystem.Entities;

namespace DoctorVisitingSystem.DesktopUI.Forms
{
    public partial class AppointmentForm : Form
    {
        #region Private Fields

        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IDoctorRepository _doctorRepository;
        private readonly DateTime _desiredDateTime;

        #endregion

        #region Constructor

        public AppointmentForm(IAppointmentRepository appointmentRepository, IDoctorRepository doctorRepository, DateTime desiredDateTime)
        {
            _appointmentRepository = appointmentRepository;
            _doctorRepository = doctorRepository;
            _desiredDateTime = desiredDateTime;

            InitializeComponent();   
        }

        #endregion

        #region Load Form 

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            dtp_DateOfBirth.MaxDate = DateTime.Today;
            dtp_DateOfBirth.MinDate = new DateTime(1900, 1, 1);
            dtp_DateOfBirth.Format = DateTimePickerFormat.Short;

            dtp_DateOfAppointment.Value = _desiredDateTime;
            dtp_DateOfAppointment.MinDate = DateTime.Today;
            dtp_DateOfAppointment.MaxDate = new DateTime(2060, 12, 31);
            dtp_DateOfAppointment.Format = DateTimePickerFormat.Short;

            dtp_TimeOfAppointment.Value = _desiredDateTime;
            dtp_TimeOfAppointment.Format = DateTimePickerFormat.Time;
            dtp_TimeOfAppointment.ShowUpDown = true;

            cb_DoctorsName.DataSource = _doctorRepository.GetAllDoctors().ToList();
            cb_DoctorsName.ValueMember = "Id";
            cb_DoctorsName.DisplayMember = "Name";
        }

        #endregion 

        #region Button : MakeAnAppointment

        private void btn_MakeAnAppointment_Click(object sender, EventArgs e)
        {            
            string firstName = tb_FirstName.Text;
            string lastName = tb_LastName.Text;
            DateTime dateOfBirth = dtp_DateOfBirth.Value;
            string address = tb_Address.Text;
            string doctorName = cb_DoctorsName.Text;
            DateTime appointmentDateTime = dtp_DateOfAppointment.Value.Date;
            string appointmentTime = dtp_TimeOfAppointment.Value.ToShortTimeString();
            appointmentDateTime += TimeSpan.Parse(appointmentTime);

            if (firstName == String.Empty || lastName == String.Empty || address == String.Empty || appointmentDateTime < DateTime.Now.AddMinutes(-5))
            {
                if (appointmentDateTime < DateTime.Now.AddMinutes(-5))
                {
                    MessageBox.Show(this, "Invalid time!", "Appointment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, "Invalid patient information!", "Appointment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Appointment appointment = _appointmentRepository.MakeAppointment(firstName, lastName, dateOfBirth, address, doctorName, appointmentDateTime);
                    MessageBox.Show(this,
                                    String.Format("Your appointment: \nPatient: {0} {1}\nDoctor: {2}\nDate: {3}\nStarts: {4}\nEnds: {5}",
                                                    appointment.PatientEntity.FirstName,
                                                    appointment.PatientEntity.LastName,
                                                    appointment.DoctorEntity.Name,
                                                    appointment.AppointmentDateTimeStart.ToLongDateString(),
                                                    appointment.AppointmentDateTimeStart.ToLongTimeString(),
                                                    appointment.AppointmentDateTimeFinish.ToLongTimeString()
                                                    ),
                                    "New appointment",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(this, ex.Message, "Date warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
            
        }

        #endregion

        #region Button : Cancel

        private void btn_CancelAppointment_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show(this, "Are you sure?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)
            {
                this.Close();
            }           
        }

        #endregion

        #region AppointmentForm Closing

        private void AppointmentForm_FormClosing(object sender, FormClosingEventArgs e)
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
