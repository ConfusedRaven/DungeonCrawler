using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollisions : MonoBehaviour
{
    //Variables
    public int coins = 0;
    public Text coinText;
    public int ammo = 0;
    public Text ammoText;
    private void OnTriggerEnter(Collider other) //On collide
    {
        if (other.CompareTag("Coin")) //If Coin
        {
            coins = coins + 1; // Add 1 to coins
            coinText.text = "Coins: " + coins; //Change cointext

            Destroy(other.gameObject); //Destroy coin
        }
        if (other.CompareTag("Ammo")) //If ammo
        {
            ammo = ammo + 1; // Add 1 to ammo
            ammoText.text = "Ammo: " + ammo; //Change ammo text

            Destroy(other.gameObject); //Destroy ammo crate
        }
        if (other.CompareTag("Respawn")) //If Enemy
        {
            SceneManager.LoadScene(0); //Reload level
            coins = 0;
            ammo = 0;
        }
    }
}
