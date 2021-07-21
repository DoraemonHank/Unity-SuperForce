using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet_Collision : MonoBehaviour
{
    public float MoveSoeed = 30;
    public float Destory_Time = 1.5f;
    public GameObject smoke;
    public AudioClip HitSound;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Destory_Time);
    }

    // Update is called once per frame
    void Update()
    {
        //沒辦法產生碰撞到的效果- transform.Translate(0 * Time.deltaTime,0 * Time.deltaTime, MoveSoeed * Time.deltaTime);


    }

    // Unity內建API
    // 當遊戲中的物件被另一個可碰撞的遊戲物件碰撞到時觸發
    private void OnCollisionEnter(
        Collision collision // 敵人的變數名稱
        )
    {

        // 如果有碰到,就爆炸
        Instantiate(smoke, transform.position, transform.rotation); //動態生成爆炸
        if(collision.gameObject.tag == "Player")
        {
            if(Get_Gem_Totle.life_num > 0)
                Get_Gem_Totle.life_num--;
            GetComponent<AudioSource>().PlayOneShot(HitSound);
            Debug.Log(Get_Gem_Totle.life_num);

        }
        Destroy(gameObject,0.2f); // 爆炸後,把子彈(自己),刪除掉
       
    }
}
