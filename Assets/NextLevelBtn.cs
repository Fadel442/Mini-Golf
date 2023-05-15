using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelBtn : MonoBehaviour
{
    private void OnEnable() {
        // check next scene kalau tidak ada. sembunyikan button
        var currentScene = SceneManager.GetActiveScene();
        int curretLevel = int.Parse(currentScene.name.Split("Level ")[1]);
        int nextLevel = curretLevel + 1;

        var nextSceneBuildIndex = SceneUtility.GetBuildIndexByScenePath("Level " + nextLevel);
        if (nextSceneBuildIndex == -1)
        {
            this.gameObject.SetActive(false);
        }
    }

    public void Nextlvl()
    {
        var currentScene = SceneManager.GetActiveScene();
        int curretLevel = int.Parse(currentScene.name.Split("Level ")[1]);
        int nextLevel = curretLevel + 1;
        SceneManager.LoadScene("Level " + nextLevel);
    }
}
