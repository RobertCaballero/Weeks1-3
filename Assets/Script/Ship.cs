using UnityEngine;

public class Ship : MonoBehaviour
{
   // public Vector3 teleportPosition;
    public float waitDuration;
    private float timePassed = 0f;
   // public float duration;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;

        if (timePassed > waitDuration)
        {
            transform.position = Random.insideUnitSphere*5;
            timePassed = 0f;
        
        }
    }
}
