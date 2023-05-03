using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Transition1 : MonoBehaviour
{
    public GameObject gameObject;


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            gameObject.transform.position = new Vector3(0f, 0f, -10f);
        }
       
    }
}