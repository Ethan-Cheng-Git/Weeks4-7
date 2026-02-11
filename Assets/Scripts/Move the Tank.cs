using UnityEngine;
using UnityEngine.InputSystem;

public class MovetheTank : MonoBehaviour
{
    public float speed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 inputVector = Vector2.zero;
        //"Keyboard.current.rightArrowKey.isPressed" is the syntax for the right arrow being pressed
        //"Keyboard.current.'d'Key.isPressed" is the syntax for any letter being pressed (d as an example, can be replaced with any keyboard input)

        //transform.position += (Vector3)inputVector * speed * Time.deltaTime;
        //Vector3 newPosition = transform.position;

        //if (Keyboard.current.dKey.isPressed == true)
        //{
        //    inputVector.x += 1;
        //    if (transform.position.x > 13)
        //    {
        //        newPosition.x = 13;
        //    }
        //}
        //if (Keyboard.current.aKey.isPressed == true)
        //{
        //    inputVector.x -= 1;

        //    if (transform.position.x < -13)
        //    {
        //        newPosition.x = -13;
        //    }
        //}


        if (Keyboard.current.rightArrowKey.isPressed == true || Keyboard.current.dKey.isPressed == true)
        {
            //block to move the tank 
            Vector2 newPosition = transform.position;
            newPosition.x += speed * Time.deltaTime;
            transform.position = newPosition;

            if (transform.position.x > 13)
            {
                newPosition.x = 13;
                speed = 0;
                Debug.Log("You went out!");
            }
        }

        if (Keyboard.current.leftArrowKey.isPressed == true || Keyboard.current.aKey.isPressed == true)
        {
            Vector2 newPosition = transform.position;
            newPosition.x -= speed * Time.deltaTime;
            transform.position = newPosition;

            if (transform.position.x < -13)
            {
                newPosition.x = -13;
                Debug.Log("You went out!");
            }
        }







    }

    public void SpeedChange(float speed)
    {
        


    }
}
