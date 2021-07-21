using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 遊戲場景 add+

public class Play_Life_UI : MonoBehaviour
{
    public GameObject Game_Fail_UI, Game_Finish_UI;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Get_Gem_Totle.gem_numbers = 0;
        Get_Gem_Totle.life_num = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Get_Gem_Totle.life_num <= 0)
        {
            Game_Fail_UI.SetActive(true);
            SceneManager.LoadScene("Game_Start"); // 載入一開始的遊戲場景,function裡是要餵string
        } 
        
        if(Get_Gem_Totle.life_num > 0 && Get_Gem_Totle.gem_numbers == 4)
        {
            Game_Finish_UI.SetActive(true);
            StartCoroutine(
                "GamePass"
                );
           
           // SceneManager.LoadScene("Game_Start");
        }   
    }

    IEnumerator GamePass()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Game_Start");
    }
}
