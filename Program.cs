using System;

namespace Try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
           /* try
            {
                Console.WriteLine("Bir sayı Giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş Olduğunuz Sayı: " + sayi);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata: "+ ex.Message.ToString());

                
            }
            finally    
            
            {
                Console.WriteLine("İşlem Tamalandı."); 
            } 
           */

        try 
	{
                //int a= int.parse(null);
               // int b = int.Parse("test");
                int c = int.Parse("-20000000000");
		
	}
	catch (ArgumentNullException ex)
	{
        Console.WriteLine("Boş Değer Girdiniz");
        Console.WriteLine(ex);

               
    
		
	}

            catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun Değil.");
                Console.WriteLine(ex);



            }

            catch(OverflowException ex)
            {

                Console.WriteLine("Çok Küçük veya Çok Büyük Değer Girdiniz.");
                Console.WriteLine(ex);

            }
            finally
            {

                Console.WriteLine("İşlem Tamamlandı.");
            }

        }
    }
}
