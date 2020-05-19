using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int comNumber = random.Next(1, 200);
            int userNumber;

            do
            {
                Console.Write("숫자를 입력해주세요(1~200) : ");
                userNumber = int.Parse(Console.ReadLine());
                if (userNumber > comNumber)
                {
                    Console.WriteLine(userNumber + "보다는 작은 숫자 입니다.\n");
                }
                else if (userNumber < comNumber)
                {
                    Console.WriteLine(userNumber + "보다는 큰 숫자 입니다.\n");
                }
            } while (userNumber != comNumber);

            Console.WriteLine("정답입니다!!");
        }
    }
}
