using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int maxHp = 1000;
    public int currentHp = 1000;
    [SerializeField] StatusBar hpBar; // calls the StatusBar script, make sure that the gameobject HPBarBase is inside the HP Bar field of PlayerCharacter object

    [HideInInspector] public Level lvl;
    [HideInInspector] public Gold gold; // makes a variable lvl and gold that would be used to reference
    private void Awake()
    {
        lvl = GetComponent<Level>(); // references the Level and Gold scripts
        gold = GetComponent<Gold>();
    }
    public void Start()
    {
        hpBar.SetState(currentHp, maxHp);

    }
    public void TakeDamage(int damage)
    {
        currentHp -= damage;

        if(currentHp <= 0)
        {
            Debug.Log("Character is dead");
        }
        hpBar.SetState(currentHp, maxHp);
    }

    public void Heal(int amount)
    {
        if(currentHp <= 0) { return; }
        currentHp += amount;
        if (currentHp > maxHp) { currentHp = maxHp; } // prevents the PlayerCharacter from over healing
        hpBar.SetState(currentHp, maxHp);
    }
}
