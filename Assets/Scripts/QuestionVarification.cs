using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionVarification : MonoBehaviour
{

    public GameObject popUpPannel;
    public GameObject newPannel;
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

    public AudioSource audioSource;
    public Button popupAudioButton;

    public AudioClip opticNerveSound;
    public AudioClip lensSound;
    public AudioClip suspensoryLigamentSound;
    public AudioClip ciliaryBodySound;
    public AudioClip opticNerveSoundWrong;
    public AudioClip lensSoundWrong;
    public AudioClip suspensoryLigamentSoundWrong;
    public AudioClip ciliaryBodySoundWrong;

    private AudioClip currentPopupClip;




    public void Checker()
    {
        switch (questionNo)
        {
            case 1:
                if (input.text.ToLower() == opticNerveAnswer)
                {
                    PopUpText("Congrats! You are right this is the Optic Nerve. The Optic Nerve caries the visual message to the brain so we can see!  The optic nerve actually creates a blind spot on the retina, you can see find yours through the activity on the next page.", opticNerveSound);
                    correctQuestions++;
                }
                else
                {
                    PopUpText("Not quite right,this is Optic Nerve. The Optic Nerve caries the visual message to the brain so we can see!  The optic nerve actually creates a blind spot on the retina, you can see find yours through the activity on the next page.", opticNerveSoundWrong);
                
                }
                opticNerveObject.SetActive(false);

                break;
            case 2:
                if (input.text.ToLower() == lensAnswer)
                {
                    PopUpText("Congrats! This is the lens. The lens is how your eye focuses light onto the retina. It can make itself flatter or rounder depending on how far away an object is.", lensSound);

                    correctQuestions++;
                }
                else
                {
                    PopUpText("Not quite right, this is the lens. The lens is how your eye focuses light onto the retina. It can make itself flatter or rounder depending on how far away an object is.", lensSoundWrong);
            
                }
                lensObject.SetActive(false);
                break;
            case 3:
                if (input.text.ToLower() == suspensoryLigamentAnswer)
                {
                    PopUpText("Congrats! you are right this is the Suspensory Ligaments. The Suspensory Ligaments connect the Lens to the Ciliary Body.  It keeps the Lens in place and  enables it to change shape.", suspensoryLigamentSound);
                    correctQuestions++;
                }
                else
                {
                    PopUpText("Not quite right, this is the Suspensory Ligaments. The Suspensory Ligaments connect the Lens to the Ciliary Body.  It keeps the Lens in place and  enables it to change shape.", suspensoryLigamentSoundWrong);
    
                }
                suspensoryLigamentObject.SetActive(false);
                break;
            case 4:
                if (input.text.ToLower() == ciliaryBodyAnswer)
                {
                    PopUpText("Congrats! This is the Ciliary body. The ciliary body helps the lens change shape so the eye can focus.", ciliaryBodySound);
                    correctQuestions++;
                }
                else
                {
                    PopUpText("Not quite right, This is the Ciliary body. The ciliary body helps the lens change shape so the eye can focus.", ciliaryBodySoundWrong);
                }
                ciliarybodyObject.SetActive(false);

                break;

        }


    }


    public void PopUpText(string popUpText, AudioClip soundClip)
    {

        popUpPannel.SetActive(true);

        popUpPannel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = popUpText;

        currentPopupClip = soundClip; // store the correct sound

        popupAudioButton.onClick.RemoveAllListeners(); // remove old listeners
        popupAudioButton.onClick.AddListener(PlayPopupAudio); // assign the listener

    }

    public void QuestionNumber()
    {
        questionNo++;
        popUpPannel.SetActive(false);

        input.text = "";

        switch (questionNo)
        {

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

    public void PlayPopupAudio()
    {
        if (currentPopupClip != null)
        {
            audioSource.PlayOneShot(currentPopupClip);
        }
    }

}


