using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTextBehaviourModel : MonoBehaviour
{
    public ScoreBehaviourModel Score;
    public TMP_Text label;

    // Start is called before the first frame update
    void Start()
    {
        label.text = $"{Score.RetrieveScoreData()}";
    }

    // Update is called once per frame
    // void Update()
    // {

    // }
}
