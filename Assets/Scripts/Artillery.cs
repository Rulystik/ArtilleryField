using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artillery
{
    public int ArtyID { get; }
    public List<CellData> artyPositions;

    public Artillery(int value)
    {
        ArtyID = value;
        artyPositions = new List<CellData>();
    }

    public CellState GetArtyState()
    {
        for (int i = 0; i < artyPositions.Count; i++)
        {
            if (artyPositions[i].PlayerCellState != CellState.Clear)
            {
                return CellState.Damaged;
            }
        }

        return CellState.Destroyed;
    }

    public void AddArtyPositions(CellData cell)
    {
        artyPositions.Add(cell);
    }

    public void ClearArtyPositions()
    {
        artyPositions.Clear();
    }
    
}
