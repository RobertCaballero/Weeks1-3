using UnityEngine;

public class MovingSideMice : MonoBehaviour
{
    public float speed = 0.01f;
    //public float xMax = 9;
    //public float xMin = -9;
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
        Vector3 moverXPos = transform.position;
        moverXPos.y += speed * Time.deltaTime;


        transform.position = moverXPos;


        //Screen.width;
        //Screen.height;

        //gameCamera.WorldToScreenPoint(//somerandomvector);

        //ser xMax to wherever is too far to the right for the player to see
        //ser xMin to wherever is too far to the left for the player to see

        Vector3 screenTransformPosition = gameCamera.WorldToScreenPoint(transform.position);

        xMax = Screen.width;

        xMin = 0;

        if (xMax > screenTransformPosition.y)
        {
            speed *= -1;
        }

        if (xMin < screenTransformPosition.y)
        {
            speed *= -1;
        }
    }
}
