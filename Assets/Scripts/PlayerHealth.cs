using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    //Variables
    int hits = 0;
    public int health = 3;
    public Text healthText;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Laser"))
        {
            health = health - 1; // Add 1 to health
            healthText.text = "Health: " + health; //Change health text
            hits = hits + 1;
            if (hits >= health)
            {
                SceneManager.LoadScene(0); //Reload level
            }
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health = health - 1; // Add 1 to health
            healthText.text = "Health: " + health; //Change health text
            hits = hits + 1;
            if (hits >= health)
            {
                SceneManager.LoadScene(0); //Reload level
            }
            Destroy(collision.gameObject);

        }
    }
}
