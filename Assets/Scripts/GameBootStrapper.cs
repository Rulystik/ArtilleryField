using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBootStrapper : MonoBehaviour
{
    [SerializeField] private View view;
    [SerializeField] private MenuBehavior menuBehavior;
    private Controller controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = new Controller(view, menuBehavior);
    }
}
