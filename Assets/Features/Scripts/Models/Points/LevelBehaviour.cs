using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBehaviourModel : MonoBehaviour
{
    //? Interal state.
    private int level = 0;

    //? Fields.
    public int scoreThreshold = 0;

    //? Events
    public event EventHandler<int> LevelUpdated;

    // Start is called before the first frame update
    void Start()
    {
        var PointsModel = GameObject.Find("PointsModel");

        if (!PointsModel.TryGetComponent<ScoreBehaviourModel>(out _))
            return;

        var score = PointsModel.GetComponent<ScoreBehaviourModel>();

        score.ScoreUpdated += (sender, score) =>
        {
            if (score < scoreThreshold)
                return;

            level += 1;
            LevelUpdated?.Invoke(this, level);
            Debug.Log($"LEVEL UP: ${level}");
        };
    }

    // Update is called once per frame
    // void Update()
    // {

    // }

    public int ReadLevel()
    {
        return level;
    }
}
