using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject pMenu;
    private int trig = 0;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Toggle();
        }  
    }

    public void Toggle()
    {
        pMenu.SetActive(!pMenu.activeSelf);

        if (pMenu.activeSelf)
        {
            Time.timeScale = 0f;
        } else
        {
            Time.timeScale = 1f;
        }
    }

    public void Retry()
    {
        Toggle();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu(string nameScene)
    {
        Application.LoadLevel(nameScene);
    }

}
