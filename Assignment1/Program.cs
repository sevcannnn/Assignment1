using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Sevcan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            /*
            Console.WriteLine("Adinizi daxil edin:");
            string ad = Console.ReadLine();

            Console.WriteLine("Yasinizi daxil edin:");
            string yas_metni = Console.ReadLine();

            if (!int.TryParse(yas_metni, out int yas))
            {
                Console.WriteLine("Yasinizi duzgun daxil edin!");
                return;
            }

            Console.WriteLine("Boyunuzu daxil edin:");
            string boy_metni = Console.ReadLine();

            if (!double.TryParse(boy_metni, out double boy))
            {
                Console.WriteLine("Boyunuzu duzgun daxil edin!");
                return;
            }

            Console.WriteLine("Salam, menim adim " + ad +
                ". Menim " + yas + " yasim var. Boyum " + boy + " m-dir.");
            */

            //2
            /*
            const double Pi = 3.14159;

            Console.WriteLine("Radius daxil edin:");
            string radius_metni = Console.ReadLine();

            if (!double.TryParse(radius_metni, out double r) || r < 0)
            {
                Console.WriteLine("Radiusu duzgun daxil edin!");
                return;
            }

            double S = Pi * r * r;
            Console.WriteLine("Dairenin sahesi: " + S);
            */

            //3
            /*
            const double USD = 1.7;
            const double EUR = 1.82;

            Console.WriteLine("Manat meblegini daxil edin:");
            string manat_metni = Console.ReadLine();

            if (!double.TryParse(manat_metni, out double manat))
            {
                Console.WriteLine("Duzgun mebleg daxil edin!");
                return;
            }

            double dollar = manat / USD;
            double euro = manat / EUR;

            Console.WriteLine("Dollar: " + dollar);
            Console.WriteLine("Euro: " + euro);
            */

            //4
            /*
            Console.WriteLine("Azerbaycan dili balini daxil edin:");
            string az_dili_metni = Console.ReadLine();
            int az_dili = int.Parse(az_dili_metni);

            Console.WriteLine("Riyaziyyat balini daxil edin:");
            string riy_bali_metni = Console.ReadLine();
            int riy_bali = int.Parse(riy_bali_metni);

            Console.WriteLine("Ingilis dili balini daxil edin:");
            string ing_dili_metni = Console.ReadLine();
            int ing_dili = int.Parse(ing_dili_metni);

            Console.WriteLine("Fizika balini daxil edin:");
            string fizika_bali_metni = Console.ReadLine();
            int fizika_bali = int.Parse(fizika_bali_metni);

            Console.WriteLine("Informatika balini daxil edin:");
            string info_bali_metni = Console.ReadLine();
            int info_bali = int.Parse(info_bali_metni);

            double orta_bal =
                (az_dili + riy_bali + ing_dili + fizika_bali + info_bali) / 5.0;

            string esas_qiymet;

            if (orta_bal < 51)
                esas_qiymet = "Kesildiniz";
            else if (orta_bal <= 90)
                esas_qiymet = "Orta netice";
            else
                esas_qiymet = "Ela netice";
            Console.WriteLine("Orta qiymet:" + orta_bal);

            Console.WriteLine("Netice: " + esas_qiymet);
            */

            //5
            /*
            const double faiz = 0.12;

            Console.WriteLine("Ilkin meblegi daxil edin:");
            string ilkin_mebleg_metni = Console.ReadLine();

            if (!double.TryParse(ilkin_mebleg_metni, out double ilkin_mebleg))
            {
                Console.WriteLine("Meblegi duzgun daxil edin!");
                return;
            }

            Console.WriteLine("Nece il saxlanacagini qeyd edin:");
            string il_sayi_metni = Console.ReadLine();

            if (!int.TryParse(il_sayi_metni, out int il_sayi) || il_sayi < 0)
            {
                Console.WriteLine("Il sayini duzgun daxil edin!");
                return;
            }

            double gelecek_mebleg = ilkin_mebleg * (1 + faiz * il_sayi);
            Console.WriteLine("Gelecek mebleg: " + gelecek_mebleg);
            */

            //6
            /*
            Console.WriteLine("Mesafeni daxil edin:");
            string mesafe_metni = Console.ReadLine();

            mesafe_metni = mesafe_metni.Replace("km", "").Trim();

            if (!double.TryParse(mesafe_metni, out double mesafe))
            {
                Console.WriteLine("Mesafe duzgun daxil edilmeyib!");
                return;
            }

            Console.WriteLine("Serf olunan yanacagi daxil edin:");
            string yanacag_metni = Console.ReadLine();

            if (!double.TryParse(yanacag_metni, out double yanacag))
            {
                Console.WriteLine("Yanacaq miqdari duzgun daxil edilmeyib!");
                return;
            }

            if (mesafe < 0 || yanacag < 0)
            {
                Console.WriteLine("Daxil edilen melumat yanlisdir!");
            }
            else if (mesafe == 0)
            {
                Console.WriteLine("Mesafe 0 ola bilmez!");
            }
            else
            {
                double serfiyyat = (yanacag / mesafe) * 100;
                Console.WriteLine("100 km ucun serfiyyat miqdari: " + serfiyyat);
            }
            */
            Console.ReadKey();
        }
    }
}