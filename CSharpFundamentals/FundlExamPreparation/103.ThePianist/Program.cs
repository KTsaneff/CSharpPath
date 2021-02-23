using System;
using System.Collections.Generic;
using System.Linq;

namespace _103.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Piece> pieces = new List<Piece>();

            for (int i = 0; i < lines; i++)
            {
                string[] currPiece = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

                string currKey = currPiece[2];
                string composer = currPiece[1];
                string pieceName = currPiece[0];

                Piece newPiece = new Piece(currKey, composer, pieceName);
                pieces.Add(newPiece);
            }

            string instructions;
            while ((instructions = Console.ReadLine()) != "Stop")
            {
                string[] newUpdate = instructions.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = newUpdate[0];

                if (command == "Add")
                {
                    string piece = newUpdate[1];
                    string composer = newUpdate[2];
                    string key = newUpdate[3];

                    Piece newEntry = new Piece(key, composer, piece);
                    if (!pieces.Any(x => x.Name == piece))
                    {
                        pieces.Add(newEntry);
                        Console.WriteLine($"{newEntry.Name} by {newEntry.Composer} in {newEntry.Key} added to the collection!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{newEntry.Name} is already in the collection!");
                        continue;
                    }
                }
                if (command == "Remove")
                {
                    string pieceToRemove = newUpdate[1];
                    int index = pieces.FindIndex(x => x.Name == pieceToRemove);

                    if (index > -1)
                    {
                        pieces.RemoveAt(index);
                        Console.WriteLine($"Successfully removed {pieceToRemove}!");
                        continue;
                    }

                    if (index == -1)
                    {
                        Console.WriteLine($"Invalid operation! {pieceToRemove} does not exist in the collection.");
                        continue;
                    }
                }
                if (command == "ChangeKey")
                {
                    string newColection = newUpdate[2];
                    string pieceToMove = newUpdate[1];
                    bool notMoved = true;

                    foreach (Piece piece in pieces)
                    {
                        if (piece.Name == pieceToMove)
                        {
                            piece.Key = newColection;
                            Console.WriteLine($"Changed the key of {pieceToMove} to {newColection}!");
                            notMoved = false;
                        }
                    }

                    if (notMoved)
                    {
                        Console.WriteLine($"Invalid operation! {pieceToMove} does not exist in the collection.");
                    }
                }
            }

            foreach (Piece piece in pieces.OrderBy(x => x.Name).ThenBy(x => x.Composer))
            {
                Console.WriteLine($"{piece.Name} -> Composer: {piece.Composer}, Key: {piece.Key}");
            }
        }
    }
    class Piece
    {
        public Piece(string key, string composer, string name)
        {
            Key = key;
            Composer = composer;
            Name = name;
        }

        public string Key { get; set; }
        public string Composer { get; set; }
        public string Name { get; set; }
    }
}
