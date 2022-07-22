using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBootStrapper : MonoBehaviour
{
    [SerializeField] private View view;
    [SerializeField] private MenuBehavior menuBehavior;
    [SerializeField] private BattleFieldView battleFieldView;
    private Controller controller;

    void Start()
    {
        controller = new Controller(view, menuBehavior, battleFieldView);
    }
}
