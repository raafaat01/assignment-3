class PrimeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to find all prime numbers between 1 and that number: ");
        int n = int.Parse(Console.ReadLine());
        bool[] prime = new bool[n + 1];
        for (int i = 0; i < n; i++)
            prime[i] = true;

        for (int p = 2; p * p <= n; p++)
        {
            if (prime[p] == true)
            {
                for (int i = p * p; i <= n; i += p)
                    prime[i] = false;
            }
        }
        Console.WriteLine("Prime numbers between 1 and {0} are:", n);
        for (int i = 2; i <= n; i++)
            if (prime[i] == true)
                Console.Write(i + " ");
    }
}
