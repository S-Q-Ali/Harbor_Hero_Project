using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour
{
    public GameObject[] Arrow;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        Arrow[0].SetActive(true);
        i = 0;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
                Destroy(Arrow[i]);
                Arrow[i + 1].SetActive(true);
        }
       
    }
}
