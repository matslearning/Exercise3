using System;
using System.Collections.Generic;
using System.Xml;

namespace Exercise3
{
    // Svar på F-uppgifter:
    // 3.2.13. Bör då läggas i klassen Bird
    //
    // 3.2.14. Bör då läggas i klassen Animal
    //
    // 3.3.9.  Fungerar inte eftersom Horse inte ärver från Dog eller från någon subklass till Dog
    //
    // 3.3.10  Listan måste vara av typen Animal, för att alla klasser skall kunna lagras där
    //
    // 3.3.13  Varje superklass skriver ut "sina" properties i en sträng.
    //         Subklasserna tar denna sträng och fyller på med sina egna properties.
    //
    // 3.3.17  Dog-metoden nås inte eftersom objektet behandlas som Animal i foreach-loopen.
    //         Man måste först casta objektet till Dog för att kunna nå metoden.
    //
    // 3.4.11  Det är viktigt för att vi skall kunna bygga och hantera klasser i hierarkier,
    //         så att man kan återanvända kod istället för att skriva redundant kod.
    //
    // 3.4.12  Koden blir (förhoppningsvis) lättare att strukturera, testa samt kanske även att felsöka.
    //
    //         För mig var fråga 11 och 12 här ovan litet knepiga att svara på,
    //         men jag kanske fick till hyfsat bra svar.
    //
    // 3.4.13  Ett Interface definierar vilka metoder som skall implementeras - av klasser som implementerar
    //         detta interface - men interfacet självt innehåller inte någon implementation. En abstrakt klass
    //         kan däremot innehålla färdigimplementerade såväl som abstrakta metoder samt kan även innehålla
    //         t.ex. properties. Man kan kanske säga att en abstrakt klass ligger någonstans
    //         mellan interface och "konkret" klass.

    class Program
    {
        static string newLine = Environment.NewLine;
        static void Main(string[] args)
        {
            // 3.1 Inkapsling

            // var person = new Person();
            var handler = new PersonHandler();

            //Skapa personobjekt via handler
            try
            {
                var person1 = handler.CreatePerson(20, "Adam", "Bertilsson", 180.5, 78.5);
                var person2 = handler.CreatePerson(30, "Britta", "Björkblad", 168, 64);
                var person3 = handler.CreatePerson(40, "Hugo", "Boss", 176, 82);
                // Fem anrop för att visa felmeddelanden - avkommentera valfritt anrop nedan för att visa
                //var errorAge = handler.CreatePerson(0, "Cesar", "Davidsson", 176, 82);
                //var errorFnameLong = handler.CreatePerson(30, "Förnamnetärförlångt", "Eriksson", 176, 82);
                //var errorFnameShort = handler.CreatePerson(30, "X", "Eriksson", 176, 82);
                //var errorEnameLong = handler.CreatePerson(30, "Fredrik", "Efternamnetärförlångt", 176, 82);
                //var errorEnameShort = handler.CreatePerson(30, "Gustaf", "X", 176, 82);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // 3.3 Polymorfism
            var list = new List<Animal>();
            list.Add(new Dog("Karo", 10, 5, "Mörkbrun"));
            list.Add(new Flamingo("Curt", 3, 5, 105, 65));
            list.Add(new Hedgehog("Sonic", 2, 10, false));
            list.Add(new Wolfman("Jack", 90, 35, false));
            list.Add(new Wolf("Two Socks", 45, 3, false));

            // Lista djur
            Console.WriteLine("Listar alla djur:");
            foreach (Animal animal in list)
            {
                Console.Write($"Djuret {animal.Name} finns i listan och säger ");
                if (animal is IPerson)
                {
                    ((IPerson)animal).Talk(); // Här kollar jag om animal implementerar interfacet IPerson
                }
                else
                {
                    animal.DoSound();
                }
            }

            // Skapa lista för hundar
            var dogList = new List<Dog>();
            //dogList.Add(new Horse("Polle", 400, 8, false)); // Funkar inte

            // Skriv ut Stats() för alla djur
            Console.WriteLine(newLine + "Listar Stats() för alla djur:");
            foreach (Animal animal in list)
            {
                Console.WriteLine(animal.Stats());
            }

            // Skriv ut Stats() fast endast för hundar
            Console.WriteLine(newLine + "Listar Stats() för endast hundar:");
            foreach (Animal animal in list)
            {
                if (animal is Dog)
                {
                    Console.WriteLine(animal.Stats());
                    Console.WriteLine(((Dog)animal).NewMethod()); // castar till Dog
                }
            }

            // 3.4 Polymorfism med egna felklasser

            //Skapa lista med olika fel-objekt
            var errors = new List<UserError>()
            {
                new NumericInputError(),
                new TextInputError(),
                new NumericInputError(),
                new TextInputError(),
                new NumericInputError(),
                new StringTooLongError(),
                new CoffeeBreakError(),
                new OverflowError()
            };

            //Skriv ut felen i listan
            Console.WriteLine(newLine + "Skriver ut fel-objekt (inklusive tre egna) som ärver från klassen UserError:");
            foreach (UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}
