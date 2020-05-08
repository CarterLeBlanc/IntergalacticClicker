using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds code for automatically adding to the planet count.
/// </summary>
public class AutoFireBehavior : MonoBehaviour
{
    /// <summary>
    /// Holds whether or not the program is going through the process of adding to the planet count.
    /// </summary>
    public bool Firing = false;
    /// <summary>
    /// Holds the global value that the planet count grows by.
    /// </summary>
    public static int FireIncrease = 1;
    /// <summary>
    /// Holds the internal value that the plaent count grows by.
    /// </summary>
    public int InternalFireIncrease;

    /// <summary>
    /// Updates the Auto Fire once per frame.
    /// </summary>
    void Update()
    {
        //Set FireIncrease to be the same as AutoFirePerSecond
        FireIncrease = GlobalAutoFireBehavior.AutoFirePerSecond;
        //Set the internal increase to FireIncrease
        InternalFireIncrease = FireIncrease;

        //Check if this action is already being taken
        if (!Firing)
        {
            //If not, set it to true
            Firing = true;
            //Start going through the couroutine to add to the planet count
            StartCoroutine(FireLazer());
        }
    }

    /// <summary>
    /// Adds to the planet count and waits a second.
    /// </summary>
    /// <returns></returns>
    IEnumerator FireLazer()
    {
        //Increase PlanetCount by the value of InternalFire Increase
        GlobalFireBehavior.PlanetCount += InternalFireIncrease;
        //Wait 1 second before continuing
        yield return new WaitForSeconds(1);
        //Set firing to false so that the process can repeat
        Firing = false;
    }
}
