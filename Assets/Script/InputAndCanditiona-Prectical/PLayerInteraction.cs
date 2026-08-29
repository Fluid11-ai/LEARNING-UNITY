using UnityEngine;

public class PLayerInteraction : MonoBehaviour
{   [SerializeField] private int playerHealth = 100;
    [SerializeField] private bool hasKey = false;
    [SerializeField] private bool isDoorLocked = true;
    private Rigidbody playerRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControl();
       
    }

    void PlayerControl()
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
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidbody.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            TryUnlockDoor();
        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            CollectKey();
        }
    }
    void TakeDamage(int damageAmount)
    {
        playerHealth -= damageAmount;

            Debug.Log("Player took damage: " + damageAmount + ", Current Health: " + playerHealth);
        if(playerHealth <= 0)
        {
            Debug.Log("Player is dead");
        }
    }
    void TryUnlockDoor()
    {
        if(hasKey && isDoorLocked)
        {
            isDoorLocked = false;
            Debug.Log("Door unlocked");
        }
        else if(!hasKey)
        {
            Debug.Log("You need a key to unlock the door");
        }
        else
        {
            Debug.Log("The door is already unlocked");
        }
    }
    void CollectKey()
    {
        hasKey = true;
        Debug.Log("Key collected");
    }
}
