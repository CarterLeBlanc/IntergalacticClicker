using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Holds code for displaying the amount of planets destroyed.
/// </summary>
public class GlobalFireBehavior : MonoBehaviour
{
    /// <summary>
    /// Holds the amount of planets destroyed.
    /// </summary>
    public static int PlanetCount;
    /// <summary>
    /// Game object that holds a display for the amount of planets.
    /// </summary>
    public GameObject PlanetCountDisplay;
    /// <summary>
    /// Holds the internal value of planets destroyed.
    /// </summary>
    public int InternalPlanetCount;

    /// <summary>
    /// Update the display of planets destroyed once per frame.
    /// </summary>
    void Update()
    {
        //Set the internal count to PlanetCount
        InternalPlanetCount = PlanetCount;
        //Set text to display the amount of planets destroyed
        PlanetCountDisplay.GetComponent<Text>().text = "Planets Destroyed: " + InternalPlanetCount;
    }
}
