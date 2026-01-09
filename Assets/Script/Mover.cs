using UnityEngine;
using UnityEngine.Rendering;

public class Mover : MonoBehaviour
{
    public float speed = 0.01f;
    //public float xMax = 9;
    //public float xMin = -9;
    public float xMax;
    public float xMin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moverXPos = transform.position;
        moverXPos.x = moverXPos.x + speed;
        transform.position = moverXPos;

        if (xMax > transform.position.x)
        {
            speed *= -1;
        }

        if (xMin < transform.position.x)
        {
            speed *= -1;
        }
        
        
      //  if (moverXPos.x >= xMax)
      //  {
      //      speed = - 0.01f;
      //  }
      //  else if (moverXPos.x <= xMin)
      //  {
      //      speed = 0.01f;
      //  }

       
    }
}
