using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enter_to_start : MonoBehaviour
{
    // Start is called before the first frame update

    public string firstlevel;
    public void StartGame()
    {
        SceneManager.LoadScene(firstlevel);
    }

    // Update is called once per frame
    public void options()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
