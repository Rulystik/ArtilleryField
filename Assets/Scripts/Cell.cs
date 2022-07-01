using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
{
    public int IdCell { get; }
    public Artillery Artillery { get; set; }
    public CellState CellState { get; set; }
    

    public Cell(int id, CellState state)
    {
        IdCell = id;
        CellState = state;
        Artillery = null;
    }
}
