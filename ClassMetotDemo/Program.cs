using ClassMetotDemo;

Musteri musteri1 = new Musteri();
musteri1.Ad = "Huseyin";
musteri1.Soyad = "Kazan";
musteri1.Adres = "Ankara";

MusteriManager musteriManager = new MusteriManager();

musteriManager.Ekle(musteri1);
musteriManager.Sil(musteri1);

