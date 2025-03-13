using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldownTime = 1.0f;
    private float nextFireTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFireTime)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                nextFireTime = Time.time + cooldownTime;
            }
        }
    }
}
