class Program
{
    static void Main()
    {
        int NumberInputData = int.Parse(Console.ReadLine());
        for (int i = 0; i < NumberInputData; i++)
        {
            Console.ReadLine();
            int[] inputConfig = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int KupeCount = inputConfig[0];
            int RequestCount = inputConfig[1];

            Dictionary<int, bool> KupeMap = new Dictionary<int, bool>();
            for (int j = 1; j <= KupeCount * 2; j++)
            {
                KupeMap.Add(j, false);
            }
            for (int k = 0; k < RequestCount; k++)
            {
                int[] inputRequest = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                switch (inputRequest[0])
                {
                    case 1: // Команда 1
                        if (KupeMap[inputRequest[1]])
                        {
                            Console.WriteLine("FAIL");
                        }
                        else
                        {
                            Console.WriteLine("SUCCESS");
                            KupeMap[inputRequest[1]] = true;
                        }
                        break;
                    case 2: // Команда 2
                        if (KupeMap[inputRequest[1]])
                        {
                            Console.WriteLine("SUCCESS");
                            KupeMap[inputRequest[1]] = false;
                        }
                        else
                        {
                            Console.WriteLine("FAIL");
                        }
                        break;
                    case 3:
                        bool isFreeKupe = false;
                        for (int j = 2; j <= KupeCount * 2; j = j + 2)
                        {
                            if (!(KupeMap[j] || KupeMap[j - 1]))
                            {
                                Console.WriteLine($"SUCCESS {j - 1}-{j}");
                                KupeMap[j] = true;
                                KupeMap[j - 1] = true;
                                isFreeKupe = true;
                                break;
                            }
                        }
                        if (!isFreeKupe) Console.WriteLine("FAIL");
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}