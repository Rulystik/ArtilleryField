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
        menuPanel.SetActive(true);
        menuPanel.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        BlackScreenFadeOnOff();
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
            image.DOFade(0, 0.4f).OnComplete(BlackScreeenActivity);
        }
        else
        {
            BlackScreeenActivity();
            image.DOFade(1, 0.4f);
        }
    }

    private void BlackScreeenActivity()
    {
        blackScreeen.SetActive(!blackScreeen.activeSelf);
    }

    public void MenuMoving()
    {
        var menuRect = menuPanel.GetComponent<RectTransform>();
        if (menuRect.localPosition != Vector3.zero)
        {
            menuRect.DOAnchorPos(Vector2.zero, 0.3f);
        }
        else
        {
            menuRect.DOAnchorPos(new Vector2(Screen.width * -2, 0), 0.3f);
        }
    }
}
