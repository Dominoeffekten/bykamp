using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=28JTTXqMvOU&t=7s
public class MiniMap : MonoBehaviour {
     public Transform player;

    void LateUpdate (){

        //minimap follow the player
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        //minimap are rotation
        //transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);

    }






}
