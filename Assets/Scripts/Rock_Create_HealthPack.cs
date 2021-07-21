using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock_Create_HealthPack : MonoBehaviour
{
    public GameObject gem;
    public GameObject create_point; //寶石生成點
    private int random_value;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Play_Bullet" || collision.gameObject.tag == "Grnade")
        {
            // Debug.Log("fuck");
            random_value = Random.Range(0, 5); // 0~4亂數
            //Debug.Log("fuck " + random_value);
            //if (random_value <=1 )
                Instantiate(gem, 
                    create_point.transform.position, //生成的位置是在create_point,而不是直接生成在石頭上面,如果直接生成在石頭上面,位置可能會太低,會看不到,所以transform.position前面要加create_point.
                    transform.rotation);
        }
    }
}
