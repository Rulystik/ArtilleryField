using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTile : MonoBehaviour
{
    private GameObject stateTileObj;
    
    public int Id { get; private set; }

    public void Init(int id)
    {
        Id = id;
        gameObject.name = "Tile " + id;
        stateTileObj = transform.GetChild(0).gameObject;
        DeactivateStateTile();
    }

    public void ActivateStateTile()
    {
        stateTileObj.SetActive(true);
    }

    public void DeactivateStateTile()
    {
        stateTileObj.SetActive(false);
    }

    public void SetStateIcon(Sprite sprite)
    {
        ActivateStateTile();
        stateTileObj.GetComponent<Image>().sprite = sprite;
    }
    public void SetPosition(Vector2 pos)
    {
        gameObject.GetComponent<RectTransform>().anchoredPosition = pos;
    }
    
}
