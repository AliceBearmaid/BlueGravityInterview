using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TextBox : UIElement
{
    [Header("Components")]
    [SerializeField] Image portrait;
    [SerializeField] TextMeshProUGUI nameTag;
    [SerializeField] TextMeshProUGUI message;
    [Header("Configuration")]
    [SerializeField] float writeSpeed;
    [SerializeField] float startDelay;
    IEnumerator ieWrite;
   

    public void SetDialogue(Dialogue _dialogue)
    {
        portrait.sprite = _dialogue.protrait;
        nameTag.color = _dialogue.nameTagColor;
        nameTag.text = _dialogue.sender;

        message.text = "";
        if(ieWrite != null)
        {
            StopCoroutine(ieWrite);
            ieWrite = null;
        }
        ieWrite = IEWriteMessage(_dialogue);
        StartCoroutine(ieWrite);
    }

    IEnumerator IEWriteMessage(Dialogue _dialogue)
    {
        yield return new WaitForSeconds(startDelay);
        for(int i =0; i<_dialogue.message.Length; i++)
        {
            message.text += _dialogue.message[i];
            yield return new WaitForSeconds(writeSpeed);
        }
    }
}
