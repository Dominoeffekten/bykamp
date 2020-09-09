using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=3cJ_uq1m-dg&vl=fr


//open door
public class OpenDoor : MonoBehaviour
{

	public Transform target;
	Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
	rb.MovePosition(target.transform.position);
        
    }
}
