using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;
    
    private float maxHeight = 4.1f;
    private float minHeight = -4f;

    public float axis;


    public GameObject GameOverUI;
    public Rigidbody2D rb;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        axis = InputManager.axis;
        direction.y = axis * strength;
        rb.linearVelocity = direction;
    }

    // // Update is called once per frame
    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetMouseButtonDown(0))
    //     {
    //         direction = Vector3.up * strength;
    //     }

    //     if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetMouseButtonDown(1))
    //     {
    //         direction = Vector3.down * strength;
    //     }


    //     if (Input.touchCount > 0)
    //     {
    //         Touch touch = Input.GetTouch(0);
    //         if (touch.phase == TouchPhase.Began)
    //         {
    //             direction = Vector3.up * strength;
    //         }
    //     }

    //     transform.position += direction * Time.deltaTime;

    //     // Keep the player within the specified height bounds
    //     transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, minHeight, maxHeight), transform.position.z);
    // }



void OnCollisionEnter2D(Collision2D other)
    {
        print("Collided with: " + other.gameObject.name);
        if (other.gameObject.tag == "Deadly")
        {
            Death();  
        }
    }

public void Death()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }
    
    
    
    
    
    
    
    
    
    
    
}