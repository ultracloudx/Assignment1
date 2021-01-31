using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    /*public float PlayingSpeed;
    public Slider speedSlider;
    public Text playingSpeedText;
    */
    
    /*void Start()
    {
        rb.AddForce(0, 200, 500);
    }*/

    // Update is called once per frame
    // We marked this as "Fixed"Updated because we are using it to mess with physics
    void FixedUpdate()
    {
        //PlayingSpeed = speedSlider.GetComponent<Slider>().value;
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        //Debug.Log(PlayingSpeed);
    }

    /*---------------------------------*/
    

    /*void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // don't destroy this game object when a new scene is loaded.
        DontDestroyOnLoad(this.speedSlider);
    }

    public void SetSpeed() //method for the slider on intro screen
    {
        PlayingSpeed = speedSlider.value;
        playingSpeedText.text = PlayingSpeed.ToString();
    }
    public void ShowSpeed() // method for clicking on playing speed button on game screen 
    {
        playingSpeedText.text = PlayingSpeed.ToString();
        speedSlider.value = PlayingSpeed; // you use the speed value here

    }
    public void ChangeSpeed() //method for slider on game screen, so you see that you can still change the value after transfer between screens
    {
        PlayingSpeed = speedSlider.value; // change to the new value from game screen slider
        playingSpeedText.text = speedSlider.value.ToString(); //show updated value
    }*/

}
