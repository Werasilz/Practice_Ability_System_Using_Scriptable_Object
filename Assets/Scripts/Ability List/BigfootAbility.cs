using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BigfootAbility : Ability
{
    public Vector3 scaleUp;
    Vector3 normalScale;

    public override void Activate(GameObject parent)
    {
        // Ability Mechanic
        normalScale = parent.transform.localScale;
        parent.transform.localScale = scaleUp;
    }

    public override void BeginCooldown(GameObject parent)
    {
        // Restore when start cooldown
        parent.transform.localScale = normalScale;
    }
}
