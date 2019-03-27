using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class GameState
    {
        public static bool end = false;
        Worm w = new Worm('O');
        Food f = new Food('@');
        Wall b = new Wall('#');
        public int level = 1;

        public GameState()
        {
            Console.SetWindowSize(40, 41);
            Console.SetBufferSize(40, 41);
            Console.CursorVisible = false;
        }
        public void Draw()
        {
            if (!end)
            {
                w.Draw();
            }

            f.Draw();
            b.Draw();



        }
        public bool eating = new bool();
        void CheckFood()
        {
            if (w.CheckCollision(f.body[0]))
            {
                eating = true;
                w.Eat(f.body[0]);
                Bally.Score += 10;
                f.Generate();
                foreach (Point p in b.body)
                {
                    if (f.body[0].X == p.X && f.body[0].Y == p.Y)
                    {
                        f.Generate();
                        f.Draw();
                    }
                }
                foreach (Point p in w.body)
                {
                    if (p.X == f.body[0].X && p.Y == f.body[0].Y && !eating)
                    {
                        f.Generate();
                        f.Draw();
                    }
                }
                eating = false;
            }
        }
        void GameOver()
        {
            end = true;
            Console.SetCursorPosition(15, 20);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GAME OVER!\n" + "\t    YOUR SCORE IS " + (Bally.Score + Bally.PrevS));
        }
        void CheckWall()
        {
            foreach (Point el in b.body)
            {
                if (w.CheckCollision(el))
                {
                    GameOver();
                }
            }
        }
        void CheckBody()
        {
            for (int i = 4; i < w.body.Count-1; ++i)
            {
                if (w.CheckCollision(w.body[i - 1]))
                {
                    GameOver();
                }
            }
        }
        public string movement = null;
        public void PressedKey(ConsoleKeyInfo consoleKeyInfo)
        {
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (w.body.Count > 1)
                    {
                        if (movement != "down")
                        {
                            w.Move(0, -1);
                            movement = "up";
                        }
                    }
                    else
                    {
                        w.Move(0, -1);
                        movement = "up";
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (w.body.Count > 1)
                    {
                        if (movement != "up")
                        {
                            w.Move(0, 1);
                            movement = "down";
                        }
                    }
                    else
                    {
                        w.Move(0, 1);
                        movement = "down";
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (w.body.Count > 1)
                    {
                        if (movement != "right")
                        {
                            w.Move(-1, 0);
                            movement = "left";
                        }
                    }
                    else
                    {
                        w.Move(-1, 0);
                        movement = "left";
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (w.body.Count > 1)
                    {
                        if (movement != "left")
                        {
                            w.Move(1, 0);
                            movement = "right";
                        }
                    }
                    else
                    {
                        w.Move(1, 0);
                        movement = "right";
                    }
                    break;
            }

            CheckFood();
            if (Bally.Score >= 20)
            {
                b.body.Clear();
                Console.Clear();
                b.LoadLevel(2);
                Bally.PrevS += Bally.Score;
                Bally.Score = 0;
            }
            CheckWall();
            if (w.body.Count >= 4)
            {
                CheckBody();
            }
        }
    }
}