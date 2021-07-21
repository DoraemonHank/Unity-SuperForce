using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 加上這行,才可以去宣告UI類型的原件(例如 Image)

public class Life_UI : MonoBehaviour
{
    public Image Show_Life_UI; // 使用image ui,是陣列
    public Sprite[] Sprite_Texture; // 圖片的類型,UI裡面要呈現的圖片,是陣列


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        for(int i = 0; i < 10; i++)
        {
            if(Get_Gem_Totle.life_num == 0)
            {
                Show_Life_UI.enabled = false;
            }
            else if (Get_Gem_Totle.life_num == i+1)
            {
                Show_Life_UI.enabled = true;
                Show_Life_UI.sprite = Sprite_Texture[i];
            }
        }

        


    }
}
