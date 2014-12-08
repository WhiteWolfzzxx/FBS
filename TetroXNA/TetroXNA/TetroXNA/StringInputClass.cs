﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TetroXNA
{
    public class StringInputClass
    {
        private bool keyDidSomething = false;
        private bool keyPressed = false;
        private KeyboardState keyboard;
        private string playerName = "";

        public string getName() { return playerName; }
        public bool getKeyDidSomething() { return keyDidSomething; }
        public bool getKeyPressed() { return keyPressed; }

        public StringInputClass()
        {

        }

        public void Update(GameTime gameTime)
        {
            keyboard = Keyboard.GetState();

            alphabet();

            //Single Key press Space
            if (keyPressed && keyDidSomething)
            {
                keyDidSomething = true;
            }
            else
            {
                keyDidSomething = false;
            }
        }

        //I wish there was a better way
        private void alphabet()
        {
            if (keyboard.IsKeyDown(Keys.A))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "A";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.B))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "B";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.C))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "C";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.D))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "D";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.E))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "E";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.F))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "F";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.G))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "G";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.H))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "H";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.I))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "I";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.J))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "J";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.K))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "K";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.L))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "L";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.M))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "M";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.N))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "N";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.O))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "O";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.P))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "P";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.Q))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "Q";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.R))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "R";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.S))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "S";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.T))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "T";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.U))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "U";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.V))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "V";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.W))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "W";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.X))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "X";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.Y))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "Y";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.Z))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    playerName += "Z";
                    keyDidSomething = true;
                }
            }
            else if (keyboard.IsKeyDown(Keys.Back))
            {
                keyPressed = true;
                if (!keyDidSomething)
                {
                    if (playerName.Length > 0)
                    {
                        playerName = playerName.Substring(0, playerName.Length - 1);
                    }
                    keyDidSomething = true;
                }
            }
            else
            {
                keyPressed = false;
            }
        }
    }
}