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

public class WallSquare : Square
{
    public WallSquare(int row, int column)
        : base(row, column)
    {
        base.Available = false;
    }

    public override void addMovableObject(Movable movable)
    {

    }

    public override void CalculateShape()
    {
        PrintShape = "█";
    }

    public override void RemoveMovableObject()
    {

    }
}

