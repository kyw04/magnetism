using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject Star;
    private bool spawn = true;
    private float randomX;
    private float randomY;
    private void Start()
    {
        
    }
    private void Update()
    {
        if (spawn)
            StartCoroutine(SpawnStar());
    }
    IEnumerator SpawnStar()
    {
        spawn = false;
        randomY = Random.Range(0, 10);
        randomX = Random.Range(0, 10);
        GameObject newStar = Instantiate(Star);
        newStar.transform.position = transform.position + new Vector3(randomX, randomY);
        yield return new WaitForSeconds(1.5f);
        spawn = true;
    }
    public void ClickStart()
    {
        Debug.Log("Click Start Button");
        SceneManager.LoadScene(1);
    }
    public void ClickNewStart()
    {
        Debug.Log("Click New Start Button");
    }
    public void ClickSetting()
    {
        Debug.Log("Click Setting Button");
    }
}
