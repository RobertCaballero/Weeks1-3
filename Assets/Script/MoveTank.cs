using UnityEngine;
using UnityEngine.InputSystem;

public class MoveTank : MonoBehaviour
{

    public float speed;
    public float xMax;
    public float xMin;
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      
        bool leftArrowIsHeld = Keyboard.current.leftArrowKey.isPressed;
        bool rightArrowIsHeld = Keyboard.current.rightArrowKey.isPressed;

        if (leftArrowIsHeld)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (rightArrowIsHeld)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        Vector3 screenTransformPosition = gameCamera.WorldToScreenPoint(transform.position);

        xMax = Screen.width;

        xMin = 0;

        if (xMax < screenTransformPosition.x)
        {
            transform.position = transform.position * 0;
        }

        if (xMin > screenTransformPosition.x)
        {
            transform.position = transform.position * 0;
        }

    }
}
