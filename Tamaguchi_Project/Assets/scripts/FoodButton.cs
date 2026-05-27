using UnityEngine;

public class FoodButton : MonoBehaviour
{
    [SerializeField] private petStats petStats;
    [SerializeField] private float hungerGain = 20f;
    [SerializeField] private float happinessGain = 5f;
    [SerializeField] private float energyGain = 20f;

    public void UseFood()
    {
        if (petStats != null)
        {
            petStats.FeedPet(hungerGain, happinessGain, energyGain);
        }
    }
}