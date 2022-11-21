using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    //variables
    int hits = 0;
    public int startHealth;
    public GameObject prefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            hits = hits + 1;
            if (hits >= startHealth)
            {
                Destroy(gameObject);
                GameObject instance = (GameObject)Instantiate(prefab, transform.position + transform.forward, Quaternion.identity);
            }
            Destroy(collision.gameObject);
        }
    }
}
