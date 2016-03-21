using DoctorVisitingSystem.Entities;

namespace DoctorVisitingSystem.Repositories
{
    public interface IReceptionistRepository
    {
        Receptionist GetReceptionistByLogin(string login, string password);
    }
}
