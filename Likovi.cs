using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTTER
{
    public abstract class Likovi : Sprite
    {
        protected int brzina;
        public int Brzina { get { return brzina; } set { brzina = value; } }


        protected int zivot;
        public int Zivot { get => zivot; set => zivot = value; }

        public Likovi(string slika, int xcor, int ycor, int zivot, int brzina): base(slika, xcor, ycor)
        {
            this.zivot = 3;
            this.brzina=-7;
        }
    }
    public abstract class Oruzje : Sprite
    {
        protected int snaga;

        public int Snaga
        {
            get { return snaga; }
            set
            {
                if (value <= 0)
                {
                    throw (new ArgumentException());
                }
                else
                {
                    snaga = value;
                }
            }
        }
        protected int brzina;

        public int Brzina
        {
            get { return brzina; }
            set
            {
                if (value <= 0)
                {
                    brzina = 1;
                }
                else
                {
                    brzina = value;
                }
            }
        }
        public Oruzje(string slika, int xcor, int ycor, int snaga, int brzina)
           : base(slika, xcor, ycor)
        {
            this.snaga = snaga;
            this.brzina = brzina;
        }


    }
    public class Top : Likovi
    {
        protected int bodovi;
        public int Bodovi { get => bodovi; set => bodovi = value; }

        public override int X
        {
            get { return this.x; }
            set
            {
                if (value < GameOptions.LeftEdge)
                {
                    x = GameOptions.LeftEdge;
                }
                else if (value > GameOptions.RightEdge - this.Width)
                {
                    x = GameOptions.RightEdge - this.Width;
                }
                else
                {
                    x = value;
                }
            }
           
        }
        public override int Y
        {
            get { return this.y; }
            set
            {
                if (value < GameOptions.UpEdge)
                {
                    y = GameOptions.UpEdge;
                }
                else if (value > GameOptions.DownEdge - this.Heigth)
                {
                    y = GameOptions.DownEdge - this.Heigth+10;
                }
                else
                {
                    y = value;
                }
            }

        }

        public int Level { get => _level; set => _level = value; }

        public bool bulletReady;
        private int _level;

        public Top(string slika, int xcor, int ycor) : base(slika, xcor, ycor, 1, 2)
        {
            this.bodovi = 0;
            this.bulletReady = true;
        }

    }
    public class Vatra : Likovi
    {
        protected int bodovi;
        public int Bodovi { get => bodovi; set => bodovi = value; }

        public Vatra( string r, int x, int y) : base(r, x, y,1,2)
        {

            this.brzina = -7;
            this.Zivot = 1;
            this.bodovi = 1;
        }

    }
    public class VodenaKugla : Oruzje
    {
        public VodenaKugla(string p, int posX, int posY) : base(p, posX, posY,1,30)
        {

        }

    }
}

