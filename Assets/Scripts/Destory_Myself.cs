using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory_Myself : MonoBehaviour
{
    public float time;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, time);
    }
}
