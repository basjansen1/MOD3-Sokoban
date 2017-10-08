﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Sokoban.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GoalSquare : Square
{
    public GoalSquare(int row, int column)
        : base(row, column)
    {
        base.Available = true;
    }

    public override void addMovableObject(IMovable movable)
    {
        MovableObject = movable;
        CalculateShape();

        if (movable is Box)
        {
            Box box = (Box)MovableObject;
            box.StandsOnGoal = true;
        }
    }
    public override void CalculateShape()
    {
        if (this.MovableObject == null)
            PrintShape = "X";
        else if (MovableObject is Box)
            PrintShape = "0";
        else if (MovableObject is Collaborator)
            PrintShape = ((Collaborator)MovableObject).Awake ? "$" : "Z";
        else
            PrintShape = "@";
    }

    public override void RemoveMovableObject()
    {
        if (MovableObject is Box)
        {
            Box box = (Box)MovableObject;
            box.StandsOnGoal = false;
        }
        MovableObject = null;
        CalculateShape();
    }
}