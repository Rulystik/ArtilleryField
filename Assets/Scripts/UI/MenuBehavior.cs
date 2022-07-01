using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MenuBehavior : MonoBehaviour
{
    [SerializeField] private GameObject blackScreeen;
    [SerializeField] private GameObject menuPanel;
    
    
    void Start()
    {
        blackScreeen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            var rect = menuPanel.GetComponent<RectTransform>();
            rect.localScale += new Vector3(-0.1f,-0.1f,0);
        }
    }

    void BlackScreenFadeOnOff()
    {
        var image = blackScreeen.GetComponent<Image>();
        if (image.color.a == 1)
        {
            image.DOFade(0, 0.3f).OnComplete(BlackScreeenActivity);
        }
        else
        {
            BlackScreeenActivity();
            image.DOFade(1, 0.3f);
        }
    }

    private void BlackScreeenActivity()
    {
        blackScreeen.SetActive(!blackScreeen.activeSelf);
    }
}
