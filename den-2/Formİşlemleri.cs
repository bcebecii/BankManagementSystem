using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace den_2
{
    public static class Formİşlemleri
    {   
      
        public static Giris girisForm = new Giris();  
        public static Musteri müsteriForm = new Musteri();
        public static BankaMuduru bankaMuduruForm = new BankaMuduru();
        public static Temsilci temsilciForm = new Temsilci();
        public static HesapSilme hSilmeForm = new HesapSilme();
        public static mguncelle mGuncelle = new mguncelle();
        public static ParaÇekme paraCekForm = new ParaÇekme();
        public static ParaYatırma paraYatirForm = new ParaYatırma();
        public static MusteriBilgiGuncelle_T MBGuncelleForm = new MusteriBilgiGuncelle_T();
        public static KayitOl kayitOlForm = new KayitOl();
        public static MusteriEkle_T mustEkleTems = new MusteriEkle_T();
        public static MusteriEkle_BM mustEkleMudur = new MusteriEkle_BM();
        public static Kur_BM kur = new Kur_BM();
        public static MusteriListele_BM mustListFormMudur = new MusteriListele_BM(); 
        public static Personelİşlemleri_BM personelislemForm = new Personelİşlemleri_BM();
        public static hesapAcma hesapAcma = new hesapAcma();
        public static MTalepListele_T musteriTalep = new MTalepListele_T();
        public static ParaTransferi transferForm = new ParaTransferi();
        public static krediTalep krediTalep=new krediTalep();
        public static krediOdeme krediOdeme = new krediOdeme();

        public static İşlemGörüntüle islemGoruntule = new İşlemGörüntüle(); 
        public static deadlock deadlock=new deadlock();

    }
}