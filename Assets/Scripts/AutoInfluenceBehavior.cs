using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds code for automatically adding to InfluenceCount
/// </summary>
public class AutoInfluenceBehavior : MonoBehaviour
{
    /// <summary>
    /// Holds whether or not the program is going through the process of adding to the influence count.
    /// </summary>
    public bool Influencing = false;
    /// <summary>
    /// Holds the global value that the influence count grows by.
    /// </summary>
    public static int InfluenceIncrease = 1;
    /// <summary>
    /// Holds the internal value that the influence count grows by.
    /// </summary>
    public int InternalInfluenceIncrease;

    /// <summary>
    /// Updates the Auto Influence once per frame.
    /// </summary>
    void Update()
    {
        //Set InfluenceIncrease to be the same as AutoInfluencePerSecond
        InfluenceIncrease = GlobalAutoInfluenceBehavior.AutoInfluencePerSecond;
        //Set the internal increase to InfluenceIncrease
        InternalInfluenceIncrease = InfluenceIncrease;

        //Check if this action is already being taken
        if (!Influencing)
        {
            //If not, set it to true
            Influencing = true;
            //Start going through the couroutine to add to the influence count
            StartCoroutine(AddInfluence());
        }
    }

    /// <summary>
    /// Adds to the influence count and waits a second.
    /// </summary>
    /// <returns></returns>
    IEnumerator AddInfluence()
    {
        //Check if the value of PlanetCount is greater than 0
        if (GlobalFireBehavior.PlanetCount > 0)
        {
            //If it is, increase the influence count by the value of InternalInfluenceIncrease
            GlobalInfluenceBehavior.InfluenceCount += InternalInfluenceIncrease;
            //Subtract the value of InternalInfluenceIncrease from the planet count
            GlobalFireBehavior.PlanetCount -= InternalInfluenceIncrease; 
            //Wait for 1 second
            yield return new WaitForSeconds(1);
            //Set Influencing to false so that the process can repeat
            Influencing = false;
        }

        else
        {
            //Otherwise, set Influencing to false and repeat the process
            Influencing = false;
        }
    }
}
