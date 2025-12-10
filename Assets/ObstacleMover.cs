using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float speed = 3.0f;      
    public float distance = 4.0f;   
    
    private Vector3 startPos;

    void Start()
    {

        startPos = transform.position;
    }

    void Update()
    {
        float z = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPos + Vector3.forward * z;
    }
}