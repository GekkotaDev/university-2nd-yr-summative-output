using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    int lvl = 1;
    int exp = 0;
    [SerializeField] ExperienceBar experienceBar;

    int TO_LEVEL_UP
    {
        get
        {
            return lvl * 1000;
        }
    }

    private void Start()
    {
        experienceBar.UpdateExperienceSlider(exp, TO_LEVEL_UP);
        experienceBar.SetLevelText(lvl);
    }
    public void AddExperience(int amount)
    {
        exp += amount;
        CheckLevelUp();
        experienceBar.UpdateExperienceSlider(exp, TO_LEVEL_UP);
    }

    public void CheckLevelUp()
    {
        if(exp >= TO_LEVEL_UP)
        {
            exp -= TO_LEVEL_UP;
            lvl += 1;
            experienceBar.SetLevelText(lvl);
        }
    }
}
