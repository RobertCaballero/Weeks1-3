using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportingMice : MonoBehaviour
{
    //public float waitDuration;
    //private float timePassed = 0f;
    private bool mouseIsOverMe3 = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        float distance = Vector2.Distance(transform.position, mousePos);

        if (distance < 1f)
        {
            mouseIsOverMe3 = true;

        }
        else
            mouseIsOverMe3 = false;

       
        if (mouseIsOverMe3)
        {
            transform.position = Random.insideUnitSphere * 10;

        }
    }
}
