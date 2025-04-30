using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
  public void ChangeScene(int scene){

     Debug.Log("click");

    SceneManager.LoadScene(scene);
  }

}
 
