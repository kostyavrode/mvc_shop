using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEntryPoint
{
    private static GameEntryPoint instance;

    private Coroutines coroutines;
    private UIRootView uiRoot;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void AutoStart()
    {
        Application.targetFrameRate = 60;
        instance=new GameEntryPoint();
        instance.StartGame();
    }

    private void StartGame()
    {
        coroutines.StartCoroutine(LoadAndStartMainMenu());
    }

    private GameEntryPoint()
    {
        coroutines = new GameObject(name:"[COROUTINES]").AddComponent<Coroutines>();
        Object.DontDestroyOnLoad(coroutines);

        var prefabUIRoot = Resources.Load<UIRootView>("UIRoot");
        uiRoot= Object.Instantiate(prefabUIRoot) as UIRootView;
        Object.DontDestroyOnLoad(uiRoot.gameObject);
    }

    private IEnumerator LoadAndStartMainMenu()
    {
        uiRoot.SetLoadingScreenEnabledState(true);

        yield return LoadScene("BOOT");
        yield return LoadScene("MAINMENU");
        yield return new WaitForEndOfFrame();

        uiRoot.SetLoadingScreenEnabledState(false);
        var sceneEntryPoint = Object.FindObjectOfType<MainMenuEntryPoint>();
        sceneEntryPoint.StartScene();
    }

    private IEnumerator LoadScene(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName);
    }
}
