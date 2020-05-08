using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds code for controlling what happens when an upgrade is purchased.
/// </summary>
public class PurchaseBehavior : MonoBehaviour
{
    /// <summary>
    /// Game object that holds Auto Fire.
    /// </summary>
    public GameObject AutoFire;
    /// <summary>
    /// Game object that holds Auto Influence.
    /// </summary>
    public GameObject AutoInfluence;

    /// <summary>
    /// Activates the Auto Fire upgrade.
    /// </summary>
    public void StartAutoFire()
    {
        //Set AutoFire to active
        AutoFire.SetActive(true);
        //Subtract the upgrade cost from the amount of influence
        GlobalInfluenceBehavior.InfluenceCount -= GlobalAutoFireBehavior.AutoFireValue;
        //Double the cost of the upgrade
        GlobalAutoFireBehavior.AutoFireValue *= 2;
        //Turn off the AutoFire upgrade button
        GlobalAutoFireBehavior.ButtonOff = true;
        //Turn of the AutoInfluence upgrade button
        GlobalAutoInfluenceBehavior.ButtonOff = true;
        //Increment AutoFirePerSecond
        GlobalAutoFireBehavior.AutoFirePerSecond++;
    }

    /// <summary>
    /// Activates the Auto Influence upgrade.
    /// </summary>
    public void StartAutoInfluence()
    {
        //Set AutoInfluence to active
        AutoInfluence.SetActive(true);
        //Subtract teh upgrade cost from the amount of Influence
        GlobalInfluenceBehavior.InfluenceCount -= GlobalAutoInfluenceBehavior.AutoInfluenceValue;
        //Double the cost of the upgrade
        GlobalAutoInfluenceBehavior.AutoInfluenceValue *= 2;
        //Turn of the AutoInfluence upgrade button
        GlobalAutoInfluenceBehavior.ButtonOff = true;
        //Turn off the AutoFire upgrade button
        GlobalAutoFireBehavior.ButtonOff = true;
        //Increment AutoInfluencePerSecond
        GlobalAutoInfluenceBehavior.AutoInfluencePerSecond++;
    }
}
