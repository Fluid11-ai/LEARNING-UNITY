using UnityEngine;

public class PLayer_States : MonoBehaviour
{   

    [SerializeField] private int PlayerHealth = 100;
    [SerializeField] private int PlayerScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowPlayerHealth();
        ShowPlayerScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ShowPlayerHealth()
    {
        Debug.Log("Player Health: " + PlayerHealth);
    }
    void ShowPlayerScore()
    {
        Debug.Log("Player Score: " + PlayerScore);
    }
    public void TakeDamage(int damage)
    {
        PlayerHealth -= damage;
        ShowPlayerHealth();
    }
}
