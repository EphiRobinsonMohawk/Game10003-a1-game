// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using Microsoft.VisualBasic.FileIO;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        bool rDown = false;
        bool gDown = false;
        bool bDown = false;
        int r = (Random.Integer(1, 256));
        int g = (Random.Integer(1, 256));
        int b = (Random.Integer(1, 256));
        int[] duckSpotsX = [10, 110, 210];
        int[] duckSpotsY = [10, 110, 210];
        float mousePosX = 175;
        float mousePosY = 175;
        Color yellow = new Color(249, 252, 33);
        Color orange = new Color(227, 130, 27);
        //Random.Integer(50, 350), Random.Integer(100, 300), Random.Integer(150, 250)
        ///     Setup runs once before the game loop begins.
        public void Setup()
        {

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            
            for (int i = 0; i < 3; i++)
            {

                    spawnDuck(duckSpotsX[i], duckSpotsY[i]);
            }
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                mousePosX = Input.GetMouseX() - 38;
                mousePosY = Input.GetMouseY() - 38;
            }

            Color color1 = new(r, g, b);
            Window.ClearBackground(color1);

            spawnDuck(mousePosX, mousePosY);
            if (rDown == false)
            {
                r++;
            }
            if (rDown == true)
            {
                r--;
            }
            if (r == 1)
            {
                rDown = false;
            }
            if (r == 256)
            {
                rDown = true;
            }
            if (gDown == false)
            {
                g++;
            }
            if (gDown == true)
            {
                g--;
            }
            if (g == 1)
            {
                gDown = false;
            }
            if (g == 256)
            {
                gDown = true;
            }
            if (bDown == false)
            {
                b++;
            }
            if (bDown == true)
            {
                b--;
            }
            if (b == 1)
            {
                bDown = false;
            }
            if (b == 256)
            {
                bDown = true;
            }

        }

        void spawnDuck(float x, float y)
        {
            //Neck
            Draw.FillColor = yellow;
            Draw.Rectangle(33 + x, 26 + y, 12, 18);

            //behind head (eye)
            Draw.FillColor = Color.Black;
            Draw.Circle(50 + x, 8 + y, 3);

            //Head
            Draw.FillColor = yellow;
            Draw.Circle(40 + x, 20 + y, 15);

            //infront of head (eye)
            Draw.FillColor = Color.Black;
            Draw.Circle(40 + x, 20 + y, 3);

            //Beak
            Draw.FillColor = orange;
            Draw.Triangle(53 + x, 18 + y, 65 + x, 30 + y, 50 + x, 25 + y);

            //Claw?
            Draw.FillColor = orange;
            Draw.Triangle(45 + x, 67 + y, 50 + x, 75 + y, 55 + x, 70 + y);

            //Claw Left
            Draw.FillColor = orange;
            Draw.Triangle(34 + x, 67 + y, 32 + x, 75 + y, 38 + x, 77 + y);

            //Body
            Draw.FillColor = yellow;
            Draw.Ellipse(40 + x, 55 + y, 42, 30);

            //Wing
            Draw.FillColor = yellow;
            Draw.Triangle(25 + x, 54 + y, 43 + x, 48 + y, 45 + x, 64 + y);
        }
    }

}
