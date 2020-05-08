using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Holds code that controls the Auto Influence upgrade
/// </summary>
public class GlobalAutoInfluenceBehavior : MonoBehaviour
{
    /// <summary>
    /// Game object that holds a fake button.
    /// </summary>
    public GameObject FakeInfluenceButton;
    /// <summary>
    /// Game object that holds text for a fake button.
    /// </summary>
    public GameObject FakeInfluenceText;

    /// <summary>
    /// Game object that holds a button.
    /// </summary>
    public GameObject RealInfluenceButton;
    /// <summary>
    /// Game object that holds text for a button.
    /// </summary>
    public GameObject RealInfluenceText;

    /// <summary>
    /// Holds the current amount of influence.
    /// </summary>
    public int CurrentInfluenceCount;
    /// <summary>
    /// Holds the cost to upgrade Auto Influence.
    /// </summary>
    public static int AutoInfluenceValue = 25;
    /// <summary>
    /// Holds whether or not the button is usable.
    /// </summary>
    public static bool ButtonOff = false;
    /// <summary>
    /// Game object that holds stats for Auto Influence
    /// </summary>
    public GameObject AutoInfluenceStats;
    /// <summary>
    /// Holds the amount of times Auto Influence is used each second.
    /// </summary>
    public static int AutoInfluencePerSecond;

    /// <summary>
    /// Updates the information for the Auto Influence upgrade once per frame.
    /// </summary>
    void Update()
    {
        //Set the current influence count to be equal to InfluenceCount
        CurrentInfluenceCount = GlobalInfluenceBehavior.InfluenceCount;
        //Set the text for AutoInfluenceStats
        AutoInfluenceStats.GetComponent<Text>().text = AutoInfluencePerSecond + " Auto Influence per second.";

        //Sets the text for the fake upgrade button
        FakeInfluenceText.GetComponent<Text>().text = "Buy Auto Influence Upgrade - " + AutoInfluenceValue + " Influence";
        //Sets the text for the real upgrade button
        RealInfluenceText.GetComponent<Text>().text = "Buy Auto Influence Upgrade - " + AutoInfluenceValue + " Influence";

        //Check if the current influence count is higher than AutoInfluenceValue
        if (CurrentInfluenceCount >= AutoInfluenceValue)
        {
            //If it is, deactivate the fake button...
            FakeInfluenceButton.SetActive(false);
            //And activate the real button
            RealInfluenceButton.SetActive(true);
        }

        //Check if the button is turned off
        if (ButtonOff)
        {
            //If it is, deactivate the real button...
            RealInfluenceButton.SetActive(false);
            //Activate the fake button...
            FakeInfluenceButton.SetActive(true);
            //And set ButtonOff to false
            ButtonOff = false;
        }
    }
}
