using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    [SerializeField] private Button singleButton;
    [SerializeField] private Button multiButton;
    [SerializeField] private Button optionsButton;
    [SerializeField] private Button exitButton;


    public Action SingleButtonAction;
    public Action MultiButtonAction;
    public Action OptionsButtonAction;
    public Action ExitButtonAction;
    
    void Start()
    {
    }

    void Update()
    {
        
    }

    public void SingleButtonDown()
    {
        SingleButtonAction?.Invoke();
    }

    public void MultiButtonDown()
    {
        MultiButtonAction?.Invoke();
    }
    public void OptionsButtonDown()
    {
        OptionsButtonAction?.Invoke();
    }
    public void ExitButtonDown()
    {
        ExitButtonAction?.Invoke();
    }

}
