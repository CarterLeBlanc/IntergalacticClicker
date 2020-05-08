using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Holds code for displaying the amount of influence gained
/// </summary>
public class GlobalInfluenceBehavior : MonoBehaviour
{
    /// <summary>
    /// Holds the amount of influence gained
    /// </summary>
    public static int InfluenceCount;
    /// <summary>
    /// Game object that holds a display for the amount of influence.
    /// </summary>
    public GameObject InfluenceDisplay;
    /// <summary>
    /// Holds the internal value of influence gained.
    /// </summary>
    public int InternalInfluenceCount;

    /// <summary>
    /// Update the display of influence gained once per frame.
    /// </summary>
    void Update()
    {
        //Set the internal count to InfluenceCount
        InternalInfluenceCount = InfluenceCount;
        //Set text to display the amount of influence gained
        InfluenceDisplay.GetComponent<Text>().text = "Influence: " + InternalInfluenceCount;
    }
}
