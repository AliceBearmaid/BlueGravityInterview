using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TextBox : MonoBehaviour
{
    [Header("Components")]
    public Image portrait;
    public TextMeshPro message;
    public TextMeshPro sender;
    IEnumerator ieWrite;
    public void SendMessage(Dialogue _dialogue)
    {
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
        yield return null;
    }
}
