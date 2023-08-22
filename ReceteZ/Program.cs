using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ReceteZ.Controllers;
using ReceteZ.Data;
using ReceteZ.Models;

namespace ReceteZ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Ilac> ilaclar = new List<Ilac>();

           /*
            //Ilac ilac = new Ilac();
            //ilac.Ad = "Apranax";
            //ilac.Barkod = "13556";

            //ilaclar.Add(new Ilac
            //{
            //    Ad = "talcid",
            //    Barkod = "13432"
            //});

            //ApplicationDbContext context = new ApplicationDbContext();

            //context.Ilaclar.AddRange(ilaclar);
            //context.SaveChanges();

            //1.Yöntem: Ilac DbdenGelen = context.Ilaclar.Find(2);

            //2.Yöntem: Ilac DbdenGelen = context.Ilaclar.FirstOrDefault(i=>i.Id == 2);

            //3.Yntem: Ilac DbdenGelen = context.Ilaclar.Where(i=> i.Id == 2).First();

            //Ilac DbdenGelen = context.Ilaclar.Find(4);

            //DbdenGelen.Ad = "Taldic";

            //context.Ilaclar.Update(DbdenGelen);

            //context.SaveChanges();

            //List<Tani> tanilar = new List<Tani>();
            //while (true)
            //{

            //    Tani tani = new Tani();

            //    Console.WriteLine("Taanı'Nın adını giriniz: ");
            //    tani.Ad = Console.ReadLine();
            //    Console.WriteLine("Tanı'nın kodunu giriniz: ");
            //    tani.Kod = Console.ReadLine();

            //    context.Tanilar.Add(tani);
            //    Console.WriteLine("Yeni bir kayıt daha eklemek ister misiniz?: E/H");

            //    string cevap = Console.ReadLine();

            //    if (cevap.ToUpper() == "H")
            //    {
            //        break;
            //    }

            //    Console.Clear();
            //}
            //context.Tanilar.AddRange(tanilar);
            //context.SaveChanges();

            //Console.WriteLine("Tani adi giriniz: ");
            //Tani tani = new Tani(); 
            //tani.Ad = Console.ReadLine();
            //Console.WriteLine("Tani kodu giriniz: ");
            //tani.Kod = Console.ReadLine();

            //List<Tani> taniListesi = new List<Tani>();
            //taniListesi.Add(new Tani { Ad = "test", Kod = "d23232323" });
            //taniListesi.Add(new Tani { Ad = "test2", Kod = "2342444" });
            //taniListesi.Add(new Tani { Ad = "test3", Kod = "24234432" });
            //taniListesi.Add(new Tani { Ad = "test4", Kod = "2352344" });

            //taniListesi = TaniController.CokluEkle(taniListesi);    

            //int id= TaniController.Ekle(tani);

            ////if (TaniController.Ekle(tani))
            //    Console.WriteLine("İşlem başarılı");
            //else
            //    Console.WriteLine("Hhata oluştu! ");

                */


            Console.WriteLine("Lütfen aramak istediğiniz tanının birkaç harfını yazınız: ");
            List<Tani> aramaSonucu= TaniController.IsmeGoreAra(Console.ReadLine());

            if (aramaSonucu.Count != 0 )
            {
                Console.WriteLine("Bulunan tanı sayısı :" + aramaSonucu.Count);
                foreach (var item in aramaSonucu)
                {
                    Console.WriteLine(item.Ad);
                }
            }
            else
            {
                Console.WriteLine("Herhangi bir tanı bulunamadı!");
            }



        }
    }
}