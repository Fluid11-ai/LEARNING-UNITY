using UnityEngine;

public class GameTester : MonoBehaviour
{   
    public Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.H))
        {
           player.TakeDamage(10);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
           player.AddScore(50);
        }
        
    }
}
