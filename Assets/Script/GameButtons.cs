using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameButtons : MonoBehaviour
{
    public GameObject menu;
    public GameObject menu_view;
    public GameObject summon;
    public GameObject summon_view;
    public GameObject summon_close;

    private bool onMenu;
    private bool onsummon;
    private void Start()
    {
        MenuClose();
    }
    public void MenuClose()
    {
        onMenu = false;
        onsummon = false;
        menu.SetActive(!onMenu);
        menu_view.SetActive(onMenu);
        summon_view.SetActive(onsummon);
        summon_close.SetActive(onsummon);
    }
    public void ClickMenuButton()
    {
        Debug.Log("Click Meun Button");
        onMenu = !onMenu;
        menu.SetActive(!onMenu);
        menu_view.SetActive(onMenu);
    }
    public void ClickSummonsButton()
    {
        Debug.Log("Click Summons Button");
        onsummon = !onsummon;
        summon_view.SetActive(onsummon);
        summon_close.SetActive(onsummon);
    }
    public void ClickSummonClose()
    {
        onsummon = false;
        summon_view.SetActive(onsummon);
        summon_close.SetActive(onsummon);
    }
}
