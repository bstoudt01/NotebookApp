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
                        break;
                    case "4":
                        return; // returning from the Main method will exit the program
                    default:
                        Console.WriteLine("Invalid Menu Option. You should know better.");
                        break;
                }
            }
        }
    }
}