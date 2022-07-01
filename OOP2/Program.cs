using OOP2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.MusteriNo = "23123";
musteri1.Adi = "Huseyin";
musteri1.Soyadi = "Demir";
musteri1.TcNo = "5464565613";

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "546456";
musteri2.SirketAdi = "Demirler";
musteri2.VergiNo = "45645645";

Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);


