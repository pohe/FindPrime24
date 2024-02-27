// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, FindPrime24!");
#region FindPrimeSeq
//FindPrimeSeq pc = new FindPrimeSeq();
//Console.WriteLine("Find prime - sekventielt");
//pc.FindPrimes(1000000);
#endregion

#region FindPrimeTask
//FindPrimeTask tc = new FindPrimeTask();
//Console.WriteLine("Find prime - Task1");
//tc.FindPrimesTask(1000000);
//Console.WriteLine("Find prime - Task2");
//tc.FindPrimesTask(1000000);
//Console.WriteLine("Find prime - Task3");
//tc.FindPrimesTask(1000000);
//Console.WriteLine("Find prime - Task4");
//tc.FindPrimesTask(1000000);
#endregion

#region FindPrimeTaskLock
//FindPrimeTaskLock lc = new FindPrimeTaskLock();
//Console.WriteLine("Find prime - Task1 -Lock");
//lc.FindPrimesTaskLock(1000000);
//Console.WriteLine("Find prime - Task2 -Lock");
//lc.FindPrimesTaskLock(1000000);
//Console.WriteLine("Find prime - Task3 -Lock");
//lc.FindPrimesTaskLock(1000000);
#endregion

#region ConcurrentBag
//PrimeCalcConcurrentBag PCCB = new PrimeCalcConcurrentBag();
//Console.WriteLine("Find prime - ConcurrentBag");
//PCCB.FindPrimesTask(1000000);
#endregion

#region Parallel
//Console.WriteLine("Find prime - ConcurrentBag Parallel.For");
//PCCB.FindPrimesPar(1000000);
#endregion
Console.ReadKey();