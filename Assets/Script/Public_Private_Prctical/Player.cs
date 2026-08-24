using UnityEngine;

public class Player : MonoBehaviour
{   
    [SerializeField] private int health = 100;
    [SerializeField] private float speed = 5f;
    public string playerName = "Player1";
    public static int score = 0; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Health is now: " + health);
    }
    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score is now: " + score);
    }
}
