using System.Collections;
using System.Collections.Generic;
using Achievements;
using UnityEngine;

public class ClassSelection : MonoBehaviour
{
    [SerializeField] private GameObject singleClass;
    [SerializeField] private GameObject dualClass;
    [SerializeField] private GameObject tripleClass;
    [SerializeField] private Transform spawnPoint;

    public void SpawnSingleClass()
    {
        Instantiate(singleClass, spawnPoint.position, spawnPoint.rotation);
        AchievementsManager.Instance.SetupAchievementUI();
    }

    public void SpawnDualClass()
    {
        Instantiate(dualClass, spawnPoint.position, spawnPoint.rotation);
        AchievementsManager.Instance.SetupAchievementUI();
    }

    public void SpawnTripleClass()
    {
        Instantiate(tripleClass, spawnPoint.position, spawnPoint.rotation);
        AchievementsManager.Instance.SetupAchievementUI();
    }
}
