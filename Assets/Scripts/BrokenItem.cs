using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=xqQkiHI5U9o

//break the item and destroy it
public class BrokenItem : MonoBehaviour
{
    //makes a compoment 
    public GameObject replacement;
    bool hasExploded;

    void OnCollisionEnter(Collision collision){
        //Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name == "grenadeCell"){
            //an extising object that you want to make a copy of
            GameObject.Instantiate(replacement, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }  
}
