using System;

namespace NoteBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NOTES!");
            Console.WriteLine();

            NoteBook myNoteBook = new NoteBook();

            // Loop forever!?!?
            //  Actually if you look at how we handle option "4", you'll see how we break out of the loop
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine(" 1) Add a Note");
                Console.WriteLine(" 2) View All Notes");
                Console.WriteLine(" 3) Remove NOte");
                Console.WriteLine(" 4) Exit");
                Console.WriteLine();
                Console.Write("> ");

                string choice = Console.ReadLine();

                // A "switch statement" is a short-hand way of writing a bunch of 
                //  "if/else if/else" statements
                // See the commented code below the switch to see the equivalent if/else if/else 
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter a Note:");

                        string content = Console.ReadLine();
                        Note aNewNote = new Note()
                        {
                            Content = content
                        };
                        Console.WriteLine();

                        myNoteBook.AddNote(aNewNote);
                        break;
                    case "2":
                        myNoteBook.PrintNotes();
                        break;
                    case "3":
                        Console.Write("Index? ");
                        string strIndex = Console.ReadLine();

                        // "try" some things that might fail.
                        // it's a good idea to use a "try/catch" any time you are taking input from a user
                        try
                        {
                            // we "try" to do convert the user's input into an integer
                            int index = int.Parse(strIndex);

                            // we "try" to remove at a given index
                            myNoteBook.RemoveNote(index);
                        }
                        catch (Exception ex)
                        {
                            // if something we "tried" caused an "exception" we "catcH" it
                            // IN the "catch" block we "handle" the exception. In this case we print a friendly error messagge
                            Console.WriteLine($"Unable to remove Note at index '{strIndex}'");

                            // The exception has a "Message" property that describes what went wrong.
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;
                    case "4":
                        return; // returning from the Main method will exit the program
                    default:
                        // if the "choice" variable didn't match any "case" we inform the user that they
                        //  didn't choose a valid option
                        Console.WriteLine("Invalid Menu Option. You should know better.");
                        break;
                }

                /* This if/else if/else statement is equivalent to the switch above
                if (choice == "1")
                {
                    Console.WriteLine("Enter a Note:");

                    string content = Console.ReadLine();
                    Note aNewNote = new Note()
                    {
                        Content = content
                    };
                    Console.WriteLine();

                    myNoteBook.AddNote(aNewNote);
                }
                else if (choice == "2")
                {
                    myNoteBook.PrintNotes();
                }
                else if (choice == "3")
                {
                    Console.Write("Index? ");
                    string strIndex = Console.ReadLine();
                    try
                    {
                        int index = int.Parse(strIndex);
                        myNoteBook.RemoveNote(index);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unable to remove Note at index '{strIndex}'");
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
                else if (choice == "4")
                {
                    return; // returning from the Main method will exit the program
                }
                else
                {
                    Console.WriteLine("Invalid Menu Option. You should know better.");
                }
                */
            }
        }
    }
}