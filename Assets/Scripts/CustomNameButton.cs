using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CustomNameButton : MonoBehaviour
{
    public string userNameInput;
    public GameObject inputField;
    public GameObject textDisplay;
    public Text noNamePopUp;
    public Text changeNext;
    public Button button;


    /*public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }*/

    public void StoreName()
    {
        userNameInput = inputField.GetComponent<Text>().text;
        Debug.Log(userNameInput);   //code testing
        if (userNameInput == "")
        {
            noNamePopUp.enabled = true;
            noNamePopUp.GetComponent<Text>().text = "No name entered!";
            button.enabled = false;

        } else
        {
            noNamePopUp.enabled = true;
            noNamePopUp.GetComponent<Text>().text = "Welcome, " + userNameInput + "!";
            button.enabled = true;
        }


        
    }

    public void nextScenePlease()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /*public void confirmName()
    {
        if (inputField.GetComponent<Text>())
        {

        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }*/


}
