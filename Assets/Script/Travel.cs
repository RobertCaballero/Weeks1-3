using UnityEngine;

public class Travel : MonoBehaviour
{

    public Transform startValue;
    public Transform endValue;
    public float progress = 0;
    public Vector3 output;
    public float duration;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        progress += Time.deltaTime / duration;
        output = Vector3.Lerp(startValue.position, endValue.position, progress);
        transform.position = output;


        if (progress >= 1f)
        {

            startValue.position = endValue.position;
            endValue.position = Random.insideUnitSphere * 3;
            progress = 0f;
        }
    }
}
