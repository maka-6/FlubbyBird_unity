using UnityEngine;

public class Tubi : MonoBehaviour
{
    Vector2 position;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - (2f * Time.deltaTime), transform.position.y);
        if (transform.position.x <= -11f)
        {
            Destroy(gameObject);
        }
    }
}
