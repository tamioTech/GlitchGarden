using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{

    [SerializeField] int starCost;
    int cactusCost = 150;
    int starTrophyCost = 75;
    int gnomeCost = 375;
    int tombStoneCost = 225;

    public int GetStarCost()
    {
        return starCost;
    }

    public int GetCacutsCost()
    {
        return cactusCost;
    }

    public int GetStarTropyCost()
    {
        return starTrophyCost;
    }

    public int GetGnomeCost()
    {
        return gnomeCost;
    }

    public int GetTombStoneCost()
    {
        return tombStoneCost;
    }

    public void AddStars(int amount)
    {
        FindObjectOfType<StarDisplay>().AddStars(amount);
    }

}
