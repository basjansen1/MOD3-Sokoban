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
    public NormalSquare(int row, int column)
        : base(row, column)
    {
        base.Available = true;
    }

    public override void print()
    {
        if (base.Player == null && Box == null) 
            Console.Write(".");
        else if (Box != null)
        {
            Console.Write("O");
        } else
            Console.Write("@");
    }
}

