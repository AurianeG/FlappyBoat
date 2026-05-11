using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float timeToSpawn = 2f;
    public float maxSpawnHeight = 4f;
    public float minSpawnHeight = -4f;  
    public float spawnXPosition = 10f; // Position X où les rochers apparaissent
    public GameObject rockPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRock", timeToSpawn, timeToSpawn);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRock()
    {
        float spawnYPosition = Random.Range(minSpawnHeight, maxSpawnHeight);
        Vector3 spawnPosition = new Vector3(spawnXPosition, spawnYPosition, 0f);
        Instantiate(rockPrefab, spawnPosition, Quaternion.identity);
    }
}
