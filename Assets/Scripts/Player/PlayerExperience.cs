using UnityEngine;

class PlayerExperience : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private PlayerStats stats;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            AddExperience(300f);
        }
    }

    public void AddExperience(float amount)
    {
        stats.CurrentExperience += amount;

        while (stats.CurrentExperience >= stats.NextLevelExperience)
        {
            stats.CurrentExperience -= stats.NextLevelExperience;
            NextLevel();
        }
    }

    private void NextLevel()
    {
        stats.Level++;
        float currentExperienceRequired = stats.NextLevelExperience;
        float newNextLevelExp = Mathf.Round(currentExperienceRequired + stats.NextLevelExperience * (stats.ExperienceMultiplier / 100));
        stats.NextLevelExperience = newNextLevelExp;
    }
}