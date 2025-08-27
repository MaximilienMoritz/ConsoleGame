using System;

internal class Example {
    public static void Main() {

        int xCounter = 0;
        int yCounter = ScreenGridManager.gridY-1;
        
        ConsoleKeyInfo cki = default;
        Console.TreatControlCAsInput = true;
        
        while (cki.Key != ConsoleKey.Escape) {
            cki = Console.ReadKey(true);
        
            if (cki.Key != ConsoleKey.None) {
                
                // Movement key handling
                switch (cki.Key) {
                    case ConsoleKey.A:
                        if (xCounter > 0 && xCounter <= ScreenGridManager.gridX) { 
                            xCounter--;
                        }
                        break;
                    
                    case ConsoleKey.D:
                        if (xCounter >= 0 && xCounter < ScreenGridManager.gridX-1) { 
                            xCounter++;
                        }
                        break;
                    
                    case ConsoleKey.W:
                        if (yCounter <= ScreenGridManager.gridY && yCounter > 0) { 
                            yCounter--;
                        }
                        break;
                    
                    case ConsoleKey.S:
                        if (yCounter < ScreenGridManager.gridY-1 && yCounter >= 0) { 
                            yCounter++;
                        }
                        break;
                }

                // Base for attacks
                switch (cki.Key) {
                    case ConsoleKey.I:
                        
                        break;
                    
                    case ConsoleKey.K:
                        
                        break;
                    
                    case ConsoleKey.J:
                        
                        break;
                    
                    case ConsoleKey.L:
                        
                        break;
                }
                
                // Render the screen
                ScreenGridManager.drawGrid(xCounter, yCounter);
                
                // Writes the Character's world position
                Console.WriteLine(xCounter.ToString() + "  " + yCounter.ToString());
                
            }
            
            
        }

    }


    private static ConsoleKey handleInputs() {
        ConsoleKeyInfo cki;
        // Prevent example from ending if CTL+C is pressed.
        Console.TreatControlCAsInput = true;

        Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
        Console.WriteLine("Press the Escape (Esc) key to quit: \n");
        do {
            cki = Console.ReadKey();
            //Console.Write(" --- You pressed ");
            // if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
            // if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
            // if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
            //Console.WriteLine(cki.Key.ToString());

            if (cki.Key == ConsoleKey.W) {
                
            }
            
        } while (cki.Key != ConsoleKey.Escape);

        return cki.Key;
    }

}
// This example displays output similar to the following:
//       Press any combination of CTL, ALT, and SHIFT, and a console key.
//       Press the Escape (Esc) key to quit:
//
//       a --- You pressed A
//       k --- You pressed ALT+K
//       ► --- You pressed CTL+P
//         --- You pressed RightArrow
//       R --- You pressed SHIFT+R
//                --- You pressed CTL+I
//       j --- You pressed ALT+J
//       O --- You pressed SHIFT+O
//       § --- You pressed CTL+U