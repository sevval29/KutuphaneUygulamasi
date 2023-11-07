using LibraryProject.Models;

namespace KutuphaneUygulaması.Interfaces
{
    public interface IKitapRepository
    {

        Task<IEnumerable<Kitap>> GetAll();

        Task<Kitap> GetByIdAsync(int id);

        bool Add(Kitap kitap);
        bool Update(Kitap kitap);

        bool Save();
    }
}
