using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.001f, 0.01f);
        StartCoroutine(StrDestroy());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-speed, -speed, 0);
    }
    IEnumerator StrDestroy()
    {
        yield return new WaitForSeconds(25);
        Destroy(this.gameObject);
    }
}
