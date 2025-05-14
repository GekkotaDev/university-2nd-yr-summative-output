using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBehaviourModel : MonoBehaviour
{
    //? Internal state.
    private int score = 0;

    //? Fields
    public bool loadSavedScore = false;

    //? Events
    public event EventHandler<int> ScoreUpdated;

    // Start is called before the first frame update
    void Start()
    {
        if (loadSavedScore)
            score = RetrieveScoreData();
    }

    // Update is called once per frame
    // void Update()
    // {

    // }

    public void PersistScoreData()
    {
        //! Time constraints, no more JSON persistence layer.
        PlayerPrefs.SetInt("Score", score);
    }

    public void UpdateScore(Func<int, int> callback)
    {
        score = callback(score);
        ScoreUpdated?.Invoke(this, score);
    }

    public int RetrieveScoreData()
    {
        return PlayerPrefs.GetInt("Score", 0);
    }

    public int ReadScore()
    {
        return score;
    }

    void OnDestroy()
    {
        var savedScore = RetrieveScoreData();

        if (score > savedScore)
            PersistScoreData();
    }
}
