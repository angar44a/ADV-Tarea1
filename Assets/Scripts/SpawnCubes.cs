using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    public GameObject icecube;
    public GameObject spawnpoint;
    public AudioClip cling;
    private float spawnTime = 3f;
    void Start()
    {
        InvokeRepeating("SpawnCube", spawnTime, spawnTime);

        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = cling;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnCube()
    {
        
        Instantiate(icecube, spawnpoint.transform.position, Quaternion.identity);
    }
    void OnCollisionEnter()
    {
        GetComponent<AudioSource>().Play();

    }
}
