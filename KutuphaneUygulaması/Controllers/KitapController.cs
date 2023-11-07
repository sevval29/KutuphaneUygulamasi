using KutuphaneUygulaması.Interfaces;
using KutuphaneUygulaması.Models;
using LibraryProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace KutuphaneUygulaması.Controllers
{
    public class KitapController : Controller
    {
        private readonly KitapDbContext _context;
        private readonly IKitapRepository _kitapRepository;

        public KitapController(KitapDbContext context, IKitapRepository kitapRepository)
        {
            _context = context;
            _kitapRepository = kitapRepository;
        }

        public async Task<IActionResult> Index() //Bu metot, kitapları listelemek için kullanılır. _kitapRepository'den tüm kitapları alır ve bir görünüm (view) dosyasına bu kitapları ileterek kullanıcıya gösterir.
        {
            IEnumerable<Kitap> books = await _kitapRepository.GetAll();
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Kitap kitap) //formdan gelen verilerle yeni bir kitap oluşturur.
        {

            if (!ModelState.IsValid)
            {
                return View(kitap);
            }

            _kitapRepository.Add(kitap);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> OduncVer(int id) //bu metod, ödünç verme işlemi için gerekli verileri içeren bir form görüntüler.
        {
            var kitap = await _kitapRepository.GetByIdAsync(id);

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OduncVer(int id, string oduncAlanAdi, DateTime geriGetirmeTarihi)
        //formdan gelen verilerle kitabın ödünç verilmesini yönetir

        {

            try
            {
                var kitap = await _kitapRepository.GetByIdAsync(id);
                if (kitap != null && kitap.KutuphaneDurumu)
                {
                    kitap.KutuphaneDurumu = false;
                    kitap.OduncAlanAdi = oduncAlanAdi;
                    kitap.GeriGetirmeTarihi = geriGetirmeTarihi.Date;
                    _context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.AlertMessage = "Bir hata oluştu. Lütfen tekrar deneyin.";
                return RedirectToAction("Error");
            }
        }
    }
}
