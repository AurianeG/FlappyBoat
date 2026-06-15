using UnityEngine;
using UnityEngine.Events;

public class Rock : MonoBehaviour
{
    public float speed = 5f;
    public float destroyXPosition = -10f; // Position at which the rock will be destroyed
 
    void Update() // fait defiler de droite a gauche les rochers
    {
        transform.position += Vector3.left * speed * Time.deltaTime;    
        if (transform.position.x < destroyXPosition)
        {
            Destroy(gameObject);
        }        
    }
}
