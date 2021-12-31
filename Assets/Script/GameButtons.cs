using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameButtons : MonoBehaviour
{
    public GameObject menu;
    public GameObject menu_view;
    public GameObject summon;
    public GameObject summon_view;
    public GameObject[] GameObjects;
    private Index index;

    private int number;
    private bool onMenu;
    private bool onsummon;
    private void Start()
    {
        MenuClose();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void MenuClose()
    {
        onMenu = false;
        onsummon = false;
        menu.SetActive(!onMenu);
        menu_view.SetActive(onMenu);
        summon_view.SetActive(onsummon);
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
    }
    public void ClickSummonClose()
    {
        onsummon = false;
        summon_view.SetActive(onsummon);
    }
    public void ClickSummon()
    {
        string button_name = EventSystem.current.currentSelectedGameObject.name;
        GameObject button = GameObject.Find(button_name);
        index = button.GetComponent<Index>();
        GameObject newGameObject = Instantiate(GameObjects[index.value]);
        newGameObject.transform.position = new Vector3(0, 1, 0);
    }
}
