using UnityEngine;

namespace Achievements.Data
{
    [CreateAssetMenu(fileName = "newAchievementData", menuName = "Data/Achievement Data", order = 0)]
    public class AchievementData : ScriptableObject
    {
        public int condition;
        public int currentProgress;
        public bool isFinished;
        public AchievementTypes achievementType;
        public string achievementName;

        public void AddProgress(int progressAmount)
        {
            currentProgress = Mathf.Clamp(currentProgress + progressAmount, 0, condition);
            isFinished = currentProgress >= condition;
        }

        public void Reset()
        {
            currentProgress = 0;
            isFinished = false;
        }
    }
}
