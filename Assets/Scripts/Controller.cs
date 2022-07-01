using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller
{
    public View View { get; }
    public Model Model{ get; }
    public MenuBehavior MenuBehavior { get; }
    
    public Controller(View view, MenuBehavior menuBehavior)
    {
        Model = new Model();
        View = view;
        MenuBehavior = menuBehavior;
    }
}
