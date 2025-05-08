using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusBar : MonoBehaviour
{
    [SerializeField] Transform bar;

    public void SetState(int current, int max)
    {
        float state = (float) current;
        state /= max;
        if (state < 0f) { state = 0f; } // prevents the hp bar from going past the hp bar container, also make sure that the gameobject HPBarContainer is inside the field Bar.
        bar.transform.localScale = new Vector3(state, 1f, 1f);

    }
}
