using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMouse : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Rotate(float barrelRotate)
    {
        //Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        Vector2 direction = (Vector2)transform.position;

        //use the dynamic float on inspector to connect values of the slider to the characteristics of the objects (aka rotation)
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z = barrelRotate;
        transform.eulerAngles = newRotation;
    }
}
