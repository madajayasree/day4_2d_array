using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] companyEmpDetails;
            int[] customerBal;
            int eNo, eAccount;
            Console.WriteLine("How many employee do you want to enter: ");
            eNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of accounts of an employee: ");
            eAccount = Convert.ToInt32(Console.ReadLine());

            companyEmpDetails = new int[eNo, eAccount];
            customerBal = new int[eNo];

            for(int i=0; i < eNo; i++)
            {
                int temp = 0;
               Console.WriteLine("Enter emp{0} account details: " , i+1);
                Console.WriteLine("******************************");
                for(int j=0; j < eAccount; j++)
                {
                    Console.WriteLine("Enter  account{0} balance  : " , j+1);
                    companyEmpDetails[i, j] = Convert.ToInt32(Console.ReadLine());
                    temp = temp + companyEmpDetails[i, j];
                }
            }
            
            for (int i = 0; i < eNo; i++)
            {
               int temp = 0;
                Console.WriteLine("Enter emp{0} account details: ", i + 1);
                Console.WriteLine("******************************");
                for (int j = 0; j < eAccount; j++)
                {

                    Console.Write("{0, 15} ", companyEmpDetails[i, j]);
                    temp = temp + companyEmpDetails[i, j];
                    
                }
                Console.WriteLine();
               Console.WriteLine("account balance is {0} : " , temp);
                Console.WriteLine();
                }
            

        }
    }
}
