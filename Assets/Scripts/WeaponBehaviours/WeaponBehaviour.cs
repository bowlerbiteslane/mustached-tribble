﻿using UnityEngine;
using System.Collections;

public abstract class WeaponBehaviour : MonoBehaviour {

	[SerializeField]
    protected float fireRate = 0.5f;
    [SerializeField]
    protected float weaponReach = 2000f;
    [SerializeField]
    protected float weaponDamage = 25f;
    [SerializeField]
    protected float weaponAccuracy = 1f;

    public float FireRate
    {
        get { return fireRate; }
    }
    public float WeaponReach
    {
        get { return weaponReach; }
    }

    public float WeaponDamage
    {
        get { return weaponDamage; }
    }

    /// <summary>
    /// Value between 1 and 0, 1 being the most accurate - returned as a percent of 1
    /// </summary>
    public float WeaponAccuracy
    {
        get { return Mathf.Clamp(weaponAccuracy, 0f, 1f); }
    }


    public abstract void TriggerAttack();
}