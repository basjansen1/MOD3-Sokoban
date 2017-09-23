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
    private string currSquareID;
    private string[] textFile;

    public PlayGround()
    {
        Player = new Player();
        PlayField = new Dictionary<string, Square>();
        currSquareID = "0:0";
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
        textFile = File.ReadAllLines(fullPath);

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
                        newSquare.player = Player;
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
                        newSquare.box = box;
                        box.Square = newSquare;
                        row++;
                        break;

                    case ' ': // empty square
                        PlayField.Add("empty", null);
                        row++;
                        break;

                    default: // if the caracter is an enter (new line)
                        column++;
                        row = 0;
                        break;
                } // end switch

                if (newSquare != null)
                {
                    PlayField.Add(newSquare.ID, newSquare);
                }
            } // end for-loop -> for each char in string
        } // end for-loop -> for each string in string[]
    }

    public void MovePlayer()
    {
        throw new System.NotImplementedException();
    }

    public void DisplayPlayingField()
    {
        foreach (var l in textFile)
            Console.WriteLine(l);

        foreach (KeyValuePair<string, Square> entry in PlayField)
            // Do something with 
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

