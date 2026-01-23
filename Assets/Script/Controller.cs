using NUnit.Framework;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic; // This library needs to be use to use List

public class Controller : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSPeed;
    public Color stratingColour;
   

    public List<SpriteRenderer> controllableRenderers;
    public List<Transform> controlledTransforms;

    //public SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //spriteRenderer.color = Color.blue;
        //spriteRenderer.color = stratingColour;
        //bool isInsideSprite =  spriteRenderer.bounds.Contains(transform.position);


        controlledTransforms.Add(transform);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;


        bool isLeftMousePressed = Mouse.current.leftButton.isPressed;
        if (isLeftMousePressed)
        {

            
            //Find any renders that are currently hovered over

            //Iterate over all of the elementas and determine if any of them are hovered over
            for (int i = 0; i < controllableRenderers.Count; i++)
            {
                SpriteRenderer currentSpriteRenderer = controllableRenderers[i];
                bool isHovered = controllableRenderers[i].bounds.Contains(worldMousePosition);
                if (isHovered)
                {
                    controlledTransforms.Add(controllableRenderers[i].transform);
                }
            }
           

        }

        for ( int i = 0; i <controlledTransforms.Count; i++)
        {
            Transform currentTransform = controlledTransforms[i];
            bool spaceIsPressed = Keyboard.current.spaceKey.isPressed;
            bool upArrowIsHeld = Keyboard.current.upArrowKey.isPressed;
            bool leftArrowIsHeld = Keyboard.current.leftArrowKey.isPressed;
            bool rightArrowIsHeld = Keyboard.current.rightArrowKey.isPressed;
            bool downArrowIsHeld = Keyboard.current.downArrowKey.isPressed;

            if (leftArrowIsHeld)
            {
                currentTransform.eulerAngles += transform.forward * rotateSPeed * Time.deltaTime;
            }
            if (rightArrowIsHeld)
            {
                currentTransform.eulerAngles -= transform.forward * rotateSPeed * Time.deltaTime;
            }
            if (upArrowIsHeld)
            {
                currentTransform.position += transform.up * moveSpeed * Time.deltaTime;
                Debug.Log("Up arrow is pressed.");
            }
            if (downArrowIsHeld)
            {
                currentTransform.position -= transform.up * moveSpeed * Time.deltaTime;
            }
        }



        // Vector3 currentPos = transform.position;
        // currentPos.x += moveSpeed * Time.deltaTime; 
        // currentPos.y += moveSpeed * Time.deltaTime;

        // currentPos = transform.position;

        //bool leftIsHeld = Mouse.current.leftButton.isPressed;
        //if (leftIsHeld)
        //{
        //    Debug.Log("Left mouse is held");
        //}

        //bool leftIsPressed = Mouse.current.leftButton.wasPressedThisFrame;
        //if (leftIsPressed)
        //{
        //    Debug.Log("Left mouse is pressed.");
        //}

        //bool leftIsReleased = Mouse.current.leftButton.wasReleasedThisFrame;
        //if (leftIsReleased)
        //{
        //    Debug.Log("Left mouse is released.");
        //}

        //bool spaceIsPressed = Keyboard.current.spaceKey.isPressed;
        //bool upArrowIsHeld = Keyboard.current.upArrowKey.isPressed;
        //bool leftArrowIsHeld = Keyboard.current.leftArrowKey.isPressed;
        //bool rightArrowIsHeld = Keyboard.current.rightArrowKey.isPressed;
        //bool downArrowIsHeld = Keyboard.current.downArrowKey.isPressed;

        //if (leftArrowIsHeld)
        //{

        //    transform.eulerAngles += transform.forward * rotateSPeed * Time.deltaTime;

        //}

        //if (rightArrowIsHeld)
        //{
        //    transform.eulerAngles -= transform.forward * rotateSPeed * Time.deltaTime;

        //}


        //if (upArrowIsHeld)
        //{
        //    transform.position += transform.up * moveSpeed * Time.deltaTime;
        //    Debug.Log("Up arrow is pressed.");
        //}


        //if (downArrowIsHeld)
        //{
        //    transform.position -= transform.up * moveSpeed * Time.deltaTime;
        //}


    }
}
