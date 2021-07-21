using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCar_Move_Fire : MonoBehaviour
{
    public GameObject Player; // 玩家,因為要打玩家
    public GameObject Fire_Point; // 子彈生成點
    public GameObject Fire_Particle; // 火花
    public GameObject[] Tires = new GameObject[4]; // 控制輪胎
    public Rigidbody bulletSource; // 子彈

    public int Fire_Y = -5; // 子彈射擊出去的高度
    public int Fire_Z = 50; // 子彈射擊出去的距離

    public float Move_Dis_Num = 100f;
    public float Fire_Dis_Num = 70f;

    

    private float Distance; // 敵人跟玩家的距離
    private float i; // 敵人開火的頻率

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(transform.position, Player.transform.position);

        // 當敵人跟玩家距離小於100時,
        // 朝玩家前進,並且面相玩家
        // 而且讓輪胎旋轉
        if(Distance < Move_Dis_Num)
        {
            for(int i = 0; i < Tires.Length; i++)
                Tires[i].GetComponent<rotate_Myself>().enabled = true; // 啟用套在物在上面的程式

            // 朝某一個方向前進
           // if (Distance < 10)
                transform.position = Vector3.MoveTowards( 
                                                         transform.position, // 起始位置(敵人自己)
                                                         Player.transform.position, // 到達為置(玩家)
                                                         0.05f // 前進速度
                                                         );

            // 面相玩家
            transform.LookAt(Player.transform);

            // 朝玩家開火
            if (Distance < Fire_Dis_Num)
            {
                i += Time.deltaTime;
                if (i > 1f)
                {
                    Instantiate(Fire_Particle, Fire_Point.transform.position, transform.rotation);
                    Rigidbody bullet = Instantiate(bulletSource, Fire_Point.transform.position, transform.rotation);
                    bullet.velocity = transform.TransformDirection(new Vector3(0, Fire_Y, Fire_Z)); // 賦予Rigidbody一個速度,一個投擲的力量
                    i = 0;
                }
            }
        }
        else
        {
            // 停止輪胎轉動
            for (int i = 0; i < Tires.Length; i++)
                Tires[i].GetComponent<rotate_Myself>().enabled = false; // 關閉套在物在上面的程式
        }
    }
}
