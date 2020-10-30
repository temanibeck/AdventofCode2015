using AdventOfCode2015.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2015.DayFour
{
    public class DayFourSolver
    {
        private readonly string password = "yzbqklnj";

        private string CreateMD5(string password)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }

        public void SolvePartOne()
        {
            var count = 0;

            while(true){
                var currentPassword = password + count;
                var passwordHash = CreateMD5(currentPassword);
                var firstFive = passwordHash.Substring(0, 5);
                var hashKey = "00000";

                if (firstFive.Equals(hashKey))
                {
                    break;
                }
                else
                {
                    count++;
                }
            }

            Console.WriteLine($"The solution for Day Four Part One is {count}");
        }

        public void SolvePartTwo()
        {
            var count = 0;

            while (true)
            {
                var currentPassword = password + count;
                var passwordHash = CreateMD5(currentPassword);
                var firstFive = passwordHash.Substring(0, 6);
                var hashKey = "000000";

                if (firstFive.Equals(hashKey))
                {
                    break;
                }
                else
                {
                    count++;
                }
            }

            Console.WriteLine($"The solution for Day Four Part Two is {count}");
        }

        public void Execute()
        {

        }
    }
}
