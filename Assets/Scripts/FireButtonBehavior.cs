using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds code that adds to the planet count for every button click.
/// </summary>
public class FireButtonBehavior : MonoBehaviour
{
    /// <summary>
    /// A game object that holds text.
    /// </summary>
    public GameObject textBox;

    /// <summary>
    /// Adds to the planet count for every button click
    /// </summary>
    public void ClickButton()
    {
        //Add 1 to the planet count every time the button is used
        GlobalFireBehavior.PlanetCount += 1;
    }
}
