class OldCode
{
    static void VVV()
    {
        using (StreamReader ETALON = new StreamReader("09.a"))
        {
            using (StreamReader sr = new StreamReader("09"))
            {
                int NumberInputData = int.Parse(sr.ReadLine());
                for (int i = 0; i < NumberInputData; i++)
                {
                    sr.ReadLine();
                    int[] ColRow = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    int n = ColRow[0];
                    int m = ColRow[1];
                    int[][] Table = new int[n][];
                    for (int j = 0; j < n; j++)
                    {
                        Table[j] = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    }
                    int[][] BubbleTable = (int[][])Table.Clone();

                    int CountCkick = int.Parse(sr.ReadLine());
                    int[] NumberColumnClick = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    int[] sortedKey = new int[n];
                    //Buble sort
                    //var orderedNumbers = from zz in Table;
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
                        var temp = BubbleTable[0];
                        for (int k = 0; k < n; k++)
                        {
                            for (int kk = k + 1; kk < n; kk++)
                            {
                                if (BubbleTable[k][clickcol] > BubbleTable[kk][clickcol])
                                {
                                    temp = BubbleTable[k];
                                    BubbleTable[k] = BubbleTable[kk];
                                    BubbleTable[kk] = temp;
                                }
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Bubble");
                        Console.WriteLine($"NumberColumnClick[j] = {NumberColumnClick[j]}");
                        Console.ResetColor();
                        foreach (var item in BubbleTable)
                        {
                            Console.WriteLine(String.Join(' ', item));
                        }
                        Console.WriteLine();

                        //LINQ
                        var orderedNumbers = from zz in Table
                                             orderby zz[clickcol]
                                             select zz;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("LINQ");
                        Console.WriteLine($"NumberColumnClick[j] = {NumberColumnClick[j]}");
                        Console.ResetColor();
                        foreach (var item in orderedNumbers)
                        {
                            Console.WriteLine(String.Join(' ', item));

                        }
                        Console.WriteLine();
                        //
                        Array.Sort(sortedKey, Table);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ArraySort");
                        Console.WriteLine($"NumberColumnClick[j] = {NumberColumnClick[j]}");
                        Console.ResetColor();
                        foreach (var item in Table)
                        {
                            Console.WriteLine(String.Join(' ', item));
                        }
                        Console.WriteLine();

                    }
                    //foreach (var item in orderedNumbers)
                    //{
                    //    string Etalon = sr.ReadLine();
                    //    string result = String.Join(' ', item);
                    //    if (Etalon != result)
                    //    {
                    //        Console.WriteLine($"{i}-ый Fail");
                    //        break;
                    //    }
                    //}
                    //sr.ReadLine();
                    foreach (var item in Table)
                    {
                        var test = String.Join(' ', item);
                        var Etal = ETALON.ReadLine();
                        if (test != Etal)
                            Console.WriteLine($"{i}-ый FALSE");
                        //Console.WriteLine(String.Join(' ', item));

                    }
                    //Console.WriteLine();
                    ETALON.ReadLine();
                }
            }
        }
    }
}
