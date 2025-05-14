// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Level : MonoBehaviour
// {
//     int lvl = 1;
//     int exp = 0;
//     [SerializeField] ExperienceBar experienceBar;

//     int TO_LEVEL_UP
//     {
//         get
//         {
//             return lvl * 1000;
//         }
//     }

//     private void Start()
//     {
//         experienceBar.UpdateExperienceSlider(exp, TO_LEVEL_UP);
//         experienceBar.SetLevelText(lvl);
//     }
//     public void AddExperience(int amount)
//     {
//         exp += amount;
//         CheckLevelUp();
//         experienceBar.UpdateExperienceSlider(exp, TO_LEVEL_UP);
//     }

//     public void CheckLevelUp()
//     {
//         if(exp >= TO_LEVEL_UP)
//         {
//             exp -= TO_LEVEL_UP;
//             lvl += 1;
//             experienceBar.SetLevelText(lvl);
//         }
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public LevelBehaviourModel level;
    public ScoreBehaviourModel score;

    public int lvl
    {
        get { return level.ReadLevel(); }
    }

    public int exp
    {
        get { return score.ReadScore(); }
    }

    [SerializeField]
    ExperienceBar experienceBar;

    // int TO_LEVEL_UP
    // {
    //     get { return 1 * 1000; }
    // }

    private void Start()
    {
        // experienceBar.UpdateExperienceSlider(exp, TO_LEVEL_UP);
        // experienceBar.SetLevelText(lvl);

        level.LevelUpdated += (sender, level) =>
        {
            experienceBar.SetLevelText(level);
        };

        score.ScoreUpdated += (sender, score) =>
        {
            experienceBar.UpdateExperienceSlider(score, level.ReadLevel() * 1000);
        };
    }

    public void AddExperience(int amount)
    {
        // exp += amount;
        // CheckLevelUp();
        // experienceBar.UpdateExperienceSlider(exp, TO_LEVEL_UP);

        score.UpdateScore((score) => score + amount);
    }

    public void CheckLevelUp()
    {
        // if (exp >= TO_LEVEL_UP)
        // {
        //     exp -= TO_LEVEL_UP;
        //     lvl += 1;
        //     experienceBar.SetLevelText(lvl);
        // }
    }
}
