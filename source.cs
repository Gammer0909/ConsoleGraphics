
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
        public static string topRightCorner = "╗";
        public static string bottomLeftCorner = "╚";
        public static string bottomRightCorner = "╝";
        
    }
    

    class Title : Draw
    {
        
        
        public static void SingleTitle(string titleText)
        {
            int width = titleText.Length + 2;
            Console.Write(topLeftCorner);
            for (int i = 1; i <= width; i++)
            {
                
                Console.Write(topBorder);
                
            }
            Console.Write(topRightCorner + "\n");
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
            Console.Write(bottomRightCorner + "\n");
            
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
            Console.Write(topRightCorner + "\n");
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
