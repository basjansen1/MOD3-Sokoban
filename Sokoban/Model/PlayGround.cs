﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class PlayGround
{
    public IEnumerable<Box> Box { get; set; }
    public Player Player { get; set; }
    public Dictionary<string, Square> PlayField { get; set; }
    private bool levelComleted;

    public PlayGround()
    {
        Player = new Player();
        PlayField = new Dictionary<string, Square>();
    }

    public void CheckLevelCompleted()
    {
        throw new System.NotImplementedException();
    }

    public void ResetPuzzle()
    {
        PlayField.Clear();
    }

    public void CheckMoveValid()
    {
        throw new System.NotImplementedException();
    }

    public void GenerateLevel(int level)
    {
        var projectPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
        var fullPath = new Uri(projectPath + @"\Doolhof\doolhof" + level + ".txt").LocalPath;

        // Bevat het level(speelveld)
        string[] text = File.ReadAllLines(fullPath);

        int row = 0;
        int column = 0;
        char[] squares;
        Square newSquare = null;

        foreach (string line in text)
        {
            squares = line.ToCharArray();

            foreach (char square in squares)
            {
                switch(square)
                {
                    case '#':
                        newSquare = new WallSquare(row, column);
                        row++;
                        break;

                    case '.':
                        newSquare = new NormalSquare(row, column);
                        row++;
                        break;

                    case '@':
                        newSquare = new NormalSquare(row, column);
                        newSquare.Player = Player;
                        Player.Square = newSquare;
                        row++;
                        break;

                    case 'x':
                        newSquare = new GoalSquare(row, column);
                        row++;
                        break;

                    case 'o':
                        newSquare = new NormalSquare(row, column);
                        Box box = new Box();
                        newSquare.Box = box;
                        box.Square = newSquare;
                        row++;
                        break;

                    default: // add empty square
                        PlayField.Add("e" + row + ":" + column, null); // indicate an emty square should be written
                        row++;
                        break;
                } // end switch

                if (newSquare != null)
                {
                    PlayField.Add(newSquare.ID, newSquare);
                }
                newSquare = null;
            } // end for-loop -> for each char in string
            column++;
            row = 0;
            PlayField.Add("n" + row + ":" + column, null); // indicate an enter has to be written
        } // end for-loop -> for each string in string[]
        this.testPrintField();
    }

    public void testPrintField()
       
    {
        Console.WriteLine("testPrintField");

        foreach (var square in PlayField)
        {

            if (square.Key.Substring(0,1).Equals("n"))
            {
                Console.WriteLine(); // print enter
            } else if (square.Key.Substring(0,1).Equals("e"))
            {
                Console.Write(" "); // print emtpy square
            } else // normal square
            {
                square.Value.print();
            }
        }
    }

    public void MovePlayer()
    {
        throw new System.NotImplementedException();
    }

    public void Move(ConsoleKeyInfo pressedKey)
    {
        switch (pressedKey.Key)
        {
            case ConsoleKey.UpArrow:
                Console.WriteLine("UP");
                break;
            case ConsoleKey.DownArrow:
                Console.WriteLine("DOWN");
                break;
            case ConsoleKey.LeftArrow:
                Console.WriteLine("LEFT");
                break;
            case ConsoleKey.RightArrow:
                Console.WriteLine("RIGHT");
                break;
        }
    }

}

