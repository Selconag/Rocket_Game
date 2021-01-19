using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starz : MonoBehaviour
{
    private GameObject Star;
    // Start is called before the first frame update
    void Start()
    {
        Star = GameObject.FindGameObjectWithTag("Star");    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("Exploded");
        Destroy(Star);
    }
}

