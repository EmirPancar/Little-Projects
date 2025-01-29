using System;

namespace MatrisÇarpma
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("1.Matris satır sayısı:");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.Write("1.Matris sütun sayısı:");
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] x=new int[a,b];

            Console.Write("2.Matris satır sayısı:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Matris sütun sayısı:");
            int d = Convert.ToInt32(Console.ReadLine());
            int[,] y=new int[c,d];

            if(b==d) { 
            int n = 0;
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    n++;
                    Console.Write("1.Matrisin {0}. üyesi:",n);
                    x[i,j]=Convert.ToInt32(Console.ReadLine());

                }
            }
            n=0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    n++;
                    Console.Write("2.Matrisin {0}. üyesi:", n);
                    y[i, j]=Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.WriteLine();
            Console.WriteLine("1.MATRİS");
            for (int i = 0;i < a; i++)
            {
                
                for (int j = 0;j < b; j++)
                {

                    Console.Write(x[i,j]+" ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("2.MATRİS");
            for (int i = 0; i < a; i++)
            {

                for (int j = 0; j < b; j++)
                {

                    Console.Write(y[i, j]+" ");

                }
                Console.WriteLine();
            }

            int[,] z = new int[a,d];
            
            for (int i = 0;i < a; i++)
            {
                for(int j = 0;j < d; j++)
                {
                    for(int k = 0;k < b;k++)
                    {

                        z[i,j]+=x[i,k]*y[k,j];

                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine("MATRİS ÇARPIMI");
            for (int i = 0;i<a ; i++)
            {
                for( int j = 0;j < b ; j++)
                {
                    Console.Write(z[i,j]+" ");

                }
                Console.WriteLine();
            }

          }
            else
            { 
                Console.WriteLine();
                Console.WriteLine("Matris çarpımı yapılabilmesi için");
            Console.WriteLine("1.matrisin sütun sayısıyla 2. matrisin satır sayısı aynı olmalıdır.");
            Console.WriteLine();
            }
        }
    }
}
