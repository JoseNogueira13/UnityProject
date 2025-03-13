using UnityEngine;

public class PlayerController : MonoBehaviour
   
{

    private float speed = 15f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Get the horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        //Get the vertical input
        verticalInput = Input.GetAxis("Vertical");

        //Move the vehicle forward based on up input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //Rotate the vehicle based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
