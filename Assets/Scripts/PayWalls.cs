using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PayWalls : MonoBehaviour
{
    //Variables
    public int cost;
    public GameObject[] objects;
    public bool show;
    private void OnTriggerEnter(Collider other) //On collide
    {
        if (other.CompareTag("Player")) //If Player
        {
            PlayerCollisions collision = other.GetComponent<PlayerCollisions>(); //Import from PlayerCollisions
            if (collision.coins >= cost) //Check coin balance is equal to cost
            {
                collision.coins -= cost; //Remove the cost from coins
                collision.coinText.text = "Coins:" + collision.coins;
                foreach (GameObject obj in objects)
                {
                    obj.SetActive(show); //Hide or show based on the show variable
                }
            }
        }
    }
}
 