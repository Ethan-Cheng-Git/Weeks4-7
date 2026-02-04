using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIDemo : MonoBehaviour
{
    SpriteRenderer sr;
    public Image duckieImage; //the duckie image on the UI Canvas
    public int howManyClicks = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            changeColour();
        }
    }

    public void changeColour()
    {

        sr.color = Random.ColorHSV();
        duckieImage.color = sr.color;
    }

    public void setSize(float size)
    {
        transform.localScale = Vector3.one * size;
    }
    public void AddToTheNumber()
    {
        howManyClicks++;
    }
}
