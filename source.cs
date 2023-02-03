using System;
using System.Linq;
using System.Text;
using System.Threading;  //System.Threading is required for Animation.Wait()
using System.Collections.Generic;
using ConsoleGraphics;             //use these to reference the namespaces
using ConsoleGraphics.ConsoleGame;

namespace ConsoleGraphics
{
    namespace ConsoleGame
    {
        
        class Input
        {
            
            public static bool GetYN(string inputForYN)
            {
                
                if (inputForYN == "y" || inputForYN == "Y")
                {
                    
                    return true;
                    
                } else if (inputForYN == "n" || inputForYN == "N")
                {
                    
                    return false;
                    
                }
                return false;
                
            }
            
            
        }
        
    }
    
    class Draw
    {
        
        public static string topBorder = "═";
        public static string sideBorder = "║";
        public static string endSideBorder = "║\n";
        public static string filler = "#";
        public static string topLeftCorner = "╔";
        public static string topRightCorner = "╗\n";
        public static string bottomLeftCorner = "╚";
        public static string bottomRightCorner = "╝\n";
        
    }
    
    class Point : Draw
    {
        
        public int x = 0;
        public int y = 0;
        public char changePointTo = 'P';
        
        public Point(int _x, int _y, char point)
        {
            x = _x;
            y = _y;
            changePointTo = point;
            
        }
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
            
        }
    }
    
    class Animation : Draw
    {
        string[][] frameArray = new string[5][];
        
        
        public Animation()
        {
            frameArray[0] = new string[] {topLeftCorner, topBorder, topBorder, topBorder, topRightCorner};
            frameArray[1] = new string[] {sideBorder, filler, filler, filler, endSideBorder};
            frameArray[2] = new string[] {sideBorder, filler, filler, filler, endSideBorder};
            frameArray[3] = new string[] {sideBorder, filler, filler, filler, endSideBorder};
            frameArray[4] = new string[] {bottomLeftCorner, topBorder, topBorder, topBorder, bottomRightCorner};
            
        }
        
        public void ClearFrame()
        {
            
            Console.Clear();
            
        }
        
        public void Wait(int time)
        {
            
            Thread.Sleep(time);
            
        }
        
        public void SetPoint(Point point)
        {
            int x = point.x;
            int y = point.y;
            string changeToThisPixel = Convert.ToString(point.changePointTo);
            frameArray[y][x] = changeToThisPixel;
            
            
        }
        
        public void ResetPoint(Point point)
        {
            
            if(point.x >= 0 && point.y >= 0)
            {
             
                frameArray[point.y][point.x] = filler;
                
            }
            
        }
        
        public void DrawFrame()
        {
            
            foreach(string[] row in frameArray)
            {
                
                foreach(string pixel in row)
                {
                    
                    Console.Write(pixel);
                    
                }
                
            }
            
        }
    }
    

    class Title : Draw
    {
        
        
        public static void RenderSingleTitle(string titleText)
        {
            int width = titleText.Length + 2;
            Console.Write(topLeftCorner);
            for (int i = 1; i <= width; i++)
            {
                
                Console.Write(topBorder);
                
            }
            Console.Write(topRightCorner);
            Console.Write(sideBorder);
            Console.Write(" ");
            Console.Write(titleText);
            Console.Write(" ");
            Console.WriteLine(sideBorder);
            Console.Write(bottomLeftCorner);
            for (int i = 1; i <= width; i++)
            {
                
                Console.Write(topBorder);
                
            }
            Console.Write(bottomRightCorner);
            
        }
        
    }

    class Square : Draw
    {
        
        public static void RenderSquare(int widthCounter, int highthCounter)
        {
            Console.Write(topLeftCorner);
            for (int i = 1; i <= widthCounter; i++)
            {
                
                    
                    Console.Write(topBorder);
                    
                
            }
            Console.Write(topRightCorner);
            for (int i = 1; i <= highthCounter; i++)
            {
                
                Console.Write(sideBorder);
                if (i <= highthCounter)
                { 
                    for (int j = 1; j <= widthCounter; j++)
                    {
                        
                        Console.Write(filler);
                        
                    }
                    
                }
                Console.Write(endSideBorder);
                
                
            }
            Console.Write(bottomLeftCorner);
            for (int i = 1; i <= widthCounter; i++)
            {
                
                Console.Write(topBorder);
                
            }
            Console.Write(bottomRightCorner);
            
            
            
        }



    }
    
    
}
