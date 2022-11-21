using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    //variables
    public GameObject[] objects;
    public bool show;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            foreach (GameObject obj in objects)
            {
                obj.SetActive(show); //Hide or show based on the show variable
            }
        }
    }
}
