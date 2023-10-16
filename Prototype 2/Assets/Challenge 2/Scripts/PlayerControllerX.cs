using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnAfterTime = 2f;
    private float spawnTimer = 0f;

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& spawnTimer <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            spawnTimer = spawnAfterTime;
        }
    }
}
