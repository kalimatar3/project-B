using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader {
    public enum Scene 
    {
        GameScene,
        Loading,
        MainMenu,
        DeadScene,
    }

    private static Action onLoaderCallback;
    private static AsyncOperation loadingAsyncOperation;
    public static void Load(Scene scene) {
        // Set the loader callback action to load the target scene
        onLoaderCallback = () => {
            GameObject loadingGameObject = new GameObject("Loading Game Object");
            loadingGameObject.AddComponent<MyMonoBehaviour>().StartCoroutine(LoadSceneAsync(scene));
        };
        // Load the loading scene
        SceneManager.LoadScene(Scene.Loading.ToString());
    }
    private static IEnumerator LoadSceneAsync(Scene scene) 
    {
        yield return null;
        loadingAsyncOperation = SceneManager.LoadSceneAsync(scene.ToString());
        while (!loadingAsyncOperation.isDone) 
        {
            yield return null;
        }
    }
    public static void LoaderCallback()
    {
        if (onLoaderCallback != null)
        {
            onLoaderCallback();
            onLoaderCallback = null;
        }
    }
}
