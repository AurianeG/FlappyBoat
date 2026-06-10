using UnityEngine;

public class Rock : MonoBehaviour
{
    public float speed = 5f;
    public float destroyXPosition = -10f; // Position at which the rock will be destroyed
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update() // fait defiler de droite a gauche les rochers
    {
        transform.position += Vector3.left * speed * Time.deltaTime;    
        if (transform.position.x < destroyXPosition)
        {
            Destroy(gameObject);
        }

        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collided with: " + other.gameObject.name);
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<Player>().Death();
        }
    }
}
