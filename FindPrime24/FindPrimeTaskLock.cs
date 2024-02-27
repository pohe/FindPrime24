// See https://aka.ms/new-console-template for more information
public class FindPrimeTaskLock
{
    private List<int> _primes;

    private Object _lock = new object();
    public FindPrimeTaskLock()
    {
        _primes = new List<int>();
    }
    public void FindPrimesTaskLock(int upper)
    {
        _primes.Clear();
        int middle = upper / 2;
        Task t1 = Task.Run(() => FindPrimesInIntervalLock(2, middle));
        Task t2 = Task.Run(() => FindPrimesInIntervalLock(middle + 1, upper));
        t1.Wait();
        t2.Wait();
        string text = $"Found {_primes.Count} primes in [2; {upper}]";
        Console.WriteLine(text);
    }

    private void FindPrimesInIntervalLock(int lower, int upper)
    {
        for (int i = lower; i < upper; i++)
        {
            if (IsPrime(i))
            {
                lock (_lock)
                {
                    _primes.Add(i);
                }
            }
        }
    }


    private bool IsPrime(int number)
    {
        if (number < 4)
        {
            return true;
        }

        int limit = Convert.ToInt32(Math.Sqrt(number));
        bool isPrime = true;

        for (int i = 2; i <= limit && isPrime; i++)
        {
            isPrime = number % i != 0;
        }

        return isPrime;
    }
}