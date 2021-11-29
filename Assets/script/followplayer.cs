using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    public GameObject player;
    //posicion camara
    public Vector3 offset = new Vector3(8, 5, -7);


    private void LateUpdate()
    {
        //camara
        transform.position = player.transform.position + offset;
    }
}
