class TheFirstNonRepeatingCharacter
    {
        static char[] count = new char[150];

        // Harflerin kaç kere tekrar ettiğini bir dizide tutuyoruz
        static void letterCount(string str)
        {
            for (int i = 0; i < str.Length; i++)
                count[str[i]]++;
        }

        // Sırayla harflerin kaç kere tekrar ettiğine bakıyoruz
        static int repeatingString(string str)
        {
            int index = -1;
            int i;

            letterCount(str);

            for (i = 0; i < str.Length; i++)
            {
                if (count[str[i]] == 1)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public static void Main()
        {            
            Console.WriteLine("Bir kelime giriniz:");
            string str = Console.ReadLine();

            int index = repeatingString(str);

            Console.WriteLine(index == -1 ? "Harfler birden fazla tekrar içeriyor." : "İlk tekrarsız harf : " + str[index]);
        }
    }
