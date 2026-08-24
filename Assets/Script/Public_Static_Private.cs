using UnityEngine;
/*public and private

public: can be accessed from anywhere, including other classes and scripts. It shows in the Inspector.
private: can only accessed within the class it is defined in. It does not show in the Inspector.
SerializeField: this allows Private field in the inpector.


             C# ACCESS
                 │
        ┌────────┴────────┐
        │                 │
      public           private
        │                 │
   Other scripts     Only this class
   can access        can directly access
-------------------------------------------------

             UNITY INSPECTOR
                 │
                 ↓
          Serialization
                 │
        ┌────────┴────────┐
        │                 │
   [SerializeField]     Not serialized



   
   static: it is used for sharing data. it is used to define variables which are common in all the instances in the class.


*/

public class Public_Static_Private : MonoBehaviour
{   
    [SerializeField] private int health = 100;

    [SerializeField] private float speed = 5f;
    public string playerName = "Player1";
    public static int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Player Name: " + playerName);
        Debug.Log("Health: " + health);
        Debug.Log("Speed: " + speed);
        Debug.Log("Score: " + score);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
           AddScore(50);
        }
    }
    void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Health is now: " + health);
    }
    void AddScore(int points)
    {
        score += points;
        Debug.Log("Score is now: " + score);
    }
}
