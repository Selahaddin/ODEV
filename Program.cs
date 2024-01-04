namespace SayiTaminOyunu.Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rnd = new Random();
                int point = 0;
                Console.WriteLine("Sayı tahmin oyununa hoş geldiniz!\nOynamak istediğiniz zorluğu seçiniz (KOLAY-ORTA-ZOR)");
                string res = Console.ReadLine();
                if (res == "KOLAY")
                {
                    int number = rnd.Next(0, 36);
                    Console.WriteLine("1-35 dahil olmak üzere bir sayı tuttum 15 tahmin hakkın var!\n2. tahmin hakkından sonra puanın düşmeye başlayacak\n");
                    for (int i = 1; i <= 15; i++)
                    {
                        Console.WriteLine($"{i}. Tahmin hakkın : ");
                        byte guess = byte.Parse(Console.ReadLine());
                        if (guess < number)
                        {
                            Console.WriteLine("Tuttuğum sayı daha büyük!");
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("Tuttuğum sayı daha küçük!");
                        }
                        else if (guess == number)
                        {
                            point += (15 - i) * 10; //Tekte bilirse 140 puan sonrasında 130 120 110 100 .....
                            Console.WriteLine($"Tebrikler {i}. Tahmin hakkında doğru bildin\n Puan : {point}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Bilemedin tuttuğum sayı = {number}\nÜzgünüm birdahaki sefere");
                            break;
                        }
                    }
                }
                if (res == "ORTA")
                {
                    int number = rnd.Next(0, 101);
                    Console.WriteLine("1-100 dahil olmak üzere bir sayı tuttum 9 tahmin hakkın var!\n2. tahmin hakkından sonra puanın düşmeye başlayacak\n");
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine($"{i}. Tahmin hakkın : ");
                        byte guess = byte.Parse(Console.ReadLine());
                        if (guess < number)
                        {
                            Console.WriteLine("Tuttuğum sayı daha büyük!");
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("Tuttuğum sayı daha küçük!");
                        }
                        else if (guess == number)
                        {
                            point += (9 - i) * 20; //Tekte bilirse 160 puan sonrasında 140 120 100 80 60...
                            Console.WriteLine($"Tebrikler {i}. Tahmin hakkında doğru bildin\n Puan : {point}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Bilemedin tuttuğum sayı = {number}\nÜzgünüm birdahaki sefere");
                            break;
                        }
                    }
                }
                if (res == "ZOR")
                {
                    int number = rnd.Next(0, 201);
                    Console.WriteLine("1-200 dahil olmak üzere bir sayı tuttum 5 tahmin hakkın var!\n2. tahmin hakkından sonra puanın düşmeye başlayacak\n");
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.WriteLine($"{i}. Tahmin hakkın : ");
                        byte guess = byte.Parse(Console.ReadLine());
                        if (guess < number)
                        {
                            Console.WriteLine("Tuttuğum sayı daha büyük!");
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("Tuttuğum sayı daha küçük!");
                        }
                        else if (guess == number)
                        {
                            point += (5 - i) * 33 + 1; //Tekte bilirse 133 puan sonrasında 100 67 34 1
                            Console.WriteLine($"Tebrikler {i}. Tahmin hakkında doğru bildin\n Puan : {point}");
                            break;
                        }
                        else 
                        {
                            Console.WriteLine($"Bilemedin tuttuğum sayı = {number}\nÜzgünüm birdahaki sefere");
                            break;
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen sayı isteniyorsa rakam kullanarak yazınız!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Lütfen değerler arasında bir sayı giriniz!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bilinmeyen bir hata oluştu lütfen geliştirici ile bağlantıya geçiniz!");
                Console.WriteLine($"Tarih:{DateTime.Now}\nHata Mesajı : {ex.Message}\nHata Detayı :{ex.StackTrace}");
            }
        }
    }
}