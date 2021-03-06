using System;

namespace bouncingBall {
	class MainClass {
    	public static void Main (string[] args) {
        	Console.Clear();
        	Console.CursorVisible = false;
        	setCurs(20, 5);
        	Console.Write("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

        	for (int i = 0; i < 10; i++) {
        	    setCurs(20, i + 6);
           	 	Console.Write("X");
           	 	setCurs(60, i + 6);
           	 	Console.Write("X");
        	}

        	setCurs(20, 15);
        	Console.Write("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

        	Bounce();
    	}

    	private static void setCurs(int x, int y) {
        	Console.SetCursorPosition(x, y);
    	}

    	private static void Bounce() {
        	int times = 300;
        	int loops = 0;
        	int x = 25;
        	int y = 10;
        	int xInc = 1;
        	int yInc = 1;

        	while (loops < times) {
            	loops++;

            	setCurs(x, y);
            	Console.Write("O");

            	System.Threading.Thread.Sleep(70);

            	setCurs(x, y);
            	Console.Write(" ");

            	if (x == 21 || x == 59) {
                	xInc = -xInc;
            	}
            	if (y == 6 || y == 14) {
                	yInc = -yInc;
            	}

            	x += xInc;
            	y += yInc;
        	}
    	}
	}
}
