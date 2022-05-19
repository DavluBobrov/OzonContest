class AutoTest
{
    static void Main()
    {
        for (int qq = 9; qq <= 9; qq++)
        {
            Console.WriteLine($"Тест № {qq}");
            var startTime = DateTime.Now;
            using (StreamReader inputSR = new StreamReader($"{qq.ToString().PadLeft(2, '0')}"))
            {
                using (StreamReader outputSR = new StreamReader($"{qq.ToString().PadLeft(2, '0')}.a"))
                {
                    int NumberInputData = int.Parse(inputSR.ReadLine());
                    for (int i = 0; i < NumberInputData; i++)
                    {
                        inputSR.ReadLine();
                        int[] ColRow = inputSR.ReadLine().Split(' ').Select(int.Parse).ToArray();
                        int n = ColRow[0];
                        int m = ColRow[1];
                        int[][] Table = new int[n][];
                        for (int j = 0; j < n; j++)
                        {
                            Table[j] = inputSR.ReadLine().Split(' ').Select(int.Parse).ToArray();
                        }
                        int[][] BubbleTable = (int[][])Table.Clone();

                        int CountCkick = int.Parse(inputSR.ReadLine());
                        int[] NumberColumnClick = inputSR.ReadLine().Split(' ').Select(int.Parse).ToArray();
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
                            //Console.WriteLine(String.Join(' ', item));
                            var test = String.Join(' ', item);
                            var Etal = outputSR.ReadLine();
                            if (test != Etal)
                            {
                                Console.WriteLine($"{i}-ый FALSE");
                                //break;
                            }
                        }
                        outputSR.ReadLine();
                    }

                    var timeEnd = DateTime.Now;
                    Console.WriteLine($"Время прогона: {timeEnd - startTime}ms");
                }
            }
        }
    }
}
