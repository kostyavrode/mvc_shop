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
    }

    private void StartGame()
    {
        coroutines.StartCoroutine(LoadAndStartMainMenu());
    }

    private GameEntryPoint()
    {
        coroutines = new GameObject(name:"[COROUTINES]").AddComponent<Coroutines>();
        Object.DontDestroyOnLoad(coroutines);

        var prefabUIRoot = Resources.Load("UIRoot");
        uiRoot= Object.Instantiate(prefabUIRoot) as UIRootView;
        Object.DontDestroyOnLoad(uiRoot);
    }

    private IEnumerator LoadAndStartMainMenu()
    {
        uiRoot.SetLoadingScreenEnabledState(true);
        //cachedSceneContainer?.Dispose();

        yield return LoadScene("BOOT");
        yield return LoadScene("MAINMENU");

        yield return new WaitForEndOfFrame();

        //var sceneEntryPoint = Object.FindObjectOfType<MainMenuEntryPoint>();
        //var mainMenuContainer = cachedSceneContainer = new DIContainer(rootContainer);

        //sceneEntryPoint.Run(mainMenuContainer, mainMenuEntryParams).Subscribe(mainMenuExitParams =>


        uiRoot.SetLoadingScreenEnabledState(false);
    }

    private IEnumerator LoadScene(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName);
    }
}
