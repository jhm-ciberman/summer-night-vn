using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Ending", menuName = "Ending")]
public class EndingData : ScriptableObject
{
    public string title;

    [TextArea]
    public string subtitle;

    public Sprite image;

    public string endingNumber;
}