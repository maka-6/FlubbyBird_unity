using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameController.instance.aggiornaPunteggio();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
