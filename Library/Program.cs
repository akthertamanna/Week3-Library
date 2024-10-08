using Library;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");

        //Second book object
        Book book2 = new Book("Ultimate C#", "Microsoft", "2233445");

        Console.WriteLine("Currently available books");

        //Display first book info
        book.DisplayInfo();

        //Display second book info
        book2.DisplayInfo();


        // Create new instances of the Member class
        // These new members are created using the
        // Member constructor in the Members class
        Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
        Member member1 = new Member(2, "Mary Jones", "102 Garden Road", 0790345666);

        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();

        // Person instances
        Person person = new Person();
        person.FirstName = "John"; // Access public property
        person.LastName = "Doe";
        // Output of the person info
        Console.WriteLine(person.GetFullName());


    }
}