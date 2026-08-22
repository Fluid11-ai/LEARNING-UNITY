using UnityEngine;

public class Variables : MonoBehaviour
{   
    // public int health = 100;     //INT FOR INTEGER NUM
    // public int coins = 0;        
    // public float movementSpeed = 5f;    //FOR FLOATING POINT NUMBERS
    // public bool isAlive = true;          //FOR TRUE OR FALSE VALUES
    // public string playerName = "Ronak";  //FOR WORDS OR TEXTUAL DATA
    // // Start is called once before the first execution of Update after the MonoBehaviour is created

    public string playerName = "Ronak";
    public int age = 21;
    public int score = 90;
    public float speed = 5.5f;
    public bool isAlive = true;
    void Start()
    {   
        // Debug.Log("Player Name: " + playerName); //FOR PRINTING THE VALUE OF VARIABLES IN THE CONSOLE(Dbug.Log() is used to print the value of variables in the console)
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
