class Program
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            var num = Console.ReadLine();
            Console.WriteLine(CheckPerfectNumber(int.Parse(num))); 

             bool CheckPerfectNumber(int num)
            {
                var divisors = new List<int>();
                for (var i = 1; i < num; i++)
                    if (num % i == 0)
                        divisors.Add(i);
                var sum = divisors.Sum();
                return sum == num;

            }

        }
    }
}
