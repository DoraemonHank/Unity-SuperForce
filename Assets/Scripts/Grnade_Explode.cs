using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grnade_Explode : MonoBehaviour
{
    public GameObject smoke;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Unity內建API
    // 當遊戲中的物件被另一個可碰撞的遊戲物件碰撞到時觸發
    private void OnCollisionEnter(
        Collision collision // 敵人的變數名稱
        )
    {
        if(collision.gameObject.tag == "Enemy_Car" || 
           collision.gameObject.tag == "Enemy_Tank" || // 設定一個tag,來判斷是不是有碰到
           collision.gameObject.tag == "Rock"
           ) 
        {
            // 如果有碰到,就爆炸
            Instantiate(smoke, transform.position, transform.rotation); //動態生成爆炸
            Destroy(gameObject); // 爆炸後,把手榴彈(自己),刪除掉
            Destroy(collision.gameObject, 0.3f); // 碰到的那方延遲0.3秒後消失
        }
        else
        {
            // 掉到地上,3秒後自爆
            // StartCoroutine 延遲時間
            StartCoroutine(
                GrnadeExplode()
                );
        }
    }

    IEnumerator  //搭配 StartCoroutine使用
    GrnadeExplode()
    {
        yield return new WaitForSeconds(3); // 延遲3秒

        Instantiate(smoke, transform.position, transform.rotation); //動態生成爆炸
        Destroy(gameObject); // 爆炸後,把手榴彈(自己),刪除掉
    }
}
