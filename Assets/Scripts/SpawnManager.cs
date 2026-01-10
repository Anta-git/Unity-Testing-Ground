using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 15;
    public float spawnPosX = 30f;
    private float spawnPosZ = 20;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        int side = Random.Range(0, 3); // 0: left, 1: front, 2: right

        Vector3 spawnPosition;
        Vector3 moveDirection;

        if (side == 0) // Left
        {
            float spawnZ = Random.Range(-spawnRangeZ, spawnRangeZ);
            spawnPosition = new Vector3(-spawnPosX, 0, spawnZ);
            moveDirection = new Vector3(1, 0, 0); // Toward +X
        }
        else if (side == 1) // Front
        {
            float spawnX = Random.Range(-spawnRangeX, spawnRangeX);
            spawnPosition = new Vector3(spawnX, 0, spawnPosZ);
            moveDirection = new Vector3(0, 0, -1); // Toward -Z
        }
        else // Right
        {
            float spawnZ = Random.Range(-spawnRangeZ, spawnRangeZ);
            spawnPosition = new Vector3(spawnPosX, 0, spawnZ);
            moveDirection = new Vector3(-1, 0, 0); // Toward -X
        }

        Quaternion spawnRotation = Quaternion.LookRotation(moveDirection);

        Instantiate(animalPrefabs[animalIndex], spawnPosition, spawnRotation);
    }
}
