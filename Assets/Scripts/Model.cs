using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public enum CellState
{
    Clear,
    Damaged
}

public class Model
{
    
    private Dictionary<int, Cell> Field;

    public Model()
    {
        Field = new Dictionary<int, Cell>();
        CreateFieldDefault();
        Debug.Log(Field.Count);
    }

    private void CreateFieldDefault()
    {
        int id = 0;
        for (int i = 0; i < 100; i++)
        {
            Field.Add(id, new Cell(id, CellState.Clear));
            id++;
        }
    }
}
