﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NormalSquare : Square
{
    public NormalSquare(int row, int column, PlayGround playground)
        : base(row, column, playground)
    {
        base.Available = true;
    }

    public override void addMovableObject(IMovable movable)
    {
        MovableObject = movable;
        CalculateShape();
    }

    public override void CalculateShape()
    {
        if (MovableObject == null)
        {
            PrintShape = ".";
        } else if (MovableObject is Spike)
        {
            PrintShape = "@";
        } else
        {
            PrintShape = "O";
        }
    }

    public override void RemoveMovableObject()
    {
        MovableObject = null;
        CalculateShape();
    }
}

