using UnityEngine;

public class Mathods : MonoBehaviour
{   
    public int health ;
    public float speed = 5.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        health = 100;

        Debug.Log("Player has Spawned");

        ShowHealth();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(20);
        }
    }
    void ShowHealth()
    {
        Debug.Log("Player Health: " + health);
    }
    void jump()
    {
        Debug.Log("Player Jumped");
    }

    void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Player took " + damage + " damage.");
        ShowHealth();
    }

    
}
