using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] uwu;
    private GameObject owo;
    public GameObject powerup;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPowerup();
    }


    public void SpawnPowerup()
    {
        Instantiate(powerup, GenerateSpawnPosition(), powerup.transform.rotation);
    }
    private Vector3 GenerateSpawnPosition()
    {
        owo = GameObject.Find("Player");
        float spawnRange = owo.transform.position.x;
        float spawnPosX = Random.Range(spawnRange - 20, spawnRange + 20);
        float spawnPosZ = Random.Range(spawnRange - 20, spawnRange + 20);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
