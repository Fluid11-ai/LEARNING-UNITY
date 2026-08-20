using UnityEngine;

public class Variables : MonoBehaviour
{   
    public int health = 100;
    public int coins = 0;
    public float movementSpeed = 5f;
    public bool isAlive = true;
    public string playerName = "Ronak";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Player Name: " + playerName);
        Debug.Log("Health: " + health);
        Debug.Log("Coins: " + coins);
        Debug.Log("Movement Speed: " + movementSpeed);
        Debug.Log("Is Alive: " + isAlive);
    }

    // Update is called once per frame
    void Update()
    {
        if(isAlive == false)
        {
            
            Debug.Log(playerName + " has died.");
        }
    }
}
