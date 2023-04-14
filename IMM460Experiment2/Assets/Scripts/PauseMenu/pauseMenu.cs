using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject pausePanel; //store pausemenu panel for manipulation by game manager
    public GameObject pauseCanvas; //stores pauseCanvas so that it can be kept across scenes
    public static bool isPaused;
    
    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
    }

    // KEEPS PAUSE MANAGER ACROSS SCENES AS WELL AS CANVAS
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);//carries gameobject on scene change
        DontDestroyOnLoad(pauseCanvas);//carries gameobject on scene change
        DontDestroyOnLoad(pausePanel);//carries gameobject on scene change
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                ResumeGame();
            }else{
                PauseGame();
            }
        }
        
    }

    public void PauseGame(){ //set tiem to 0 to stop movement
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame(){ //start the game back up
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    /*
    public void MainMenu(){ //if main menu button clicked, go to main menu
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
    */

    public void QuitGame(){ //if quit game button clicked, close application
        Application.Quit();
    }
}
