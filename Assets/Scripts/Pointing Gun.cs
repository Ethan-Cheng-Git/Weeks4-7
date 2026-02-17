using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PointingGun : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    // have the gun image point at the mouse
       Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
       Vector2 direction = (Vector2)transform.position - mousePos;
       transform.right = direction;
    }
}
