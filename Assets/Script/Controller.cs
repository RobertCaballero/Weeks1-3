using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSPeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       // Vector3 currentPos = transform.position;
       // currentPos.x += moveSpeed * Time.deltaTime; 
       // currentPos.y += moveSpeed * Time.deltaTime;

       // currentPos = transform.position;

        bool leftIsHeld = Mouse.current.leftButton.isPressed;
        if (leftIsHeld)
        {
            Debug.Log("Left mouse is held");
        }

        bool leftIsPressed = Mouse.current.leftButton.wasPressedThisFrame;
        if (leftIsPressed)
        {
            Debug.Log("Left mouse is pressed.");
        }

        bool leftIsReleased = Mouse.current.leftButton.wasReleasedThisFrame;
        if (leftIsReleased)
        {
            Debug.Log("Left mouse is released.");
        }

        bool spaceIsPressed = Keyboard.current.spaceKey.isPressed;
        bool upArrowIsHeld = Keyboard.current.upArrowKey.isPressed;
        bool leftArrowIsHeld = Keyboard.current.leftArrowKey.isPressed;
        bool rightArrowIsHeld = Keyboard.current.rightArrowKey.isPressed;


        if (leftArrowIsHeld)
        {

            transform.eulerAngles += transform.forward * rotateSPeed * Time.deltaTime;

        }

        if (rightArrowIsHeld)
        {
            transform.eulerAngles -= transform.forward * rotateSPeed * Time.deltaTime;

        }


        if (upArrowIsHeld)
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
            Debug.Log("Up arrow is pressed.");
        }

        bool downArrowIsHeld = Keyboard.current.downArrowKey.isPressed;
        if (upArrowIsHeld)
        {
            transform.position -= transform.up * moveSpeed * Time.deltaTime;
        }

        
    }
}
