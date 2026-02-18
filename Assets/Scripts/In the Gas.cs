using UnityEngine;
using UnityEngine.Events;

public class IntheGas : MonoBehaviour
{
    public SpriteRenderer gasPlate;
    public bool isInGas = false;
    public UnityEvent OnEnterSensor;
    public UnityEvent OnExitSensor;
    public UnityEvent<float> onRandomNumber;
    public UnityEvent inGas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gasPlate.bounds.Contains(transform.position) == true)
        {
            if (isInGas == true)
            {
                //still in Hazard!

            }
            else
            {
                //entered in hazard
                //do something!
                Debug.Log("Entered the sensor");
                OnEnterSensor.Invoke();
                isInGas = true;
                
            }
        }
        else
        {
            if (isInGas == true)
            {
                //exited the hazard!
                //do something
                Debug.Log("Exited the sensor");
                OnExitSensor.Invoke();
                isInGas = false;
                onRandomNumber.Invoke(Random.Range(0, 100)); 
                
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
    public void GasAppear()
    {
        gameObject.SetActive(true);
    }
    
}