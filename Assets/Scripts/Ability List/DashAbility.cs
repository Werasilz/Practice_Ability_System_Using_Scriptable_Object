using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DashAbility : Ability
{
    public float dashVelocity;

    public override void Activate(GameObject parent)
    {
        // Ability Mechanic
        PlayerMovement playerMovement = parent.GetComponent<PlayerMovement>();
        playerMovement.acceleration = dashVelocity;
    }

    public override void BeginCooldown(GameObject parent)
    {
        // Restore when start cooldown
        PlayerMovement playerMovement = parent.GetComponent<PlayerMovement>();
        playerMovement.acceleration = playerMovement.normalAcceleration;
    }
}
