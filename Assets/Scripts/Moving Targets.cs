using UnityEngine;

public class MovingTargets : MonoBehaviour
{
    public float speed = 0.001f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.y += speed;
        transform.position = newPos;

        if (newPos.y > 5.3 || newPos.y < -5)
        {
            speed = speed * -1;
        }
    }
}
