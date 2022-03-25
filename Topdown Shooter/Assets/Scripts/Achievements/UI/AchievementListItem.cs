using Achievements.Data;
using UnityEngine;

namespace Achievements.UI
{
    public class AchievementListItem : MonoBehaviour
    {
        [SerializeField]
        private TMPro.TextMeshProUGUI achievementText;

        public void UpdateAchievementText(AchievementData achievement)
        {
            achievementText.text = $"{achievement.achievementName}: {achievement.currentProgress}/{achievement.condition}";
        }
    }
}