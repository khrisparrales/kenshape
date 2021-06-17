using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ia : MonoBehaviour
{
    public float velocidad=6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>=-39&&transform.position.x<=19){
Debug.Log("Reinicio");transform.position += Vector3.left * velocidad * Time.deltaTime;
        }else{
            transform.position =  new Vector3(19, -16, -9);
        }
         
            
    }
}
