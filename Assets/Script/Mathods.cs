using UnityEngine;

public class Mathods : MonoBehaviour
 {   
//     public int health ; //for integer numbers
//     public float speed = 5.5f;  //for floating point numbers

        public int health = 100; //for integer numbers
        public int score = 0; //for integer numbers
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()    //Start() is called when the script is first run.
                    //Start() is used to initialize variables or states before the game starts.
    {   
        /*
            Rigidbody rb;
            rb = GetComponent<Rigidbody>();
         */    


        // health = 100;       //Assigned the value of variable health at the start of the game.

        // Debug.Log("Player has Spawned");

        // ShowHealth();       //calling a method named ShowHealth().


    }

    // Update is called once per frame
    void Update()   // Update is called once per frame
                    // Update() is used to check something every frame.
                    /*Every Frame 
                            |
                    Check for Input 
                            |
                    is Space is pressed?
                            |
                        |       |
                      yes      no
                      |         |
                    jump()   keep checking
                    */
    {
        // if(Input.GetKeyDown(KeyCode.Space)/*this is a legacy input system for detecting key presses.*/) 
        // {
        //     jump();//this method is called when the space key is pressed.
        // }
        // if (Input.GetKeyDown(KeyCode.H))
        // {
        //     TakeDamage(20); // this method which takes a patrameter for initalizing the damage value.
        // }


        if (Input.GetKeyDown(KeyCode.D))
        {
            TakeDamage(10); // this method which takes a patrameter for initalizing the damage value.
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            AddScore(50); // this method which takes a patrameter for initalizing the score value.
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShowStatus(); // this method which takes a patrameter for initalizing the score value.
        }

    }
    // void/*this method do something but do not return any value due to void keyword*/ ShowHealth()
    // {
    //     Debug.Log("Player Health: " + health);
    // }
    // void jump() // here the "void" is return type and the "jump" is method name followed by "()".
    // {
    //     Debug.Log("Player Jumped");
    // }

    // void TakeDamage(int damage) //here the "()" contains the parameter for the method
    // /*Parameter= int damage(place holder)
    //   Argument= 20 (actual value passed when calling the method)*/
    // {
    //     health -= damage;
    //     Debug.Log("Player took " + damage + " damage.");
    //     ShowHealth();
    // }

    void TakeDamage(int damage) //here the "()" contains the parameter for the method
    {
        health-=damage;
        Debug.Log("Player took " + damage + " damage.");

    }

    void AddScore(int points)
    {
        score += points;
        Debug.Log("Player gained " + points + " points.");
    }

    void ShowStatus()
    {
        Debug.Log("Player Health: " + health);
        Debug.Log("Player Score: " + score);
    }

    
}
