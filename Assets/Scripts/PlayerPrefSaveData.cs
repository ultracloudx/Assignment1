using System.Collections;
using UnityEngine;

public class PlayerPrefSaveData : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    
    void Start()
    {
        //PlayerPrefs.SetInt("");
        PlayerPrefs.GetInt("");
    }

    
}
