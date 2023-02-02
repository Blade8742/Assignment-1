using UnityEngine;
using UnityEngine.UI;
public class Speed : MonoBehaviour
{
    public static float PlayingSpeed;
    public Text PlayingSpeedText;
    public Slider speedSlider;


    public void SetSpeed ()
    {
        PlayingSpeed = speedSlider.value;
        PlayingSpeedText.text = PlayingSpeed.ToString();
    }
    public void ShowSpeed ()
    {
        PlayingSpeedText.text = PlayingSpeed.ToString();
        speedSlider.value = PlayingSpeed;
    }
    public void ChangeSpeed ()
    {   
        speedSlider.minValue = 2000;
        speedSlider.maxValue = 10000;
        PlayerMovement.forwardForce = speedSlider.value;
    }
}
