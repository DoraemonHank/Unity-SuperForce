using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_Myself : MonoBehaviour
{
    //public int Deg;
    public int x = 0, y = 0, z = 0;
    public float speed = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0 * Time.deltaTime, Deg * Time.deltaTime, 0);
        //transform.Rotate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);
        Vector3 v = new Vector3(x, y, z);
        transform.Rotate(v * speed * Time.deltaTime);
    }
}
