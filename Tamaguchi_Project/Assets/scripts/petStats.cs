using UnityEngine;

public class petStats : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float hunger;
    public float happiness;
    public float energy;
    public float health; 

    public float tickTime = 3f;
    public float timer;

    void Start()
    {
        hunger = 100f;
        happiness = 100f;
        energy = 100f;
        health = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= tickTime)
        {
            timer = 0f;

            hunger = Mathf.Max(hunger - 2f, 0f);
            happiness = Mathf.Max(happiness - 1f, 0f);
            energy = Mathf.Max(energy - 1f, 0f);

            if (hunger <= 20f || happiness <= 20f || energy <= 20f)
            {
                health = Mathf.Max(health - 5f, 0f);
            }
        }
    }

    public void FeedPet(float hungerAmount, float happinessAmount)
    {
        hunger = Mathf.Clamp(hunger + hungerAmount, 0f, 100f);
        happiness = Mathf.Clamp(happiness + happinessAmount, 0f, 100f);
    }
}
