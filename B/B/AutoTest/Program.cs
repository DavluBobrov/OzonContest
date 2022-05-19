class Program
{
    static void Main()
    {
        int NumberInputData = int.Parse(Console.ReadLine());
        for (int i = 0; i < NumberInputData; i++)
        {
            Console.ReadLine();
            int[] ColRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = ColRow[0];
            int m = ColRow[1];
            int[][] Table = new int[n][];
            for (int j = 0; j < n; j++)
            {
                Table[j] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            int CountCkick = int.Parse(Console.ReadLine());
            int[] NumberColumnClick = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sortedKey = new int[n];

            int clickcol = -10;
            for (int j = 0; j < CountCkick; j++)
            {
                if (clickcol == NumberColumnClick[j] - 1)
                {
                    continue;
                }
                else
                {
                    clickcol = NumberColumnClick[j] - 1;
                }
                for (int jj = 0; jj < n; jj++)
                {
                    sortedKey[jj] = Table[jj][clickcol];
                }
                var orderedNumbers = from zz in Table
                                     orderby zz[clickcol]
                                     select zz;
                int s = 0;
                foreach (var item in orderedNumbers)
                {
                    Table[s] = item;
                    s++;
                }
            }
            foreach (var item in Table)
            {
                Console.WriteLine(String.Join(' ', item));
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}