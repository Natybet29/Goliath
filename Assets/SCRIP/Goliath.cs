using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goliath : MonoBehaviour
{


    
     private void Start()
     {
     
          rgb2d=GetComponent<Rigidbody2D> ();
           
     }

     public Rigidbody2D rgb2d;
     public float movimiento = 2f;
     public float movimientox= 1f;

     public Animator animator;
     
    

    // Update is called once per frame
    void Update()
    {
         
     if (Input.GetKey ("d"))
    {
        rgb2d.velocity = new Vector2 (movimiento, 0);
        animator.SetBool ("camina",(Input.GetKey ("d")));
    } 

      if ((Input.GetKey("d") ==false)) 
      {
          animator.SetBool ("camina",false);
      }
    
     if(Input.GetKey("space")){
       animator.SetBool("golpea",true);
}
     if(Input.GetKey("space")==false){
       animator.SetBool("golpea",false);
       }
}

     }  
 