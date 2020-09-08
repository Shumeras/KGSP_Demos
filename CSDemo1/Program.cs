using System;
using System.Collections.Generic;

namespace CSDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cr = new ConsoleRenderer();
            var test = ReadFile("./Demo.txt");
            
            cr.Init(test);

            while(true)
            {
                System.Threading.Thread.Sleep(100);
                test = CellAutomata.Calculate(test);
                
                cr.Clear();
                cr.Render(test);
            }
        }

        static bool[,] ReadFile(string dir)
        {
            bool[,] result;
            try 
            {
                string[] lines = System.IO.File.ReadAllLines(dir);
                result = new bool[lines[0].Length, lines.Length];
                for(int y = 0; y < lines.Length; y++)
                    for(int x = 0; x < lines[0].Length; x++)
                    {
                        if(lines[y][x] == '#') result[x,y] = true;    
                    }

            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
                return null;
            }

            return result;
        }
    }

    class ConsoleRenderer
    {

        private char cellChar; 
        private char edgeChar;
        private char emptyChar;
        
        private int width = 0;
        private int height = 0;


        public ConsoleRenderer( char cellChar = '■' , char edgeChar = '░', char emptyChar = ' ')
        {
            this.cellChar = cellChar;
            this.edgeChar = edgeChar;
            this.emptyChar = emptyChar;
        }

        public void Init(bool[,] grid)
        {
            width = grid.GetLength(0);
            height = grid.GetLength(1);

            Console.Clear();
            Console.SetWindowSize(width+20, height+10);

            for(int x = 0; x < width+2; x++)
            {
                DrawChar(x, 0, edgeChar);
                DrawChar(x, height+1, edgeChar);
            } 

            for(int y = 0; y < height+1; y++)
            {
                DrawChar(0, y+1, edgeChar);
                DrawChar(width+1, y+1,edgeChar);
            } 

            Console.SetCursorPosition(0, height+2);
            System.Console.WriteLine("Press ctrl+c to exit");
        }

        public void Clear()
        {
            for(int x = 1; x <= width; x++)
                for(int y = 1; y <= height; y++)
                    DrawChar(x, y, emptyChar);

            Console.SetCursorPosition(0, height+2);
        }   

        public void Render(bool[,] grid)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for(int x = 0; x < width; x++)
                for(int y = 0; y < height; y++)
                {
                    if(grid[x,y])
                        DrawChar(x+1,y+1, cellChar);
                }

            Console.ResetColor();
            Console.SetCursorPosition(0, height+2);
        } 

        private void DrawChar(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }

    public static class CellAutomata
    {
        public static bool[,] Calculate(bool[,] grid)
        {
            var result = new bool[grid.GetLength(0), grid.GetLength(1)];

            for(int x = 0; x < grid.GetLength(0); x++)
            {
                for(int y = 0; y < grid.GetLength(1); y++)
                {
                    result[x,y] = CheckIsCellAllive(x,y, grid[x,y], grid);
                }
            }
            
            return result;
        }

        private static bool CheckIsCellAllive(int x, int y, bool cellAllive, bool[,] grid)
        {
            int neighbourCount = 0,
                width = grid.GetLength(0),
                height = grid.GetLength(1);

            var checkDirections = new List<(int,int)>();

            if(x > 0 && y > 0)              checkDirections.Add((-1,-1));
            if(y > 0)                       checkDirections.Add((0,-1));
            if(x+1 < width && y > 0)        checkDirections.Add((+1,-1));
            if(x > 0)                       checkDirections.Add((-1, 0));
            if(x+1 < width)                 checkDirections.Add((+1, 0));
            if(x > 0 && y+1 < height)       checkDirections.Add((-1, +1));
            if(y+1 < height)                checkDirections.Add((0, +1));
            if(x+1 < width && y+1 < height) checkDirections.Add((+1,+1));
            
            foreach(var dir in checkDirections)
            {
                if(grid[x+dir.Item1, y+dir.Item2]) neighbourCount++;
            }

            return neighbourCount == 3 || (neighbourCount == 2 && cellAllive) ? true : false;
        }

    }

}
