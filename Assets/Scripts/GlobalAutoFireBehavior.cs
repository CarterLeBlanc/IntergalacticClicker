using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Holds code that controls the Auto Fire upgrade
/// </summary>
public class GlobalAutoFireBehavior : MonoBehaviour
{

    /// <summary>
    /// Game object that holds a fake button.
    /// </summary>
    public GameObject FakeFireButton;
    /// <summary>
    /// Game object that holds text for a fake button.
    /// </summary>
    public GameObject FakeFireText;

    /// <summary>
    /// Game object that holds a button.
    /// </summary>
    public GameObject RealFireButton;
    /// <summary>
    /// Game object that holds text for a button.
    /// </summary>
    public GameObject RealFireText;

    /// <summary>
    /// Holds the current amount of influence.
    /// </summary>
    public int CurrentInfluenceCount;
    /// <summary>
    /// Holds the cost to upgrade Auto Fire
    /// </summary>
    public static int AutoFireValue = 25;
    /// <summary>
    /// Holds whether or not the button is usable.
    /// </summary>
    public static bool ButtonOff = false;
    /// <summary>
    /// Game object that holds stats for Auto Fire.
    /// </summary>
    public GameObject AutoFireStats;
    /// <summary>
    /// Holds the amount of times Auto Fire is used each second.
    /// </summary>
    public static int AutoFirePerSecond;

    /// <summary>
    /// Updates the information for the Auto Fire upgrade once per frame.
    /// </summary>
    void Update()
    {
        //Set the current influence count to be equal to InfluenceCount
        CurrentInfluenceCount = GlobalInfluenceBehavior.InfluenceCount;
        //Set the text for AutoFireStats
        AutoFireStats.GetComponent<Text>().text = AutoFirePerSecond + " Auto Fires per second.";

        //Sets the text for the fake upgrade button
        FakeFireText.GetComponent<Text>().text = "Buy Auto Fire Upgrade - " + AutoFireValue + " Influence";
        //Sets the text for the real upgrade button
        RealFireText.GetComponent<Text>().text = "Buy Auto Fire Upgrade - " + AutoFireValue + " Influence";

        //Check if the current influence count is higher than AutoFireValue
        if (CurrentInfluenceCount >= AutoFireValue)
        {
            //If it is, deactivate the fake button...
            FakeFireButton.SetActive(false);
            //And activate the real button
            RealFireButton.SetActive(true);
        }

        //Check if the button is turned off
        if (ButtonOff)
        {
            //If it is, deactivate the real button...
            RealFireButton.SetActive(false);
            //Activate the fake button...
            FakeFireButton.SetActive(true);
            //And set ButtonOff to false
            ButtonOff = false;
        }
    }
}