using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet_Move : MonoBehaviour
{
    public float MoveSoeed = 30;
    public float Destory_Time = 1.5f;
    public GameObject smoke;

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
            if(  collision.gameObject.tag == "Rock" || 
                 collision.gameObject.tag == "Enemy_Car" || 
                 collision.gameObject.tag == "Enemy_Tank"
              )
            {
                Destroy(collision.gameObject, 0.3f);
            }
            Destroy(gameObject); // 爆炸後,把子彈(自己),刪除掉
       
    }
}
