using UnityEngine;
using UnityEngine.InputSystem;


public class MouseFollow : MonoBehaviour
{
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePos = Mouse.current.position.ReadValue();

        //Using the camera tp convert the mouse position from
        //screen space (pixels) to world space (gameObjects)
        Vector3 worldMousePos = gameCamera.ScreenToWorldPoint(currentMousePos);
        worldMousePos.z = 0;
        transform.position = worldMousePos;

        //Screen.width;
        //Screen.height;

        //gameCamera.WorldToScreenPoint(//somerandomvector);

     

    }
}
