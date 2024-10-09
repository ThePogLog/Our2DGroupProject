using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //when press ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {

                //pause menu visible and stop the game from playing OR make it dispear and start the game again.
                GetComponent<Canvas>().enabled = true;

                Time.timeScale = 0;

            }
            else
            {
                Resume();
            }

        }

    }


    public void Resume()
    {
        GetComponent<Canvas>().enabled = false;

        Time.timeScale = 1;
    }

    public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
