using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public float spawnRate;
    public float spawnTimer;
    public GameObject tubo;
    public static GameController instance;

    private int point = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        gameOver = false;
        instance = this;
        gameOverPanel.SetActive(false);
    }
    
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

        instance = this;
    }

    public void GameOver()
    {
        if(gameOver)return;
        gameOver = true;
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
    }
    
    public void aggiornaPunteggio()
    {
        point ++;
    }

    public int getPunteggio()
    {
        return point;
    }
}