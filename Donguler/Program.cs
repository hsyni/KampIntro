//array-dizi

string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlşanguç için temel kurs", "Java", "Python"};

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("Footer");
