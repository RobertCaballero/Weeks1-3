using UnityEngine;
using UnityEngine.InputSystem;

public class MovingSideMice : MonoBehaviour
{
    public float speed = 1f; //speed variable to control how fast the object moves
    private float baseSpeed = 1f; //stored copy of the original speed
    private float increaseSpeed = 2f; //new value speed is going to take
    public bool mouseIsOverMe = false; //boolean to check if the mouse is over the object
    private float direction = 1f; //variable to control the direction of the object

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moverXPos = transform.position; //Get the current position of the object 
        moverXPos.x += speed * direction * Time.deltaTime; //Make the object move along the x axis taking into account the speed and time per seconds instead of frames
        transform.position = moverXPos;

        if (moverXPos.x > 5f) //If the x position of the object is greater than 5, the speed turns negative making the object move left
        {
            moverXPos.x = 5f; //reset the x position to 5 to avoid going out of bounds
            direction = -direction;
        }

        if (moverXPos.x < 0f) // If the x position of the object is less than 0, the speed turns positive making the object move right
        {
            moverXPos.x = 0f; //reset the x position to 0 to avoid going out of bounds
            direction = -direction;
        }

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        float distance = Vector2.Distance(transform.position, mousePos);

        speed = baseSpeed;

        if (distance < 1f)
        {
            mouseIsOverMe = true; //If the distance between the mouse and the object is less than 1, the boolean turns true

        }
        else
            mouseIsOverMe = false; //If the distance between the mouse and the object is greater than 1, the boolean turns false


        if (mouseIsOverMe)
        {
            speed = increaseSpeed; //If the mouse is over the object, the speed increases
        }
        else
        {
            speed = baseSpeed; //If the mouse is not over the object, the speed returns to its base value
        }
    }
}
