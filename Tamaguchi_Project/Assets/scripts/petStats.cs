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

    public void FeedPet()
    {
        hunger = Mathf.Min(hunger + 20f, 100f);
        happiness = Mathf.Min(happiness + 5f, 100f);
    }

    

}
