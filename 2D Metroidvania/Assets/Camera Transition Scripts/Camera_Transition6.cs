using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Transition6 : MonoBehaviour
{
    public GameObject gameObject;


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            gameObject.transform.position = new Vector3(51.25f,-20f,-10f);
        }
        
    }
}