using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickDetector : MonoBehaviour
{
    public static int cardId = -1;
    public static int skillId =-1;
    public Transform ConfirmButton;
    public Transform CancelButton;
    public Transform SkipButton;

    public void Start()
    {
        SkipButton = GameObject.Find("Canvas").GetComponentInChildren<Transform>().Find("MessagePanel/SkipButton");
        ConfirmButton = GameObject.Find("Canvas").GetComponentInChildren<Transform>().Find("MessagePanel/ConfirmButton");
        CancelButton = GameObject.Find("Canvas").GetComponentInChildren<Transform>().Find("MessagePanel/CancelButton");
    }
    void Update()
    {
        if(this.gameObject.layer == 12)
        {
            if(ClickDetector.cardId > -1)
            {
                ConfirmButton.GetComponent<Button>().interactable = true;
                ConfirmButton.gameObject.SetActive(true);
                CancelButton.gameObject.SetActive(true);
                SkipButton.gameObject.SetActive(false);
            }
        }
        else if(this.gameObject.layer == 13)
        {
            if(ClickDetector.skillId > -1)
            {
                ConfirmButton.GetComponent<Button>().interactable = true;
                ConfirmButton.gameObject.SetActive(true);
                CancelButton.gameObject.SetActive(true);
                SkipButton.gameObject.SetActive(false);
            }
        }
    }
    public void OnPointerClick()
    {
        if(this.gameObject.layer == 12)
        cardId = this.gameObject.GetComponent<CardDisplay>().id;
        else if(this.gameObject.layer == 13)
        skillId = this.gameObject.GetComponent<SkillDisplay>().id;
    }
    
}

