using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart_BtnScripe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Play_Fun()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit_Fun()
    {
        Application.Quit();
    }
}
