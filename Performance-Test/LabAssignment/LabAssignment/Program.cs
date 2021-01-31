using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LabAssignment
{
    class Program
    {
        public int myPow(int baseNum,int power)
        {
            if (power == 0)
            {
                return 1;
            }
            else
            {
                return baseNum * myPow(baseNum, power - 1);
            }
        }
        private void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }

        private void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);

                Merge(input, left, middle, right);
            }
        }
        public static void BucketSort(ref int[] data)
        {
            int minValue = data[0];
            int maxValue = data[0];

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > maxValue)
                    maxValue = data[i];
                if (data[i] < minValue)
                    minValue = data[i];
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < data.Length; i++)
            {
                bucket[data[i] - minValue].Add(data[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        data[k] = bucket[i][j];
                        k++;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Answer 1 .
            Console.WriteLine("\nAnswer 1 : \n");
            int x = 0;
            int y = 1, z;
            int num;
            Stopwatch sW = new Stopwatch();
            Console.WriteLine("Enter Number of iteration (FOR):");
            num = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(x + " " + "\n" + y + " ");
            sW.Start();
            for (int i = 0; i < num - 2; i++)
            {
                z = x + y;
                Console.WriteLine(z);
                x = y;
                y = z;

            }
            sW.Stop();
            Console.WriteLine("Time for Fibonacci (FOR): " + sW.Elapsed);

            x = 0;
            y = 1; z = 0;
            num = 0;
            Console.WriteLine("Enter Number of iteration (DO-WHILE):");
            num = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(x + " " + "\n" + y + " ");
            sW.Start();
            int j = 0;
            do
            {
                j++;
                z = x + y;
                Console.WriteLine(z);
                x = y;
                y = z;

            } while (j < num - 2);
            sW.Stop();
            Console.WriteLine("Time for Fibonacci (DO-WHILE): " + sW.Elapsed);

            x = 0;
            y = 1; z = 0;
            num = 0;
            Console.WriteLine("Enter Number of iteration (WHILE):");
            num = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(x + " " + "\n" + y + " ");
            sW.Start();
            int k = 0;
            while (k < num - 2)
            {
                k++;
                z = x + y;
                Console.WriteLine(z);
                x = y;
                y = z;

            }
            sW.Stop();
            Console.WriteLine("Time for Fibonacci (WHILE): " + sW.Elapsed);
            Console.WriteLine("\nAnswer 2 : \n");

            //Answer 2.
            Program p = new Program();
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            Console.WriteLine("Result of myPow() : " + p.myPow(3, 4));
            sw2.Stop();
            Console.WriteLine("Time for MyPow : " + sw2.Elapsed);
            sw2.Start();
            Console.WriteLine("Result of Math.Pow() : " + Math.Pow(3, 4));
            sw2.Stop();
            Console.WriteLine("Time for MyPow : " + sw2.Elapsed);
            Console.WriteLine("\nAnswer 3 : \n");

            ////Answer 3.
            ////MergeSort
            int[] arr = new int[10]
            {
                1, 33, 4, 11, 23, 8, 2, 38, 930, 6
            };

            Program p2 = new Program();
            Stopwatch sw3 = new Stopwatch();
            sw3.Start();
            p2.MergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted Values:");
            sw3.Stop();
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
            Console.WriteLine("Time for MergeSort : " + sw3.Elapsed);
            ////BucketSort
            int[] arr2 = new int[10]
            {
                1, 33, 4, 11, 23, 8, 2, 38, 930, 6
            };
            sw3.Start();
            BucketSort(ref arr2);
            sw3.Stop();
            for (int i = 0; i < arr2.Length; i++)
                Console.WriteLine(arr2[i]);
            Console.WriteLine("Time for BucketSort : " + sw3.Elapsed);
            Console.WriteLine("\nAnswer 4 : \n");

            ////Answer 4
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("Yüzüklerin Efendisi: Yüzük Kardeşliği", "9789753425");
            dictionary.Add("Yüzüklerin Efendisi: İki Kule", "9753421818");
            dictionary.Add("Yüzüklerin Efendisi: Kralın Dönüşü", "9753422024");
            dictionary.Add("Dune", "605375479X");
            dictionary.Add("Dune Çocukları", "6053756024");
            dictionary.Add("Drizzt Efsanesi 1: Anayurt", "6053755575");
            dictionary.Add("Drizzt Efsanesi 2: Sürgün", "6059958133");
            dictionary.Add("Zaman Çarkı 1: Dünyanın Gözü", "9758725718");
            dictionary.Add("Zaman Çarkı 2: Büyük Av", "9758725726");


            string bookName = "";
            Console.WriteLine("Enter Book Name (IF-ELSE):");
            bookName = Convert.ToString(Console.ReadLine());
            Stopwatch sw4 = new Stopwatch();
            sw4.Start();
            if (bookName == "Yüzüklerin Efendisi: Yüzük Kardeşiliği")
            {
                Console.WriteLine(dictionary["Yüzüklerin Efendisi: Yüzük Kardeşliği"]);
            }
            else if (bookName == "Yüzüklerin Efendisi: İki Kule")
            {
                Console.WriteLine(dictionary["Yüzüklerin Efendisi: İki Kule"]);
            }
            else if (bookName == "Yüzüklerin Efendisi: Kralın Dönüşü")
            {
                Console.WriteLine(dictionary["Yüzüklerin Efendisi: Kralın Dönüşü"]);
            }
            else if (bookName == "Dune")
            {
                Console.WriteLine(dictionary["Dune"]);
            }
            else if (bookName == "Dune Çocukları")
            {
                Console.WriteLine(dictionary["Dune Çocukları"]);
            }
            else if (bookName == "Drizzt Efsanesi 1: Anayurt")
            {
                Console.WriteLine(dictionary["Drizzt Efsanesi 1: Anayurt"]);
            }
            else if (bookName == "Drizzt Efsanesi 2: Sürgün")
            {
                Console.WriteLine(dictionary["Drizzt Efsanesi 2: Sürgün"]);
            }
            else if (bookName == "Zaman Çarkı 1: Dünyanın Gözü")
            {
                Console.WriteLine(dictionary["Zaman Çarkı 1: Dünyanın Gözü"]);
            }
            else if (bookName == "Zaman Çarkı 2: Büyük Av")
            {
                Console.WriteLine(dictionary["Zaman Çarkı 2: Büyük Av"]);
            }
            else
            {
                Console.WriteLine("Aranan Kitap bulunamadı");
            }
            sw4.Stop();
            Console.WriteLine("Book Name (IF-ELSE) : " + sw4.Elapsed);

            bookName = "";
            Console.WriteLine("Enter Book Name (SWITCH-CASE):");
            bookName = Convert.ToString(Console.ReadLine());

            sw4.Start();
            switch (bookName)
            {
                case "Yüzüklerin Efendisi: Yüzük Kardeşiliği":
                    {
                        Console.WriteLine(dictionary["Yüzüklerin Efendisi: Yüzük Kardeşliği"]);
                        break;
                    }
                case "Yüzüklerin Efendisi: İki Kule":
                    {
                        Console.WriteLine(dictionary["Yüzüklerin Efendisi: İki Kule"]);
                        break;
                    }
                case "Yüzüklerin Efendisi: Kralın Dönüşü":
                    {
                        Console.WriteLine(dictionary["Yüzüklerin Efendisi: Kralın Dönüşü"]);
                        break;
                    }
                case "Dune":
                    {
                        Console.WriteLine(dictionary["Dune"]);
                        break;
                    }
                case "Dune Çocukları":
                    {
                        Console.WriteLine(dictionary["Dune Çocukları"]);
                        break;
                    }
                case "Drizzt Efsanesi 1: Anayurt":
                    {
                        Console.WriteLine(dictionary["Drizzt Efsanesi 1: Anayurt"]);
                        break;
                    }
                case "Drizzt Efsanesi 2: Sürgün":
                    {
                        Console.WriteLine(dictionary["Drizzt Efsanesi 2: Sürgün"]);
                        break;
                    }
                case "Zaman Çarkı 1: Dünyanın Gözü":
                    {
                        Console.WriteLine(dictionary["Zaman Çarkı 1: Dünyanın Gözü"]);
                        break;
                    }
                case "Zaman Çarkı 2: Büyük Av":
                    {
                        Console.WriteLine(dictionary["Zaman Çarkı 2: Büyük Av"]);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Aranan Kitap bulunamadı");
                        break;
                    }
            }
            sw4.Stop();
            Console.WriteLine("Book Name (SWITCH-CASE) : " + sw4.Elapsed);
            Console.WriteLine("\nAnswer 5 : \n");

            //5.Answer
            char[] cUpper = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();
            Dictionary<char, int> dic = new Dictionary<char, int>();
            Stopwatch sw6 = new Stopwatch();
            char letter = ' ';

            for (int i = 0; i < cUpper.Length; i++)
            {
                dic.Add(cUpper[i],i+1);

            }
            Console.Write("Enter the Letter:");
            letter = Convert.ToChar(Console.ReadLine());
            string sttr = letter.ToString().ToUpper();
            letter = Convert.ToChar(sttr);
            int control = dic[letter];
            sw6.Start();
            if (control >29)
            {
                Console.WriteLine("It doesnt exist");

            }
            else
            {
                Console.WriteLine("Number of Letter "+control);    
            }
            sw6.Stop();
            Console.WriteLine("Time for Letter  : (IF-ELSE) : " + sw6.Elapsed);

            letter = ' '; sttr=" ";control = 0;
            Console.Write("Enter the Letter:");
            letter = Convert.ToChar(Console.ReadLine());
            sttr = letter.ToString().ToUpper();
            letter = Convert.ToChar(sttr);
            control = dic[letter];

            sw6.Start();
            switch (letter > 29)
            {
                case  false:
                    {
                        Console.WriteLine("It doesnt exist");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Number of Letter " + control);
                        break;
                    }
            }
            sw6.Stop();
            Console.WriteLine("\nTime for Letter : (SWITCH-CASE) : " + sw6.Elapsed);

            Console.ReadKey();

        }
    }
}
