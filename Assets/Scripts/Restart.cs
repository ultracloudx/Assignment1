using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour
{

    public void backToBeginning()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }

}
