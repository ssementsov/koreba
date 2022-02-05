namespace Lesson015_Taksa
{
    class Program
    {
        static void Main()
        {
            //Taksa x = new Taksa();
            //x.ShowSize();
            //Taksa y = new StandartTaksa();
            //y.ShowSize();

            //Canary canary = new();
            //canary.Fly(nameof(Canary));
            //Ostrich ostrich = new();
            //ostrich.Fly(nameof(Ostrich));

            //Bird bird = new Canary();
            //bird.Fly(nameof(Canary));
            //bird = new Ostrich();
            //bird.Fly(nameof(Ostrich));

            Bird[] birds = { new Canary(), new Ostrich() };

            for (var i = 0; i < birds.Length; i++)
            {
                birds[i].Fly(birds[i].ToString());
            }
        }
    }
}