namespace KodetimeM3_klasserOgConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, M3!");
            Console.WriteLine("Let's Write some Code!");

            //random høyde & random vekt
            //Random random = new Random();

            var Bjørbar = new Person("Bjørbar");
            var Adrian = new Person("Adrian");
            var Marijani = new Person("Marijani");


            Console.WriteLine("Who do you want to bring into this world?");

            var userInputName = Console.ReadLine();

            var userCreatedPerson = new Person(userInputName);

            //var basket = new Person[]
            //{
            //    Bjørbar,
            //    Adrian,
            //    Marijani,
            //    userCreatedPerson
            //};

            var basket = new List<Person>
            {
                    Bjørbar,
                    Adrian,
                    Marijani,
                    userCreatedPerson
            };

            //for (var i = 0; i < basket.Length; i++)
            //{
            //    basket[i].PrintInfo();
            //}

            foreach (var person in basket)
            {
                person.PrintInfo();
            }


            //Bjørbar.PrintInfo();
            //Adrian.PrintInfo();



            //bruke en funksjon fra en annen klasse
            //constructors!
            //random!
            //array / list


            //person som blir født og har en random vekt og høyde

        }
    }
}