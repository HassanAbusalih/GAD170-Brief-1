using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
/// calculating our dancing stats based on physical stats and our stat multipliers.
/// </summary>
public class StatsSystem : MonoBehaviour
{
    /// Our physical stats that determine our dancing stats.
    public int agility;
    public int intelligence;
    public int strength;

    // Our variables used to determine our fighting power.
    public float style;
    public float luck;
    public float rhythm;

    private void Start()
    {
        // set out agility, strength and intelligence to a random number between zero and ten.
        // BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.
        int remainingPoints = 20;
        strength = Random.Range(1, 11);
        remainingPoints = remainingPoints - strength;
        agility = Random.Range(1, 11);
        remainingPoints = remainingPoints - agility;
        intelligence = remainingPoints;

        // Debug out your current physical stat values (strength, agility, intelligence).
        Debug.Log(strength);
        Debug.Log(agility);
        Debug.Log(intelligence);
        // let's create some float temporary variables to hold our multiplier values.

        // create an agility multiplier should be set to 0.5
        float agilityMultiplier = 0.5f;
        // create a strength multiplier should be set to 1
        float strengthMultiplier = 1.0f;
        // create an intelligence multiplier should be set to 2.
        float intelligenceMultiplier = 2.0f;
        // Debug out our current multiplier values.
        Debug.Log(agilityMultiplier);
        Debug.Log(strengthMultiplier);
        Debug.Log(intelligenceMultiplier);
        // now that we have some stats and our multiplier values let's calculate our style, luck and ryhtmn based on these values.

        // style should be based off our strength and be converted at a rate of 1 : 1.
        style = strength * strengthMultiplier;
        // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        luck = intelligence * 1.5f;
        // rhythm should be based off our agility and be converted at a rate of 1 : 0.5.
        rhythm = agility * agilityMultiplier;

        // Debug out our current dancing stat values (style, luck, rhythm)
        Debug.Log(style);
        Debug.Log(luck);
        Debug.Log(rhythm);
        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.
        int additionalPoints = 10;
        int strengthPlusAgility = strength + agility;
        strength = strength + Random.Range(1, 5);
        agility = agility + Random.Range(1, 5);
        int levelledStats = strength + agility;
        additionalPoints = levelledStats - strengthPlusAgility;
        intelligence = intelligence + additionalPoints;
        // Debug out our new physical stat values
        Debug.Log(strength);
        Debug.Log(agility);
        Debug.Log(intelligence);
        // let's recalculate our style, luck and rhytmn as our initial stats have changed.
        style = strength * strengthMultiplier;
        luck = intelligence * 1.5f;
        rhythm = agility * agilityMultiplier;
        // Debug out our new dancing stat values
        Debug.Log(style);
        Debug.Log(luck);
        Debug.Log(rhythm);
    }
}
