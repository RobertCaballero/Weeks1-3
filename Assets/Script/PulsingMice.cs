using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PulsingMice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AnimationCurve curve; //Animation that the sprite will be taking!
    public float duration = 4; // Based duration
    public float output;
    private float baseDuration = 4f; // Stored copy of the original duration
    public float increasePulsations = 1f; // New value duration is going to take
    private float progress = 0f;

    public bool mouseIsOverMe = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
            progress += Time.deltaTime / duration;
            output = curve.Evaluate(progress); // Evaluate the curve based on progress

        transform.localScale = Vector3.one * output; // Local scale of the object is based on the output of the curve. Making it increase and decrease in size!


        if (progress > 1f)
            {
                progress = 0f;
            }

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        float distance = Vector2.Distance(transform.position, mousePos);

        if (distance < 1f)
        {
            mouseIsOverMe=true;
     
        }
        else
            mouseIsOverMe=false;


        if (mouseIsOverMe)
        {
            duration = increasePulsations;
        }
        else
        {
            duration = baseDuration;
        }
    }
}
