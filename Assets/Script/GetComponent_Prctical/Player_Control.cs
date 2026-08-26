using UnityEngine;

public class Player_control : MonoBehaviour
{   private Rigidbody rb ;
    private PLayer_States playerStates;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerStates = GetComponent<PLayer_States>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 7f, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
           playerStates.TakeDamage(10);
        }
    }
}
