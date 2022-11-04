using System;

namespace Alorithm_lowhigh
{
    class program
    {
        //Array to be seacrhed
        int[] arr = new int[20];
        //Number of elements in the array
        int n;
        //get the number of elements to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 20 elements.\n");
            }
            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Enter array elements ");
            Console.WriteLine("---------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                String s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                //accept the number to be searched
                Console.Write("\nEnter element you want to search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                //apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the index of the elements in the array
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop to search for the elements in the array
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "not found in the array\n");
                Console.WriteLine("\nNumber of Comparison : " + ctr);

                Console.Write("\nContinue search (y/n):");
                ch = char.Parse(Console.ReadLine());


            } while ((ch == 'y') || (ch == 'Y'));
        }
        static void Main(String[] args)
        {
            program myList = new program();
            int pilihanmenu;
            char ch;

            Console.WriteLine("Menu Option");
            Console.WriteLine("===============");
            Console.WriteLine("1.Linear Search");
            Console.WriteLine("2.Binary search");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Enter your choice (1,2,3) : ");
            pilihanmenu = Convert.ToInt32(Console.ReadLine());
            switch (pilihanmenu)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("-------------");
                    Console.WriteLine("Binary search");
                    Console.WriteLine("-------------");
                    myList.input();
                    myList.BinarySearch();
                    break;
                case 2:
                    Console.WriteLine("exit.");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}