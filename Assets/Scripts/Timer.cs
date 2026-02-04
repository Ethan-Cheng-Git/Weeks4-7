using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerValue = 0;
    public float timeMaxValue = 10;
    public Slider timerVisuals;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerVisuals.maxValue = timeMaxValue;
    }

    // Update is called once per frame
    void Update()
    {
        timerValue += Time.deltaTime;

        if (timerValue > timeMaxValue )
        {
            timerValue = 0;
        }

        timerVisuals.value = timerValue;
    }
}
