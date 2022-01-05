using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraDeVida : MonoBehaviour
{
    [SerializeField] int vidas;
     //[SerializeField] slider sliderVidas;
     private void OnCollisionEnter2D(Collision2D otro)
     {
          if (otro.gameObject.CompareTag("puñetazo"))
          {
               vidas--;
              // sliderVidas.value = vidas;
          }
          if ( vidas <= 0)
          {
          Destroy(this.gameObject);
          }
     }
}