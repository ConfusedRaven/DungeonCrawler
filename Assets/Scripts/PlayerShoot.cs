using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    //Variables
    public GameObject prefab;
    public float shootForce = 20;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerCollisions collision = GetComponent<PlayerCollisions>(); //Import from PlayerCollisions
            if (collision.ammo >= 1) //Check if you have ammo
            {
                collision.ammo -= 1; //Remove the cost from coins
                collision.ammoText.text = "Ammo:" + collision.ammo;
                RaycastHit hit;
                if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 100))
                {
                    Vector3 direction = hit.point - transform.position;
                    direction.Normalize();
                    GameObject instance = (GameObject)Instantiate(prefab, transform.position + direction, Quaternion.identity);
                    instance.GetComponent<Rigidbody>().AddForce(direction * shootForce, ForceMode.Impulse);
                    Destroy(instance, 1);
                }
            }
        }
    }
}
