using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool isInHazard = false;
    public UnityEvent OnEnterSensor;
    public UnityEvent OnExitSensor;
    public UnityEvent<float> onRandomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hazard.bounds.Contains(transform.position) == true)
        {
            if (isInHazard == true) 
            {
                //still in Hazard!
               
            }
          else
            {
                //entered in hazard
                //do something!
                Debug.Log("Entered the sensor");
                OnEnterSensor.Invoke();
                isInHazard = true;
            }
        }
        else
        {
            if (isInHazard == true) 
            {
                //exited the hazard!
                //do something
                Debug.Log("Exited the sensor");
                OnExitSensor.Invoke();
                isInHazard = false;
                onRandomNumber.Invoke(Random.Range(0,100));
            }
            else
            {
                //g
                //outside hazard
            }
                
        }
    }
    public void ShowNumber(float number)
    {
        Debug.Log(number);
    }
}
