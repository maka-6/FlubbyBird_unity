using UnityEngine;

public class Pavimento : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Vector2 position;
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Transform.Destroy();
        transform.position = new Vector2(transform.position.x - (2f * Time.deltaTime), transform.position.y);
        if (transform.position.x <= -.5f)
        {
            transform.position = position;
        }
    }
}
