using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    //variables globales que controlan las 2 velocidades
public float velocidad=6f;
    public float velocidad2=7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {  Debug.Log(transform.position.x);
           
                transform.position += Vector3.left * velocidad * Time.deltaTime;
            
          
        
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
        {
            //transform.position += Vector3.up * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            //transform.position += Vector3.down * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            transform.position += Vector3.right * velocidad * Time.deltaTime;
        }
    }
}
