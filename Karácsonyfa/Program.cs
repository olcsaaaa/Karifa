namespace Karácsonyfa
{
    internal class Program
    {
        static void Colorful(int i, int j)
        {
            if (i % 2 == 0)
            {
                if (j % 2 == 0)
                {
                    return;
                }
            }
            else
            {
                if (j % 2 != 0)
                {
                    return;
                }
            }

            if (j < 5)
            {
                int d20 = new Random().Next(20);
                switch (d20)
                {
                    case 0: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                    case 1: Console.ForegroundColor = ConsoleColor.White; break;
                    case 3: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                    case 4: Console.ForegroundColor = ConsoleColor.Magenta; break;
                    case 5: Console.ForegroundColor = ConsoleColor.White; break;
                    case 6: Console.ForegroundColor = ConsoleColor.Red; break;
                }
            }
            else
            {
                int d40 = new Random().Next(40);
                switch (d40)
                {
                    case 0: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                    case 1: Console.ForegroundColor = ConsoleColor.White; break;
                    case 3: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                    case 4: Console.ForegroundColor = ConsoleColor.Magenta; break;
                    case 5: Console.ForegroundColor = ConsoleColor.White; break;
                    case 6: Console.ForegroundColor = ConsoleColor.Red; break;
                }
            }
        }
        static void MediumTree()
        {
            // X:0 => Pos:16
            int x = 16;
            //width of branches
            int width = 1;
            int cutBack = 2;
            int linesAfterCut = 0;
            int maxWidth = 17;
            int height = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            while (width <= maxWidth)
            {
                Console.SetCursorPosition(x - height, height);
                for (global::System.Int32 j = 0; j < width; j++)
                {
                    if (j == 0 || j + 1 == width)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("A");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Colorful(height, j);
                        Console.Write("@");
                    }

                }
                width += 2;
                height++;
                linesAfterCut++;
                if (linesAfterCut >= (cutBack + 1))
                {
                    cutBack += 2;
                    width -= cutBack;
                    linesAfterCut = 0;
                    x += (cutBack / 2);

                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(14, height + i);
                Console.Write("|||||");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            MediumTree();
        }
    }
}