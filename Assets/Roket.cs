using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roket : MonoBehaviour
{
    private GameObject Rocket;
    private Transform Roketeer;
    public float speed = 1.0f;
    private Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        Rocket = GameObject.FindGameObjectWithTag("Roket");
        Roketeer = Rocket.transform;
        RB = Rocket.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) 
        { 
            //transform.Translate(Vector3.right * Time.deltaTime * speed, Roketeer);
            RB.AddForce(Vector3.right * speed, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(Vector3.up * Time.deltaTime * speed, Roketeer);
            RB.AddForce(Vector3.up *speed , ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Vector3.left * Time.deltaTime * speed, Roketeer);
            RB.AddForce(Vector3.left * speed, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(Vector3.up * Time.deltaTime * speed, Roketeer);
            RB.AddForce(Vector3.down * speed, ForceMode.Acceleration);
        }
    }
    
}
