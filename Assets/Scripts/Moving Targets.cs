using UnityEngine;
using UnityEngine.UI;

public class MovingTargets : MonoBehaviour
{
    public float baseSpeed = 0.05f;
    private float direction = 1f;
    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       slider.minValue = 0.01f;
       slider.maxValue = 1f;
       slider.value = baseSpeed;
       slider.wholeNumbers = false;

    }

    // Update is called once per frame
    void Update()
    {

        float speed = baseSpeed * direction;
        Vector3 newPos = transform.position;
        newPos.y += speed;
        transform.position = newPos;

        if (newPos.y > 5.3 || newPos.y < -5)
        {
            direction *= -1f;
        }
    }
    public void SetSpeed(float newSpeed)
    {
        baseSpeed = newSpeed;
    }
}
