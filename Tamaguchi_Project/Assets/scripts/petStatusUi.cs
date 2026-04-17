using UnityEngine;
using UnityEngine.UI;

public class petStatusUI : MonoBehaviour
{
    public petStats petStats;

    public Image HealthFill;
    public Image EnergyFill;
    public Image HungerFill;
    public Image HappinessFill;

    public Text HealthLabel;
    public Text HungerLabel;
    public Text EnergyLabel;
    public Text HappinessLabel;

    void Update()
    {
        if (petStats == null) return;

        HealthFill.fillAmount = petStats.health / 100f;
        EnergyFill.fillAmount = petStats.energy / 100f;
        HungerFill.fillAmount = petStats.hunger / 100f;
        HappinessFill.fillAmount = petStats.happiness / 100f;

        if (HealthLabel != null)
            HealthLabel.text = "Health " + Mathf.RoundToInt(petStats.health);

        if (HungerLabel != null)
            HungerLabel.text = "Hunger " + Mathf.RoundToInt(petStats.hunger);

        if (EnergyLabel != null)
            EnergyLabel.text = "Energy " + Mathf.RoundToInt(petStats.energy);

        if (HappinessLabel != null)
            HappinessLabel.text = "Happiness " + Mathf.RoundToInt(petStats.happiness);
    }
}