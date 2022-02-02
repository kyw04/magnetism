using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetRange : MonoBehaviour
{
    public float speed = 1;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        Vector3 pos = transform.position + new Vector3(0, 0, 15);
        if (other.gameObject.tag == "Iron")
        {
            Debug.Log("Iron");
            other.transform.position = Vector3.MoveTowards(other.transform.position, pos, speed * 10 * Time.deltaTime);
        }
        if (other.gameObject.tag == "Paper")
        {
            Debug.Log("Paper");
        }
        if (other.gameObject.tag == "Copper")
        {
            Debug.Log("Copper");
            other.transform.position = Vector3.MoveTowards(other.transform.position, pos, speed * Time.deltaTime);

        }
    }
}
