namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Page pageFirst = new Page() { Content = "Nowadays, there are various (...)" };
            Page pageSecond = new Page() { Content = "Application development is (...)" };
            Page pageThird = new Page() { Content = "A lot of applications (...)" };
            Page pageFourth = new Page() { Content = "Do you know that modern (...)" };
            Page pageFifth = new Page() { Content = "While developing applications (...)" };
            Page pageSixth = new Page() { Content = "Could you imagine your (...)" };

            LinkedList<Page> pages = new LinkedList<Page>();
            pages.AddLast(pageSecond);
            LinkedListNode<Page> nodePageForth = pages.AddLast(pageFourth);
            pages.AddLast(pageSixth);
            pages.AddFirst(pageFirst);
            pages.AddBefore(nodePageForth, pageThird);
            pages.AddAfter(nodePageForth, pageFifth);

            LinkedListNode<Page> current = pages.First;
            int number = 1;
            while (current != null)
            {
                Console.Clear();
                string numberString = $"- {number} -";
                int leadingSpaces = (90 - numberString.Length) / 2;
                Console.WriteLine(numberString.PadLeft(leadingSpaces + numberString.Length));
                Console.WriteLine();

                string content = current.Value.Content;
                for (int i = 0; i < content.Length; i += 90)
                {
                    string line = content.Substring(i);
                    line = line.Length > 90 ? line.Substring(0, 90) : line;
                    Console.WriteLine(line);
                }

                Console.WriteLine();

                Console.WriteLine($"Quote from page Packt Book {Environment.NewLine}{current.Value.Content}");

                Console.WriteLine();

                Console.Write(current.Previous != null ? "Press 'P' to go to the previous page. " : GetSpaces(14));

                Console.Write(current.Next != null ? "Press 'N' to go to the next page. " : string.Empty);

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.P:
                        if (current.Previous != null)
                        {
                            current = current.Previous;
                            number--;
                        }
                        break;
                    case ConsoleKey.N:
                        if (current.Next != null)
                        {
                            current = current.Next;
                            number++;
                        }
                        break;
                    default:
                        return;
                }
            }
        }

        private static string GetSpaces(int number)
        {
            string result = string.Empty;
            for (int i = 0; i < number; i++)
            {
                result += " ";
            }
            return result;
        }
    }
}