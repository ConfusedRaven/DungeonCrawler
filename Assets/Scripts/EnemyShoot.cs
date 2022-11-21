using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    //Variables
    public GameObject prefab;
    public float shootForce = 30;
    float timer;
    public float shootDelay;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            GameObject instance = (GameObject)Instantiate(prefab, transform.position + transform.forward, Quaternion.identity);
            instance.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce, ForceMode.Impulse);
            Destroy(instance, 1);
            timer = shootDelay;
        }
        
    }
}
