using UnityEngine;
using UnityEngine.InputSystem;

public class MovingUpAndDownMice : MonoBehaviour
{
    public float speed2 = 1f; //speed variable to control how fast the object moves
    private float baseSpeed2 = 1f; //stored copy of the original speed
    private float increaseSpeed2 = 4f; //new value speed is going to take
    public bool mouseIsOverMe2 = false; //boolean to check if the mouse is over the object
    private float direction2 = 1f; //variable to control the direction of the object

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moverXPos = transform.position; //Get the current position of the object 
        moverXPos.y += speed2 * direction2 * Time.deltaTime; //Make the object move along the x axis taking into account the speed and time per seconds instead of frames
        transform.position = moverXPos;

        if (moverXPos.y > -4f) //If the y position of the object is greater than 2, the speed turns negative making the object move left
        {
            moverXPos.y = -4f; //reset the y position to 2 to avoid going out of bounds
            direction2 = -direction2;
        }

        if (moverXPos.y < -6.5f) // If the y position of the object is less than -2, the speed turns positive making the object move right
        {
            moverXPos.y = -6.5f; //reset the y position to -2 to avoid going out of bounds
            direction2 = -direction2;
        }

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        float distance = Vector2.Distance(transform.position, mousePos);

        speed2 = baseSpeed2;

        if (distance < 1f)
        {
            mouseIsOverMe2 = true; //If the distance between the mouse and the object is less than 1, the boolean turns true

        }
        else
            mouseIsOverMe2 = false; //If the distance between the mouse and the object is greater than 1, the boolean turns false


        if (mouseIsOverMe2)
        {
            speed2 = increaseSpeed2; //If the mouse is over the object, the speed increases
        }
        else
        {
            speed2 = baseSpeed2; //If the mouse is not over the object, the speed returns to its base value
        }
    }
}
