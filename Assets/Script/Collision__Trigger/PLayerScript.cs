using UnityEngine;

public class PLayerScript : MonoBehaviour
{
     [SerializeField]
    private int score = 0;
    private Rigidbody playerRigidbody;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
   
    void Update()
    {
        PlayerInput();
    }
    public void AddScore(int amount)
    {
        score += amount;

        Debug.Log("Score: " + score);
    }
    public void PlayerInput()
    {
            if(Input.GetKey(KeyCode.W))
        {
            playerRigidbody.AddForce(Vector3.forward * 5f);
        }
        if(Input.GetKey(KeyCode.S))
        {
            playerRigidbody.AddForce(Vector3.back * 5f);
        }
        if(Input.GetKey(KeyCode.A))
        {
            playerRigidbody.AddForce(Vector3.left * 5f);
        }
        if(Input.GetKey(KeyCode.D))
        {
            playerRigidbody.AddForce(Vector3.right * 5f);
        }
    }
}
