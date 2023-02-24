using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
public GameObject PauseMenuUI;
public GameObject Game;
public GameObject GameOver;
public PlayerMovement pm;

    public void Pause()
    {

        PauseMenuUI.SetActive(true);
        Game.SetActive(false);
        	Time.timeScale = 0;

    }

      public void Over()
    {

        GameOver.SetActive(true);
                Game.SetActive(false);
                        	Time.timeScale = 0;


    }
    public void Continue(){
              GameOver.SetActive(false);
                Game.SetActive(true);
                	Time.timeScale = 1;
                  pm.revive();
    }
      public void Resume()
    {
        PauseMenuUI.SetActive(false);
                Game.SetActive(true);
                	Time.timeScale = 1;
    }
   public void Exit()
    {                         	
      Time.timeScale = 1;
      SceneManager.LoadScene("MainMenu");
    }

       public void chapter2()
    {                         	
      Time.timeScale = 1;
      SceneManager.LoadScene("Stage2");
    }
           public void chapter3()
    {                         	
      Time.timeScale = 1;
      SceneManager.LoadScene("Stage3");
    }
  public void Again()
    {    
                        	Time.timeScale = 1;
      SceneManager.LoadScene("Stage1");
    }
      public void Again2()
    {    
                        	Time.timeScale = 1;
      SceneManager.LoadScene("Stage2");
    }
          public void Again3()
    {    
                        	Time.timeScale = 1;
      SceneManager.LoadScene("Stage3");
    }

}
