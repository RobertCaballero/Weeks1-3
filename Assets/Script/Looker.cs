using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Looker : MonoBehaviour
{

    public float rotationSpeed;
    public float zMax = 30f;
    public float zMin = 60f;
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //ROTATING IN A DIRECTION AND SWAPING

        //If we wanted to move the object, we would use transform.position

        //Vector3 currentRotation = transform.eulerAngles; //eulerAngles gives the rotation  
        //currentRotation.z += rotationSpeed * Time.deltaTime; // Added Time.deltaTime so it moves every second instead of every frame

        //transform.eulerAngles = currentRotation;



        //if (transform.eulerAngles.z > zMax)
        //{
        //    rotationSpeed *= -1;
        //}
        //if (transform.eulerAngles.z < zMin)
        //{
        //    rotationSpeed *= -1;
        //}

        ////Debug.Log("This is running"); // Check if something is happening
        //Debug.Log(transform.eulerAngles); // Check if something is happening


        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;

        //Setting the direction we're looking in
        // To get the dirrection we do END - START
        transform.up = worldMousePosition - transform.position;  // This is the direction upwards in space, so it's looking at the current wolrd position the mouse is in. 


        transform.position += transform.up * 1f * Time.deltaTime;
    }
}
