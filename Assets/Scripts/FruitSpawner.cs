using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject fruitPrefab;
    public float spawnInterval = 2f;
    public float spawnHeight = 10f;
    public float launchForce = 500f;

    void Start()
    {
        InvokeRepeating("SpawnFruit", 1f, spawnInterval);
    }

    void SpawnFruit()
    {
        float randomX = Random.Range(-15f, 15f);
        float randomZ = Random.Range(-15f, 15f);
        Vector3 spawnPos = new Vector3(randomX, spawnHeight, randomZ);

        GameObject fruit = Instantiate(fruitPrefab, spawnPos, Quaternion.identity);

        Rigidbody rb = fruit.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(Vector3.up * launchForce);
            rb.AddTorque(Random.insideUnitSphere * 200f);
        }
    }
}

