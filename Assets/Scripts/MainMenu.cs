using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject quiz;

   void Start() {
   

   Cursor.lockState = CursorLockMode.None;
 
   
   }
   
   public void StartGame() {
   
   mainMenu.SetActive(false);
  
   
   }

   public void Quiz() {

   quiz.SetActive(true);


   }
}

