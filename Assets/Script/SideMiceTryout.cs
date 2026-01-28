using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class SideMiceTryout : MonoBehaviour
{

    public Vector2 startValue = new Vector2(-1.2f, -2.2f);
    public Vector2 endValue = new Vector2(1.2f, -2.2f);
    public float progress = 0;
    public float speed2 = 1f;
    private float baseSpeed2 = 1f;
    private float increaseSpeed2 = 3f;
    bool mouseIsOverMe2 = false;
    bool returning = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime * speed2; // We increase progress based on time and speed

        if (progress > 1f) // If progress is greater than 1, we reset it to 0
        {
            progress = 0;

            if (returning) // We place this if statement here so the condition only occurs when progress resets, meaning the endvalue has been reached.
            {
                returning = false; // If returning is true, it becomes false, meaning the object is going to the endValue
            }
            else
            {
                returning = true; // If returning is false, it becomes true, meaning the object is going back to the startValue
            }
        }

        if (returning) // Check if we are returning
        {
            transform.position = Vector2.Lerp(endValue, startValue, progress); // If returning is true, we lerp from endValue to startValue
        }
        else
        {
            transform.position = Vector2.Lerp(startValue, endValue, progress); // If returning is false, we lerp from startValue to endValue
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




