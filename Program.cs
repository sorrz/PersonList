using System.Collections;

namespace PersonList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Skapa ett program som använder ArrayList för att spara listan av personer. 
             * Skapa en klass Person med namn och ålder och ToString() metoden för att skriva ut resultat.
             * Definiera ArrayList och få användaren att ange namn och ålder av tre personer. 
             * Spara i listan. 
             * Skriva ut data.
            */

            // ToString metod för att overrida Classen

            // Create ArrayList
            ArrayList persons = new ArrayList();

            // EntryMessage
            Console.WriteLine("Välkommen, vänligen lägg till 3 personer: \n\n");
            // Running the Method addPerson to add then 3 people and save them to the ArrayList
            addPerson(persons);


            // Print the Data in the ArrayList
            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
            // Wait for User
            Console.ReadKey();

        }

        // Creating a Person Class, with the Strings for Name and Age
        // with a Constructor to take then values from input


        public class Person
        {

            public string name = "";
            public string age = "";

            public Person(string name, string age)
            {
                this.name = name;
                this.age = age;
            }

            // Method override ToString for passing the Name and Age as a string
            public override string ToString()
            {
                return name + " " + age;
            }


        }

        public static void addPerson(ArrayList persons)
        {
            Console.WriteLine("Skriva namn på person 1: ");
            string p1Name = Console.ReadLine();
            Console.WriteLine("Skriv ålder på personen: ");
            string p1Age = Console.ReadLine();
            persons.Add(new Person(p1Name, p1Age));

            Console.WriteLine("Skriva namn på person 2: ");
            string p2Name = Console.ReadLine();
            Console.WriteLine("Skriv ålder på personen: ");
            string p2Age = Console.ReadLine();
            persons.Add(new Person(p2Name, p2Age));

            Console.WriteLine("Skriva namn på person 3: ");
            string p3Name = Console.ReadLine();
            Console.WriteLine("Skriv ålder på personen: ");
            string p3Age = Console.ReadLine();
            persons.Add(new Person(p3Name, p3Age));

           
        }


    }
}