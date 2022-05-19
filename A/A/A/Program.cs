class Program
{
    static void Main()
    {
        int NumberInputData = int.Parse(Console.ReadLine());
        for (int i = 0; i < NumberInputData; i++)
        {
            int count = int.Parse(Console.ReadLine());
            int[] Data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Dictionary<int, int> keyValues = new Dictionary<int, int>();

            for (int j = 0; j < Data.Length; j++)
            {
                if (keyValues.Keys.Contains(Data[j]))
                    keyValues[Data[j]]++;
                else
                    keyValues.Add(Data[j], 1);
            }
            int sum = 0;
            foreach (var item in keyValues.Keys)
            {
                sum += item * (keyValues[item] / 3 *2) + item * (keyValues[item] % 3);
            }
            Console.WriteLine(sum);
        }
    }
}