using LibraryProject.Models;
using System.Diagnostics;
using System.Net;

namespace KutuphaneUygulaması.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<KitapDbContext>();

                context.Database.EnsureCreated();

                if (!context.kitaplar.Any())
                {
                    context.kitaplar.AddRange(new List<Kitap>()
                    {
                        new Kitap()
                        {
                            KitapAd = "Sana Gül Bahçesi Vadetmedim",
                            ResimUrl = "https://s3.eu-central-1.amazonaws.com/img.vikitap.com/books/m/4dbf0277-7590-4ecd-81b8-059f4d5c9a82.jpeg",
                            Yazar = "Joanne Greenberg",
                            KutuphaneDurumu = true,
                         
                         },
                         new Kitap()
                        {
                            KitapAd = "Bizim Büyük Çaresizliğim",
                            ResimUrl = "https://s3.eu-central-1.amazonaws.com/img.vikitap.com/books/m/4ecebfe1-fb74-4268-b6e2-2534b24f9262.jpg",
                            Yazar = "Barış Bıçakçı",
                            KutuphaneDurumu = true,

                         },
                         new Kitap()
                        {
                            KitapAd = "Kürk Mantolu Madonna",
                            ResimUrl = "https://s3.eu-central-1.amazonaws.com/img.vikitap.com/books/m/4dac9726-e7d8-45cf-8ddd-de804d5c9a82.jpg",
                            Yazar = "Sabahattin Ali",
                            KutuphaneDurumu = true,

                         },
                        new Kitap()
                        {
                            KitapAd = "Karısını Şapka Sanan Adam",
                            ResimUrl = "https://s3.eu-central-1.amazonaws.com/img.vikitap.com/books/m/533b05a7-81fc-4ada-af39-49080509132a.jpg",
                            Yazar = "Oliver Sacks",
                            KutuphaneDurumu = true,

                         },
                           new Kitap()
                        {
                            KitapAd = "Sevgi Neredeyse Tanrı Oradadır",
                            ResimUrl = "https://s3.eu-central-1.amazonaws.com/img.vikitap.com/books/m/4d9612a3-2df0-4678-bed9-84a54d5c9a82.jpg",
                            Yazar = "Lev Nikolayeviç Tolstoy",
                            KutuphaneDurumu = true,

                         },
                    });
                    context.SaveChanges();
                }
               
               
                }
            }
        }
    }

