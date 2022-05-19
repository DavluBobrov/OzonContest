class Program
{
    static void Main()
    {
        int NumberInputData = int.Parse(Console.ReadLine());
        for (int i = 0; i < NumberInputData; i++)
        {
            int TelephonCount = int.Parse(Console.ReadLine());
            SortedList<string, SortedList<int, string>> TelephoneBook = new SortedList<string, SortedList<int, string>>();

            for (int j = 0; j < TelephonCount; j++)
            {
                string[] inputNumber = Console.ReadLine().Split(' ');
                string Name = inputNumber[0];
                string Telephone = inputNumber[1];
                if (TelephoneBook.ContainsKey(Name))
                {
                    if (TelephoneBook[Name].Values.Contains(Telephone))
                    {
                        var key = TelephoneBook[Name].Where(x => x.Value == Telephone).FirstOrDefault().Key;
                        TelephoneBook[Name].Remove(key);
                        TelephoneBook[Name].Add(j, Telephone);
                    }
                    else
                    {
                        if (TelephoneBook[Name].Keys.Count > 4)
                            TelephoneBook[Name].Remove(TelephoneBook[Name].Keys.Min());
                        TelephoneBook[Name].Add(j, Telephone);
                    }
                }
                else
                {
                    var addnamedata = new SortedList<int, string>();
                    addnamedata.Add(j, Telephone);
                    TelephoneBook.Add(Name, addnamedata);
                }
            }

            for (int j = 0; j < TelephoneBook.Count; j++)
            {
                Console.WriteLine($"{TelephoneBook.Keys[j]}: " +
                    $"{TelephoneBook[TelephoneBook.Keys[j]].Values.Count} " +
                    $"{String.Join(' ', TelephoneBook[TelephoneBook.Keys[j]].Values.Reverse())}");
            }
            Console.WriteLine();
        }
    }
}