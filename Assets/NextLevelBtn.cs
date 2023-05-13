using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelBtn : MonoBehaviour
{
    private void Start() {
        var currentScene = SceneManager.GetActiveScene();
        int curretLevel = int.Parse(currentScene.name.Split("Level")[1]);
        int nextLevel = curretLevel + 1;
        var nextScene = SceneManager.GetSceneByName("Level" + nextLevel);
        if (nextScene == null)
        {
            this.gameObject.SetActive(false);
        }
    }
}
