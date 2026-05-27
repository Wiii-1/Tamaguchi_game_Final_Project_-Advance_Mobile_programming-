using UnityEngine;

public class petStats : MonoBehaviour
{
    public float hunger;
    public float happiness;
    public float energy;
    public float health;

    public float tickTime = 3f;
    public float timer;

    public bool isDead = false;

    void Start()
    {
        hunger = 100f;
        happiness = 100f;
        energy = 100f;
        health = 100f;
    }

    void Update()
    {
        if (isDead) return;

        timer += Time.deltaTime;

        if (timer >= tickTime)
        {
            timer = 0f;

            hunger = Mathf.Max(hunger - 1f, 0f);
            happiness = Mathf.Max(happiness - 1f, 0f);
            energy = Mathf.Max(energy - 1f, 0f);

            if (hunger <= 20f || happiness <= 20f || energy <= 20f)
            {
                float healthLoss = 5f;

                if (hunger <= 0f && energy <= 0f)
                {
                    healthLoss = 10f;
                }

                health = Mathf.Max(health - healthLoss, 0f);
            }

            if (health <= 0f)
            {
                Die();
            }
        }
    }

    public void FeedPet(float hungerAmount, float happinessAmount, float energyAmount)
    {
        if (isDead) return;

        hunger = Mathf.Clamp(hunger + hungerAmount, 0f, 100f);
        happiness = Mathf.Clamp(happiness + happinessAmount, 0f, 100f);
        energy = Mathf.Clamp(energy + energyAmount, 0f, 100f);
    }

    void Die()
    {
        Debug.Log("Your pet has died, You're fucking irresponsible");
        isDead = true;
        Debug.Log("Pet died");
        gameObject.SetActive(false);
    }
}