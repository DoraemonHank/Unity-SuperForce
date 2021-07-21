using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar_Detection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy_Point")
        {
            other.gameObject.GetComponent<MeshRenderer>().enabled = true;
           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy_Point")
        {
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            Debug.Log("=================== Enemy_Point ======================");
        }
    }

}
