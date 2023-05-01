using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youtubeTutorial4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructors
            Book book1 = new Book("Harry Potter", "JK Rowling",400);
            Book book2 = new Book("Lord of the Rings", "Tolkien", 700);
            Book book3 = new Book();
            book2.title = "The Hobbit";

            Console.WriteLine(book2.title);

            // Object Methods

            Student student1 = new Student("Jim","Business,",2.8);
            Student student2 = new Student("Pam","Art",3.6);
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            // Getters and Setters

            Movie avengers = new Movie("Avengers", "Josh Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            shrek.Rating = "R";
            Console.WriteLine(shrek.Rating);

            // Static Class Attributes

            Song holiday = new Song("Holiday","Greenday",200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir","Led Zeppelin",150);
            Console.WriteLine(kashmir.getSongCount());

            // Static Methods and Classes

            UsefulTools.sayHi("Mike");

            // Inheritance

            Chef chef = new Chef();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();

            Console.ReadKey();
        }
    }
}
