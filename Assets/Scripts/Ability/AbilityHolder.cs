using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHolder : MonoBehaviour
{
    public Ability ability;
    public float cooldownTime;
    public float activeTime;
    public KeyCode key;

    enum AbilityState
    {
        ready,
        active,
        cooldown,
    }

    // Set Start State
    AbilityState state = AbilityState.ready;

    private void Update()
    {
        switch (state)
        {
            case AbilityState.ready:
                if (Input.GetKeyDown(key))
                {
                    // Use Ability
                    ability.Activate(gameObject);

                    // Change state to Active
                    state = AbilityState.active;
                    activeTime = ability.activeTime;
                }
                break;
            case AbilityState.active:
                if (activeTime > 0)
                {
                    activeTime -= Time.deltaTime;
                }
                else
                {
                    // Active Time is End
                    // Start Cooldown
                    ability.BeginCooldown(gameObject);

                    // Change state to Cooldown
                    state = AbilityState.cooldown;
                    cooldownTime = ability.cooldownTime;
                }
                break;
            case AbilityState.cooldown:
                if (cooldownTime > 0)
                {
                    cooldownTime -= Time.deltaTime;
                }
                else
                {
                    // Cooldown Time is End
                    // Change State to Ready
                    state = AbilityState.ready;

                    // Reset 
                    cooldownTime = 0;
                    activeTime = 0;
                }
                break;
        }


    }
}
