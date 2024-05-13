using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefeb;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    private Transform target;
    private float spawnRate;
    private float TimeAfterSpawn;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        TimeAfterSpawn = 0;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        target = FindObjectOfType<Player_controller>().transform;

        audioSource = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        TimeAfterSpawn += Time.deltaTime;
        if ( TimeAfterSpawn >= spawnRate)
        {
            TimeAfterSpawn = 0f;
            GameObject bullet = Instantiate(bulletPrefeb, transform.position,transform.rotation);
            bullet.transform.LookAt(target);
            audioSource.Play();
        }
        
    }
}
