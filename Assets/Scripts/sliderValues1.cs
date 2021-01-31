using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class sliderValues1 : MonoBehaviour
{
    public Slider mySlider;
    public Text valueOfSlider;

    void Update()
    {
        valueOfSlider.text = mySlider.value.ToString(""); //float with zero decimals
    }


}
