using UnityEngine;
using UnityEngine.UI;
public class Counter : MonoBehaviour
{
    public Text counterText;
    private int counter=0;

    void Start()
    {
        UpdateCounterText();

    }
    public void increase()
    {
        counter++;
        UpdateCounterText();
    }
    public void resetCounter()
    {
        counter = 0;
        UpdateCounterText();
    }

    void UpdateCounterText()
    {
        counterText.text = "Score: " + counter.ToString();
    }


    
}
