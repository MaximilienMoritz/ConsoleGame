// See https://aka.ms/new-console-template for more information

public static class ScreenGridManager {
    public const int gridX = 20;
    public const int gridY = 5;

    public static int[,] grid;
    
    public static void drawGrid(int x, int y) {

        grid = new int[gridX, gridY];
       

        string output = "";
        for (int i = 0; i < gridY; i++) {
            for (int j = 0; j < gridX; j++) {
                if (i == x) {
                    output = "O";
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                } else {
                    output = "U";
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                
                Console.Write(output);
                
            }
            
            
            //Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.Write(output);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            
            output = "";
        }
        
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("a");
    }
}