using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballBehaviour : MonoBehaviour
{
    public LevelBehaviourModel Level;

    // Start is called before the first frame update
    void Start()
    {
        // Level =
        //     Level != null
        //         ? Level
        //         : GameObject.FindWithTag("PointsModel").GetComponent<LevelBehaviourModel>();

        // Debug.Log($"FireballBehaviour -> Level: {Level.ReadLevel()}");

        // if (Level.ReadLevel() < 5)
        //     Destroy(gameObject);

        // Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update() { }
}
