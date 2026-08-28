using UnityEngine;

public class Canditions__Inputs : MonoBehaviour
{   
    [SerializeField] private float speed = 5f;
    [SerializeField] private int health = 100;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleInput();
       
    }

    void HandleMovement()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    void HandleInput()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {   
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            CheckHealth();
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Space key released");
        }
    }
    void Jump()
    {
        rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
    }
    void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Player took " + damage + " damage. Current health: " + health);
    }
    void CheckHealth()
    {
        if(health > 70)
        {
            Debug.Log("Player is healthy.");
        }
        else if(health > 30&& health <= 70)
        {
            Debug.Log("Player is injured.");
        }
        else if(health > 0 && health <= 30)
        {
            Debug.Log("Player is in critical condition.");
        }
        else
        {
            Debug.Log("Player is dead.");
        }
    }
}