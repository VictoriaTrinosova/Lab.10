using System;

namespace Lab._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Corner corner = new Corner(10,-10,10);
            corner.ToRadians();
            Console.ReadKey();

        }
    }
    class Corner
    {
        int gradus;
        int min;
        int sec;
        public int Gradus
        {
            set
            {
                if (value > 0 && value < 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Угол не может быть отрицательным и больше 360");
                }
            }
            get
            {
                return gradus;
            }
        }
              public int Min
        {
            set
            {
                if (value > 0 && gradus != 360)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Минуты не могут быть отрицательными. При угле 360 градусов значение минут равно 0");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value > 0 && gradus !=360)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Секунды не могут быть отрицательными. При угле 360 градусов значение секунд равно 0");
                }
            }
            get
            {
                return sec;
            }
        }
        public Corner(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        public void ToRadians()
        {

            double dec = (double)gradus + (min + (sec / 60)) / 60;
            double r = (dec * Math.PI) / 180;
            if (Gradus > 0 && Min > 0 && Sec > 0 && Gradus != 360)
            {
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }

        }

    }
    }

