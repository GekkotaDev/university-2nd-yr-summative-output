using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    // this is a script that decides whether an object can take damage by referencing this script and the TakeDamage function
    public void TakeDamage(int damage);
}
