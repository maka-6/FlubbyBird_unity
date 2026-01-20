using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    public float spawnRate;
    public float spawnTimer;
    public GameObject tubo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnRate = 3f;
        spawnTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if ( spawnTimer >= spawnRate ) 
        {
            spawnTimer -= spawnRate;
            Vector2 spawnPos = new Vector2(0f, Random.Range(0f,.7f));
            Instantiate(tubo, spawnPos, quaternion.identity);
        }
    }
}