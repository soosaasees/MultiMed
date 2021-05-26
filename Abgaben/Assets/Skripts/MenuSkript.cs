using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSkript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))    {
            ToggleMenu();
        }
    }

    public void Restart()  {
        Time.timeScale=1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ToggleMenu() {
         menu.SetActive(!menu.activeSelf);
        if(Time.timeScale==0)   
            Time.timeScale=1;
        else
        Time.timeScale=0;
    }
}
