using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class MovingTargets : MonoBehaviour
{
    // declare and initialize the variables 
    public float baseSpeed = 0.05f;
    private float direction = 1f;
    public int setsHit = 0;
    public float time = 0;
    public Slider slider;
    public SpriteRenderer targetHead;
    public SpriteRenderer targetBody;
    public TextMeshProUGUI hit;
    public TextMeshProUGUI seconds;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      //set the starter values
       slider.minValue = 0.01f;
       slider.maxValue = 1f;
       slider.value = baseSpeed;
       slider.wholeNumbers = false;
       time = 0;
}

    // Update is called once per frame
    void Update()
    {
        //Reads the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //speed variable to combine the base speed to magnitude of direction
        float speed = baseSpeed * direction;
        //moves the targets 
        Vector3 newPos = transform.position;
        newPos.y += speed;
        transform.position = newPos;

        //keeps the targets moving within the game screen
        if (newPos.y > 5.3 || newPos.y < -5)
        {
            //changed magnitude of movement of targets
            direction *= -1f;
        }

        //if the target's head is clicked then it dissapears 
        if (targetHead.bounds.Contains(mousePos) == true && Mouse.current.leftButton.wasReleasedThisFrame == true)
        {
            //A set of targets is hit when all targets are hit 
            //set number converted to string
            hit.text = setsHit.ToString();
            //makes the target disappear 
            gameObject.SetActive(false);

        }
        //if the target's body is clicked then it dissapears 
        else if (targetBody.bounds.Contains(mousePos) == true && Mouse.current.leftButton.wasReleasedThisFrame == true)
        {
            //A set of targets is hit when all targets are hit 
            setsHit++;
            //set number converted to string
            hit.text = setsHit.ToString();
            //makes the target disappear 
            gameObject.SetActive(false);     
        }
        //counts time up, only stops counting when all targets are hit
        time++;
        //convert the number variable to a string
        seconds.text = time.ToString();


}
    //the function being used for the slider to adjust speed of moving targets 
    public void SetSpeed(float newSpeed)
    {
        baseSpeed = newSpeed;
    }
    //makes all targets spawn back 
    public void Revive()
    {
        gameObject.SetActive(true);
        //resets time back to 0
        time = 0;
    }
}
