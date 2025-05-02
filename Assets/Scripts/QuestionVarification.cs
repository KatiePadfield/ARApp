using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionVarification : MonoBehaviour
{

    public GameObject popUpPannel;
    public TMP_InputField input;
    public GameObject opticNerveObject;
    public string opticNerveAnswer = "optic nerve";
    public GameObject lensObject;
    public string lensAnswer = "lens";
    public GameObject suspensoryLigamentObject;
    public string suspensoryLigamentAnswer = "suspensory ligament";
    public GameObject ciliarybodyObject;
    public string ciliaryBodyAnswer = "ciliary body";

    private int questionNo = 1;

    private int correctQuestions = 0;

    public void Checker(){
        switch(questionNo){
            case 1: 
            if(input.text.ToLower() == opticNerveAnswer){
                PopUpText("Conrats! you are right this is the Optic Nerve");
                correctQuestions++;
            }else{
                PopUpText("NOOOOOOOOOOOO");
            }
            opticNerveObject.SetActive(false);
            break;
            case 2:
              if(input.text.ToLower() == lensAnswer){
                PopUpText("Conrats! you are right this is the Lens");
                correctQuestions++;
            }else{
                PopUpText("NOOOOOOOOOOOO");
            }
            lensObject.SetActive(false);
            break;
            case 3:
            if(input.text.ToLower() == suspensoryLigamentAnswer){
                PopUpText("Conrats! you are right these are the suspensory ligaments");
                correctQuestions++;
            }else{
                PopUpText("NOOOOOOOOOOOO");
            }
           suspensoryLigamentObject.SetActive(false);
            break;
            case 4:
             if(input.text.ToLower() == ciliaryBodyAnswer){
                PopUpText("Conrats! you are right this is the ciliary body");
                correctQuestions++;
            }else{
                PopUpText("NOOOOOOOOOOOO");
            }
           ciliarybodyObject.SetActive(false);
            
            break;
            
        }

      
    }
     

       public void PopUpText(string popUpText){
            
            popUpPannel.SetActive(true);

            popUpPannel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = popUpText;
            

        }

        public void QuestionNumber(){
            questionNo++;
            popUpPannel.SetActive(false);

              switch(questionNo){

            case 2:
            lensObject.SetActive(true);
            break;
            case 3:
            suspensoryLigamentObject.SetActive(true);
            break;
            case 4:
            ciliarybodyObject.SetActive(true);
            break;
            case 5:
            //show final text here
            break;
            
        }
        }

        

}
