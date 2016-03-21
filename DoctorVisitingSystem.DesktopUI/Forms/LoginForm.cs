using System;
using System.Windows.Forms;
using System.Configuration;
using DoctorVisitingSystem.Repositories;
using DoctorVisitingSystem.Entities;
using DoctorVisitingSystem.DesktopUI.Code;

namespace DoctorVisitingSystem.DesktopUI.Forms
{
    public partial class LoginForm : Form
    {
        #region Private Fields

        private readonly IReceptionistRepository _receptionistRepository;

        #endregion

        #region Constructor

        public LoginForm()
        {
            _receptionistRepository = new SqlReceptionistRepository(ConfigurationManager.ConnectionStrings["DoctorVisitingSystemConnection"].ConnectionString);

            InitializeComponent();            
        }

        #endregion

        #region Load Form 

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.lbl_DateTime.Text = DateTime.Now.ToShortDateString();
        }

        #endregion

        #region Button : Login

        private void btn_Login_Click(object sender, EventArgs e)
        {          
            string login = tb_Login.Text;
            string password = tb_Password.Text;
            Receptionist receptionist = _receptionistRepository.GetReceptionistByLogin(login, password);

            if (receptionist == null)
            {
                MessageBox.Show(this, "Invalid user name or password", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else
            {
                CurrentReceptionist.Initialize(receptionist);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        #endregion        
    }
}
