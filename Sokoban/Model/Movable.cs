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

public abstract class Movable
{
    public Square Square { get; set; }

    public void Replace(Square oldSquare, Square newSquare)
    {
        Square = newSquare;
        Square.addMovableObject(this);
        oldSquare.RemoveMovableObject();
    }
}