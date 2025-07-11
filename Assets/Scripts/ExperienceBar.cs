using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceBar : MonoBehaviour
{
    [SerializeField]
    Slider slider; // drag the slider component into this field

    [SerializeField]
    TMPro.TextMeshProUGUI levelText;

    public void UpdateExperienceSlider(int current, int target)
    {
        slider.maxValue = target;
        slider.value = current;
    }

    public void SetLevelText(int level)
    {
        levelText.text = "LVL: " + level.ToString();
    }
}
