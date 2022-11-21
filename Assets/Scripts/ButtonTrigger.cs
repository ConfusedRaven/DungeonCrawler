using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    //Variables
    public GameObject[] objects;
    public bool show;

    private void OnTriggerEnter(Collider other) //On collide
    {
        if (other.CompareTag("Player")) //Only if player collide
        {
            foreach (GameObject obj in objects)
            {
                obj.SetActive(show); //Hide or show based on the show variable
            }
        }

    }

}
