using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{
    MenuControls controls;

    public GameObject home;
    public GameObject play;
    public GameObject collection;
    public GameObject options;
    public int num = 1;

    private void Awake()
    {
        controls = new MenuControls();
        controls.InMenu.RightShoulder.performed += ctx => Next();
        controls.InMenu.LeftShoulder.performed += ctx => Prev();
    }

    private void Update()
    {
        if (num == 1)
        {
            home.SetActive(true);
            play.SetActive(false);
            collection.SetActive(false);
            options.SetActive(false);

        }
        if (num == 2)
        {
            home.SetActive(false);
            play.SetActive(true);
            collection.SetActive(false);
            options.SetActive(false);
        }
        if (num == 3)
        {
            home.SetActive(false);
            play.SetActive(false);
            collection.SetActive(true);
            options.SetActive(false);
        }
        if (num == 4)
        {
            home.SetActive(false);
            play.SetActive(false);
            collection.SetActive(false);
            options.SetActive(true);
        }
        if (num > 4)
        {
            num = 1;
        }
        if(num < 1)
        {
            num = 4;
        }
    }

    public void Prev()
    {
        num -= 1;
    }

    public void Next()
    {
        num += 1;
    }

    private void OnEnable()
    {
        controls.InMenu.Enable();
    }

    private void OnDisable()
    {
        controls.InMenu.Disable();
    }
}
