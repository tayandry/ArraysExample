using System;

namespace ArraysExample
{
    class Program
    {
        static void Main(string[] args)
         {
            //class of unknown students
            //every student has a name
            //create array that stores first name of every student
            
            int count = 0;
            string[] firstNames = new string[50];
            string[] lastNames = new string[50];
            double[] sales = new double[50];

            GetEmployeeInfo(ref count, firstNames, lastNames, sales);
            PrintEmployeeInfo(firstNames, lastNames, sales, count);

            Console.WriteLine("\n \n \n");
            ComboReport(firstNames, lastNames, sales, count);

            SelectionSort(firstNames, lastNames, sales, count);
            PrintEmployeeInfo(firstNames, lastNames, sales, count);

            // Console.Write("\n\nEnter the name you are looking for:  ");
            // string searchVal = Console.ReadLine().ToLower();
            // int indexFound = SeqSearch(names, count, searchVal);

            // if(indexFound != -1)
            // {
            //     Console.WriteLine(searchVal + " is at index " + indexFound);
            // }
            // else
            // {
            //     Console.WriteLine(searchVal + " was not found");
            // }
        }

        static string[] GetEmployeeInfo(ref int count, string[] firstNames, string[] lastNames, double[] sales)
        {
            
             //priming read
            Console.Write("Enter the first name 'stop':  ");
            string firstName = Console.ReadLine().ToLower();
        
            while(firstName != "stop")
            {
                Console.Write("Enter the last name 'stop':  ");
                string lastName = Console.ReadLine().ToLower();
                Console.Write("Enter the sales amount in $ 'stop':  ");
                double salesAmt = double.Parse(Console.ReadLine());

                firstNames[count] = firstName;
                lastNames[count] = lastName;
                sales[count] = salesAmt;

                count++;

                 Console.Write("Enter the first name 'stop':  ");
                 firstName = Console.ReadLine().ToLower();
                
            }


        }

        static void PrintEmployeeInfo(string[] firstNames, string[] lastNames, double[] sales, int count)
        {
            Console.WriteLine("\nThe employee info is  :");
            for(int i = 0; i < count; i++) //count tells us how many values so only shows names entered if less than max
            {
                Console.WriteLine(firstNames[i] + "\t" + lastNames[i] + "\t" + sales[i]);
            }
        }

        // static int SeqSearch(string[] names, int count, string searchVal)
        // {
        //     for(int i = 0; i < count; i++)
        //     {
        //         if(searchVal == names[i])
        //         {
        //             return i;
        //         }
        //     }
        //     return -1;
        // }

        static void ComboReport(string[] firstNames, string[] lastNames, double[] sales, int count)
        {
            for(int i = 0; i<count-1; i++ )
            {
                for(int j = i + 1; j < count; j++)
                {
                    if(sales[i] + sales[j] >= 20000)
                    {
                        Console.WriteLine(firstNames[i] + " " + lastNames[i] + "\t" + firstNames[j] + " " + lastNames[j] + "\t" + (sales[i]  + sales[j]));
                    }
                }
            }
        }

        static void SelectionSort(string[] firstNames, string[] lastNames, double[] sales, int count)
        {
            for(int i = 0; i < count-1; i++)
            {
                int minIndex = i;
                for(int j  = i+1; j < count; j++)
                {
                    if(firstNames[j].CompareTo(firstNames[minIndex])<0)
                    {
                        minIndex = j;
                    }
                }

                if(minIndex != i)
                {
                    Swap(firstNames, lastNames, sales, i, minIndex);
                }
            }
        }

        static void Swap(string[] firstNames, string[] lastNames, double[] sales, int x, int y)
        {
            string tempFirst = firstNames[x];
            firstNames[x] = firstNames[y];
            firstNames[y] = tempFirst;

            string tempLast = lastNames[x];
            lastNames[x] = lastNames[y];
            lastNames[y] = tempLast;

            double tempSales = sales[x];
            sales[x] = tempSales;
            sales[y] = sales[x];
        }
    }
}
