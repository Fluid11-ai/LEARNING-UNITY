using UnityEngine;

public class Variables : MonoBehaviour
{   
    // public int health = 100;
    // public int coins = 0;
    // public float movementSpeed = 5f;
    // public bool isAlive = true;
    // public string playerName = "Ronak";
    // // Start is called once before the first execution of Update after the MonoBehaviour is created

    public string playerName = "Ronak";
    public int age = 21;
    public int score = 90;
    public float speed = 5.5f;
    public bool isAlive = true;
    void Start()
    {   
        // Debug.Log("Player Name: " + playerName);
        // Debug.Log("Health: " + health);
        // Debug.Log("Coins: " + coins);
        // Debug.Log("Movement Speed: " + movementSpeed);
        // Debug.Log("Is Alive: " + isAlive);

        Debug.Log("Player Name: " + playerName);
        Debug.Log("Age: " + age);
        Debug.Log("Score: " + score);
        Debug.Log("Speed: " + speed);
        Debug.Log("Is Alive: " + isAlive);
        score += 10;
        Debug.Log("Updated Score: " + score);
    }

    // Update is called once per frame
    void Update()
    {
        // if(isAlive == false)
        // {
            
        //     Debug.Log(playerName + " has died.");
        // }
    }
}
