using System;
using System.Collections.Generic;
using Achievements.Data;
using Achievements.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Achievements
{
    public class AchievementsManager : MonoBehaviour
    {
        #region Singleton
        private static AchievementsManager _instance;
        
        public static AchievementsManager Instance => _instance;


        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(this.gameObject);
            } else {
                _instance = this;
            }
        }
        

        #endregion

        [SerializeField]private List<AchievementData> achievements;
        private List<AchievementListItem> _achievementListItems;

        #region UI Component

        [SerializeField] private VerticalLayoutGroup achievementLayoutGroup;
        [SerializeField] private GameObject achievementPanel;
        [SerializeField] private GameObject achievementContent;
        [SerializeField] private GameObject achievementListItemPrefab;

        #endregion

        public void UpdateAchievements(AchievementTypes type, int progressAmount)
        {
            foreach (var achievement in achievements)
            {
                if (achievement.achievementType == type)
                {
                    achievement.AddProgress(progressAmount);
                }
            }
        }

        private void ResetAchievements()
        {
            foreach (var achievement in achievements)
            {
                achievement.Reset();
            }
        }
        

        private void Start()
        {
            ResetAchievements();
            _achievementListItems = new List<AchievementListItem>();
        }

        private void Update()
        {
            UpdateAchievementUI();
        }

        private void UpdateAchievementUI()
        {
            for (var i = 0; i < _achievementListItems.Count; i++)
            {
                var achievement = achievements[i];
                var achivementListItem = _achievementListItems[i];
                achivementListItem.UpdateAchievementText(achievement);
            }
        }

        public void SetupAchievementUI()
        {
        Debug.Log("achieve");
            foreach (var achievement in achievements)
            {
                var achievementListItem = Instantiate(achievementListItemPrefab, achievementContent.transform);
                var achievementListItemScript = achievementListItem.GetComponent<AchievementListItem>();
                _achievementListItems.Add(achievementListItemScript);
                achievementListItemScript.UpdateAchievementText(achievement);
            }
        }
    }
}