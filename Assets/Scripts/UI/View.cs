using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    [SerializeField] private Button singleGameButton;
    [SerializeField] private Button multiGameButton;
    [SerializeField] private Button optionsButton;
    [SerializeField] private Button exitButton;

    public Action SingleButtonAction;
    public Action MultiButtonAction;
    public Action OptionsButtonAction;
    public Action ExitButtonAction;


    private void Start()
    {
        InitButtons();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitButtonAction?.Invoke();
        }
    }

    private void InitButtons()
    {
        singleGameButton.onClick.AddListener(SingleButtonDown);
        multiGameButton.onClick.AddListener(MultiButtonDown);
        optionsButton.onClick.AddListener(OptionsButtonDown);
        exitButton.onClick.AddListener(ExitButtonDown);
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
