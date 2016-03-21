using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorVisitingSystem.Entities;

namespace DoctorVisitingSystem.DesktopUI.Code
{
    public class CurrentReceptionist
    {
        private static Receptionist currentReceptionist;

        public static void Initialize(Receptionist receptionist)
        {
            if (currentReceptionist != null)
            {
                throw new InvalidOperationException("Current receptionist has already been specified");
            }
            currentReceptionist = receptionist;
        }

        public static int Id
        {
            get
            {
                return currentReceptionist.Id;
            }
        }

        public static string FirstName
        {
            get
            {
                return currentReceptionist.FirstName;
            }
        }

        public static string LastName
        {
            get
            {
                return currentReceptionist.LastName;
            }
        }

        public static string Login
        {
            get
            {
                return currentReceptionist.Login;
            }
        }

    }
}
