using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 加上這行,才可以去宣告UI類型的原件

public class Gem_UI : MonoBehaviour
{
    public Image[] Show_Gem_UI; // 使用image ui,是陣列
    public Sprite[] Sprite_Texture; // 圖片的類型,UI裡面要呈現的圖片,是陣列
                                    // 0 -> 灰色寶石
                                    // 1 -> 彩色寶石

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //如果取得寶石數量是0,UI上的寶石圖案就全都是灰的
        if (Get_Gem_Totle.gem_numbers == 0)
        {
            // 4個UI都顯示灰色寶石的圖片
            for (int i = 0; i < 4;i++)
                Show_Gem_UI[i].sprite = Sprite_Texture[0]; // 0 -> 灰色寶石
        }

        // 取的寶石後,該欄位變彩色的寶石
        // Sprite_Texture[1]; 1 -> 彩色寶石

        //Debug.Log(Get_Gem_Totle.gem_numbers);

        if (Get_Gem_Totle.gem_numbers == 1)
        {
            Show_Gem_UI[0].sprite = Sprite_Texture[1]; // 1 -> 彩色寶石
            Show_Gem_UI[1].sprite = Sprite_Texture[0];
            Show_Gem_UI[2].sprite = Sprite_Texture[0];
            Show_Gem_UI[3].sprite = Sprite_Texture[0];
        }
        if (Get_Gem_Totle.gem_numbers == 2)
        {
            Show_Gem_UI[0].sprite = Sprite_Texture[1];
            Show_Gem_UI[1].sprite = Sprite_Texture[1];
            Show_Gem_UI[2].sprite = Sprite_Texture[0];
            Show_Gem_UI[3].sprite = Sprite_Texture[0];
        }
        if (Get_Gem_Totle.gem_numbers  == 3)
        {
            Show_Gem_UI[0].sprite = Sprite_Texture[1];
            Show_Gem_UI[1].sprite = Sprite_Texture[1];
            Show_Gem_UI[2].sprite = Sprite_Texture[1];
            Show_Gem_UI[3].sprite = Sprite_Texture[0];
        }
        if (Get_Gem_Totle.gem_numbers  == 4)
        {
            Show_Gem_UI[0].sprite = Sprite_Texture[1];
            Show_Gem_UI[1].sprite = Sprite_Texture[1];
            Show_Gem_UI[2].sprite = Sprite_Texture[1];
            Show_Gem_UI[3].sprite = Sprite_Texture[1];
        }
    }
}
