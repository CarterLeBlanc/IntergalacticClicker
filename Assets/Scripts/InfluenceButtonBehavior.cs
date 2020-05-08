using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Holds code that adds to the Influence count for every button click.
/// </summary>
public class InfluenceButtonBehavior : MonoBehaviour
{
    /// <summary>
    /// A game object that holds text.
    /// </summary>
    public GameObject textBox;
    /// <summary>
    /// A game object that holds a status box.
    /// </summary>
    public GameObject statusBox;

    /// <summary>
    /// Adds to the influence count and removes from the planet count every time the button is clicked.
    /// </summary>
    public void ClickButton()
    {
        //Check to make sure that there is at least 1 planet to exchange
        if (GlobalFireBehavior.PlanetCount > 0)
        {
            //Subtract 1 from the planet count every time the button is used
            GlobalFireBehavior.PlanetCount -= 1;
            //Add 1 to the influence count for every button click
            GlobalInfluenceBehavior.InfluenceCount += 1;
        }
    }
}
