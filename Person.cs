
namespace KodetimeM3_klasserOgConstructors
{
    public class Person
    {
        public string Name { get; private set; } //private set: kan bare endre data INNENFRA denne klassen
        public int Age { get; private set; }
        public int Height { get; private set; }
        public int Weight { get; private set; }

        private Random random = new Random();

        public Person(string name, int age, int height, int weight)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public Person(string name)
        {
            Name = name;
            Age = 0;
            Height = name == "Bjørbar" ? 75 : random.Next(30, 41);
            Weight = random.Next(400, 7001);
        }


        public void PrintInfo()
        {
            string bonusPhrase = "You are a very average person..?";
            //event om høyere enn så og så eller lavere enn så som så
            if (Height >= 35) { bonusPhrase = "You are very tall!"; }
            else if (Height <= 32) { bonusPhrase = "You a little bit short :)"; }
            
            Console.WriteLine($"Velkommen til verden {Name}! Du er {Age} år gammel, " +
                $"{Height}cm høy, og veier {Weight}g! {bonusPhrase}");
        }
    }
}
