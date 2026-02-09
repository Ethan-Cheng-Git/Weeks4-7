using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public SpriteRenderer player;
    public int health = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar.maxValue = health;
        healthBar.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        //get the mouse position 
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is it inside the sprite
        //Y: take 1 health off
        if (player.bounds.Contains(mousePos) == true && Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            //is it clicking the button 
            
            health -= 1;
            if (health <= 0)
            {
                gameObject.SetActive(false);
            }
        }
        

        //update the heath bar with new health value 
        healthBar.value = health;
    }

    public void Heal()
    {
        //turn on player game object
        gameObject.SetActive(true);
        //set health to 5
        health = (int)healthBar.maxValue;
        //set value of slider back to 5
        healthBar.value = health;
    }

}
