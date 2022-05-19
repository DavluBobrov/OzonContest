class Program
{
    static void Main()
    {
        int NumberInputData = int.Parse(Console.ReadLine());
        for (int i = 0; i < NumberInputData; i++)
        {
            int RegisterCount = int.Parse(Console.ReadLine());
            bool[] result = new bool[RegisterCount];
            Dictionary<string, string> ValidLoginCollection = new Dictionary<string, string>();
            for (int j = 0; j < RegisterCount; j++)
            {
                bool isValidLOgin = true;
                string inputLogin = Console.ReadLine();
                if (inputLogin.Length < 2 || inputLogin.Length > 24 || inputLogin[0] == '-')
                {
                    isValidLOgin = false;
                    result[j] = isValidLOgin;
                    continue;
                }
                foreach (var item in inputLogin)
                {
                    if (!char.IsLetter(item))
                        if (!char.IsDigit(item))
                            if (item != '-') if (item != '_')
                                {
                                    isValidLOgin = false;
                                    result[j] = isValidLOgin;
                                    break;
                                }

                }
                if (!isValidLOgin) continue;

                
                if (!ValidLoginCollection.Keys.Contains(inputLogin.ToLower()))
                    ValidLoginCollection.Add(inputLogin.ToLower(), inputLogin);
                else
                {
                    isValidLOgin = false;
                    result[j] = isValidLOgin;
                    continue;
                }

                result[j] = isValidLOgin;
            }

            foreach (var item in result)
            {
                Console.WriteLine(item ? "YES" : "NO");
            }
        }
    }
}