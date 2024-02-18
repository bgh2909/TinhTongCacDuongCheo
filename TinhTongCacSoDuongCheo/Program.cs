using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongCacSoDuongCheo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sodong;
            do
            {
                Console.Write("Nhap so dong cua ma tran: ");
                sodong = int.Parse(Console.ReadLine());
                if (sodong > 5)
                {
                    Console.WriteLine("Ma tran khong the vuot qua kich thuoc 5x5");

                }
                Console.WriteLine();
            }
            while (sodong > 5);

            int socot;
            do
            {
                Console.Write("Nhap so cot cua ma tran: ");
                socot = int.Parse(Console.ReadLine());
                if (socot != sodong)
                {
                    Console.WriteLine("Ma tran co dong so cot phai bang nhau");

                }
                Console.WriteLine();
            }
            while (socot != sodong);


            int[,] matran2chieu = new int[sodong, socot];

            for (int i = 0; i < socot; i++)
            {
                for (int j = 0; j < sodong; j++)
                {
                    Console.Write("Nhap phan tu cua dong {0} cot {1}: ", i + 1, j + 1);
                    matran2chieu[j, i] = int.Parse(Console.ReadLine());

                }
                Console.WriteLine();
            }

            Console.WriteLine("Ma tran ban vua khoi tao: ");
            for (int m = 0; m < matran2chieu.GetLength(0); m++)
            {
                for (int n = 0; n < matran2chieu.GetLength(1); n++)
                {
                    Console.Write(matran2chieu[n, m] + "   ");
                }
                Console.WriteLine();
            }

            int tongduongcheo1 = 0;
            int tongduongcheo2 = 0;
   
            
            for (int g = 0; g < matran2chieu.GetLength (0);g++)
            {
                tongduongcheo1 += matran2chieu[g, g];
            }

            for (int h = 0; h < matran2chieu.GetLength(1) ;h++)
            {
                tongduongcheo2 += matran2chieu[h,sodong-h-1];
            }
            Console.WriteLine("Tong cua duong cheo thu nhat trong ma tran bang: "+tongduongcheo1);
            Console.WriteLine("Tong cua duong cheo thu hai trong ma tran bang: " + tongduongcheo2);

            int tong2duongcheo = tongduongcheo1 + tongduongcheo2;
            Console.Write("Tong cua 2 duong cheo trong ma tran: " + tong2duongcheo);






            Console.ReadKey();

        }
    }
}
