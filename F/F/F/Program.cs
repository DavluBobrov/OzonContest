class Program
{
    static void Main()
    {
        int NumberInputData = int.Parse(Console.ReadLine());
        for (int i = 0; i < NumberInputData; i++)
        {
            int NumberModels = int.Parse(Console.ReadLine());

            SortedList<string, List<string>> AllModels = new SortedList<string, List<string>>();

            for (int j = 0; j < NumberModels; j++)
            {
                var Input = Console.ReadLine().Split(' ');
                string NameModel = Input[0].Substring(0, Input[0].Length-1);
                if (AllModels.ContainsKey(NameModel))
                {
                    AllModels[NameModel].AddRange(Input.Skip(1));
                }
                else
                {
                    AllModels.Add(NameModel, new List<string>());
                }
            }

            Dictionary<string, bool> IsCompileModel = new Dictionary<string, bool>();

            for (int j = 0; j < AllModels.Keys.Count; j++)
            {
                IsCompileModel.Add(AllModels.Keys[j], false);
            }

            int NumberRequests = int.Parse(Console.ReadLine());

            for (int j = 0; j < NumberRequests; j++)
            {
                string inputmodel = Console.ReadLine();
                if (!IsCompileModel[inputmodel])
                {
                    Console.WriteLine(0);
                }
                else
                {

                }
            }


            Console.WriteLine();
        }


    }

}