namespace Karácsonyfa
{
    internal class Program
    {
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
            while(width<=maxWidth)
            {
                Console.SetCursorPosition(x - height, height);
                for (global::System.Int32 j = 0; j < width; j++)
                {
                    Console.Write("A");
                }
                width += 2;
                height++;
                linesAfterCut++;
                if (linesAfterCut >= (cutBack + 1))
                {
                    width -= cutBack;
                    linesAfterCut = 0;
                    x += (cutBack / 2);
                    cutBack += 2;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(14,height+i);
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