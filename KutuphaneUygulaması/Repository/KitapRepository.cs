using KutuphaneUygulaması.Interfaces;
using LibraryProject.Models;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneUygulaması.Repository
{
    public class KitapRepository : IKitapRepository
    {
        private readonly KitapDbContext _context;
        public KitapRepository(KitapDbContext context )
        {
            _context = context;
        }
        public bool Add(Kitap kitap)
        {
            _context.Add( kitap );
            return Save();
        }

        public async Task<IEnumerable<Kitap>> GetAll()
        {
            // Kitapları alfabetik sıraya göre sırala ve liste olarak döndür
            return await _context.kitaplar.OrderBy(k => k.KitapAd).ToListAsync();
        }

        public async Task<Kitap> GetByIdAsync(int id) //Bu metot, verilen bir ID'ye göre kitapları veritabanından arar ve ilgili kitabı döndürür.
        {
            return await _context.kitaplar.FirstOrDefaultAsync(i => i.ID == id);
        }

        public bool Save()
        {
           var saved=_context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Kitap kitap)
        {
            throw new NotImplementedException();
        }
    }
}
