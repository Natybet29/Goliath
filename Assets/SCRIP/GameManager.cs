using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public Scene lvl1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void Volverajugar() {
    SceneManager.LoadScene("goliat");
}

    public void Empezarajugar() {
    SceneManager.LoadScene("goliat");
   }

   public void Salirdeljuego() {
       Application.Quit();
   }

   public void Iramenu() {
       SceneManager.LoadScene("Menu principal");
   }
}