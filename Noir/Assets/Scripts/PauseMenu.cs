using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
   public static bool GameIsPaused = false;

   public GameObject pauseMenuUI;

 private void Start() {
    {
        Cursor.visible = false;
    }
}
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                
                Resume();
                Cursor.visible = false;
            } else
            {
                Pause();
            }
        }
        
    }

 public void Resume()
    {
        Cursor.visible = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    
    }

    void Pause()
        {
            Cursor.visible = true;
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }

public void LoadMenu()
{
    Time.timeScale = 1f;
    SceneManager.LoadScene("menu");
}

public void QuitGame()
{
    Application.Quit();
}
}

