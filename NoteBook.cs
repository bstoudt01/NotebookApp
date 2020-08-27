using System;
using System.Collections.Generic;

namespace NoteBookApp
{
    public class NoteBook
    {
        private List<Note> _notes = new List<Note>();

        public void AddNote(Note newNote)
        {
            newNote.Timestamp = DateTime.Now;
            _notes.Add(newNote);
        }

        public void RemoveNote(int index)
        {
            _notes.RemoveAt(index);
        }

        public void PrintNotes()
        {
            foreach (Note n in _notes)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(n.Timestamp);
                Console.WriteLine(n.Content);
            }
            Console.WriteLine("---------------------------------------");
        }
    }
}