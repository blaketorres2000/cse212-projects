using System;
using System.Collections.Generic;
using System.Linq;

public class TakingTurnsQueue
{
    // Queue to hold people and their turns
    private readonly Queue<(string Name, int Turns)> _people = new();

    // Property to get the length of the queue
    public int Length => _people.Count;

    // Method to add a person to the queue with specified turns
    public void AddPerson(string name, int turns)
    {
        _people.Enqueue((name, turns)); // Enqueue the person with their turns
    }

    // Method to get and remove the next person from the queue
    public void GetNextPerson()
    {
        // Check if the queue is empty
        if (_people.Count == 0)
        {
            Console.WriteLine("No one in the queue."); // Print message if the queue is empty
            return;
        }

        var person = _people.Dequeue(); // Dequeue the first person from the queue
        Console.WriteLine(person.Name); // Print the name of the dequeued person to the console

        // Check if the person has more than one turn left or if they have 0 or less turns
        if (person.Turns > 1 || person.Turns <= 0)
        {
            // If the person has 0 or less turns, keep them in the queue with 0 turns
            _people.Enqueue((person.Name, person.Turns <= 0 ? 0 : person.Turns - 1));
        }
    }

    // Override ToString method to provide string representation of the queue
    public override string ToString()
    {
        return string.Join(", ", _people.Select(p => p.Name)); // Join names of all people in the queue into a single string
    }
}
