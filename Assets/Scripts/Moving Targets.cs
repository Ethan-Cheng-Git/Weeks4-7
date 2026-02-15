using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class MovingTargets : MonoBehaviour
{
    public float baseSpeed = 0.05f;
    private float direction = 1f;
    public Slider slider;
    public SpriteRenderer targetHead;
    public SpriteRenderer targetBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       targetHead = GetComponent<SpriteRenderer>();
       targetBody = GetComponent<SpriteRenderer>();
       slider.minValue = 0.01f;
       slider.maxValue = 1f;
       slider.value = baseSpeed;
       slider.wholeNumbers = false;

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        float speed = baseSpeed * direction;
        Vector3 newPos = transform.position;
        newPos.y += speed;
        transform.position = newPos;

        if (newPos.y > 5.3 || newPos.y < -5)
        {
            direction *= -1f;
        }

        if (targetHead.bounds.Contains(mousePos) == true && Mouse.current.leftButton.wasReleasedThisFrame == true)
        {
            //is it clicking the button 
            
                gameObject.SetActive(false);
            
        }
        else if (targetBody.bounds.Contains(mousePos) == true && Mouse.current.leftButton.wasReleasedThisFrame == true)
        {
            gameObject.SetActive(false);
        }
    }
    public void SetSpeed(float newSpeed)
    {
        baseSpeed = newSpeed;
    }

    public void Revive()
    {
        gameObject.SetActive(true);
    }
}
