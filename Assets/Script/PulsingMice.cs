using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PulsingMice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AnimationCurve curve;
    public float duration;
    public float output;

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
            output = curve.Evaluate(progress);

            transform.localScale = Vector3.one * output;


            if (progress > 1f)
            {
                progress = 0f;
            }

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        float distance = Vector2.Distance(transform.position, mousePos);

        if (distance < 1f)
        {
            mouseIsOverMe=true;
            duration = 1f;
     
        }
        else
            mouseIsOverMe=false;
            
    }
}
