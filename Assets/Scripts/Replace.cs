using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replace : MonoBehaviour
{
    public GameObject replacement;

    void OnCollisionEnter(Collision collision){
        Debug.Log("this" + gameObject.name);
        Debug.Log("col" + collision.gameObject.name);

        if( collision.gameObject.name == "child"){
            Debug.Log("hello");
            GameObject.Instantiate(replacement, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(collision.gameObject);

        }

       
        
    }
}
