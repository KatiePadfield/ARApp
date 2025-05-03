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
                    PopUpText("Conrats! you are right this is the Optic Nerve", opticNerveSound);
                    //audioSource.PlayOneShot(opticNerveSound);
                    correctQuestions++;
                }
                else
                {
                    PopUpText("NOOOOOOOOOOOO", opticNerveSoundWrong);
                    //audioSource.PlayOneShot(opticNerveSoundWrong);
                }
                opticNerveObject.SetActive(false);

                break;
            case 2:
                if (input.text.ToLower() == lensAnswer)
                {
                    PopUpText("Conrats! you are right this is the Lens", lensSound);
                   // audioSource.PlayOneShot(lensSound);
                    correctQuestions++;
                }
                else
                {
                    PopUpText("NOOOOOOOOOOOO", lensSoundWrong);
                   // audioSource.PlayOneShot(lensSoundWrong);
                }
                lensObject.SetActive(false);
                break;
            case 3:
                if (input.text.ToLower() == suspensoryLigamentAnswer)
                {
                    PopUpText("Conrats! you are right these are the suspensory ligaments", suspensoryLigamentSound);
                   // audioSource.PlayOneShot(suspensoryLigamentSound);
                    correctQuestions++;
                }
                else
                {
                    PopUpText("NOOOOOOOOOOOO", suspensoryLigamentSoundWrong);
                   // audioSource.PlayOneShot(suspensoryLigamentSoundWrong);
                }
                suspensoryLigamentObject.SetActive(false);
                break;
            case 4:
                if (input.text.ToLower() == ciliaryBodyAnswer)
                {
                    PopUpText("Conrats! you are right this is the ciliary body", ciliaryBodySound);
                   // audioSource.PlayOneShot(ciliaryBodySound);
                    correctQuestions++;
                }
                else
                {
                    PopUpText("NOOOOOOOOOOOO", ciliaryBodySoundWrong);
                   // audioSource.PlayOneShot(ciliaryBodySoundWrong);
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

    public void PlayPopupAudio(){
    if (currentPopupClip != null){
        audioSource.PlayOneShot(currentPopupClip);
    }
}



}


