using UnityEngine;

public class GetComponent : MonoBehaviour

/*GameObject is basically a container.

        Player GameObject
        │
        ├── Transform
        ├── Rigidbody
        ├── Capsule Collider
        ├── Animator
        └── PlayerController
        

        The scripts is also a component because it inherits from MonoBehaviour.
*/
{  // [SerializeField] private Rigidbody rb;    // this is inpecter refrence.
    private Rigidbody rb;
    [SerializeField] private float jumpForce = 7f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody/*this is the place where we specify the component type or what are we finding*/>();// GetComponent is the method to get the component attached to the game object.

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           Jump();
        }
        
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // AddForce is the method to add force to the rigidbody.
                                                                // the Syntext of AddForce is AddForce(Vector3 force, ForceMode mode) 
                                                                    // where force is the direction and magnitude of the force is 
                                                                    // applied to the rigidbody and mode is the type of force to be applied.
    }
}
