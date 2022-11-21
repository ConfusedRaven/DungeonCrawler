using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    //Variables
    public string level;
    private void OnTriggerEnter(Collider other) //On collide
    {
        if (other.CompareTag("Player")) //Only if player collide
        {
            SceneManager.LoadScene(level); //Switch scene to the specified level
        }
    }

}
