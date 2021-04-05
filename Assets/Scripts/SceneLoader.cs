using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public static void LoadNextScene()
    {
        int current_scene_index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(current_scene_index + 1);
    }

    public static void LoadStartScene()
    {
        if (FindObjectOfType<GameSession>())
            FindObjectOfType<GameSession>().DestroyItsSelf();
        SceneManager.LoadScene(SceneName.START_SCENE);
    }

    public static void LoadOverScene()
    {
        SceneManager.LoadScene(SceneName.OVER_SCENE);
    }

    public static void ExitGame()
    {
        Application.Quit();
    }

    public static void LoadLevelsScene()
    {
        SceneManager.LoadScene(SceneName.LEVELS_SCENE);
    }

    public static void LoadControlsScene()
    {
        SceneManager.LoadScene(SceneName.CONTROLS_SCENE);
    }

    public static void LoadLevel1() => SceneManager.LoadScene(SceneName.LEVEL_1);
    public static void LoadLevel2() => SceneManager.LoadScene(SceneName.LEVEL_2);
    public static void LoadLevel3() => SceneManager.LoadScene(SceneName.LEVEL_3);
    public static void LoadLevel4() => SceneManager.LoadScene(SceneName.LEVEL_4);
    public static void LoadLevel5() => SceneManager.LoadScene(SceneName.LEVEL_5);
    public static void LoadLevel6() => SceneManager.LoadScene(SceneName.LEVEL_6);
    public static void LoadLevel7() => SceneManager.LoadScene(SceneName.LEVEL_7);
    public static void LoadLevel8() => SceneManager.LoadScene(SceneName.LEVEL_8);
    public static void LoadLevel9() => SceneManager.LoadScene(SceneName.LEVEL_9);

    public static void LoadLevel10() => SceneManager.LoadScene(SceneName.LEVEL_10);
    public static void LoadLevel11() => SceneManager.LoadScene(SceneName.LEVEL_11);
    public static void LoadLevel12() => SceneManager.LoadScene(SceneName.LEVEL_12);
    public static void LoadLevel13() => SceneManager.LoadScene(SceneName.LEVEL_13);
    public static void LoadLevel14() => SceneManager.LoadScene(SceneName.LEVEL_14);
    public static void LoadLevel15() => SceneManager.LoadScene(SceneName.LEVEL_15);
    public static void LoadLevel16() => SceneManager.LoadScene(SceneName.LEVEL_16);
    public static void LoadLevel17() => SceneManager.LoadScene(SceneName.LEVEL_17);
    public static void LoadLevel18() => SceneManager.LoadScene(SceneName.LEVEL_18);
    public static void LoadLevel19() => SceneManager.LoadScene(SceneName.LEVEL_19);

    public static void LoadLevel20() => SceneManager.LoadScene(SceneName.LEVEL_20);
    public static void LoadLevel21() => SceneManager.LoadScene(SceneName.LEVEL_21);
    public static void LoadLevel22() => SceneManager.LoadScene(SceneName.LEVEL_22);
    public static void LoadLevel23() => SceneManager.LoadScene(SceneName.LEVEL_23);
    public static void LoadLevel24() => SceneManager.LoadScene(SceneName.LEVEL_24);
    public static void LoadLevel25() => SceneManager.LoadScene(SceneName.LEVEL_25);
    public static void LoadLevel26() => SceneManager.LoadScene(SceneName.LEVEL_26);
    public static void LoadLevel27() => SceneManager.LoadScene(SceneName.LEVEL_27);
    public static void LoadLevel28() => SceneManager.LoadScene(SceneName.LEVEL_28);
    public static void LoadLevel29() => SceneManager.LoadScene(SceneName.LEVEL_29);

    public static void LoadLevel30() => SceneManager.LoadScene(SceneName.LEVEL_30);
    public static void LoadLevel31() => SceneManager.LoadScene(SceneName.LEVEL_31);
    public static void LoadLevel32() => SceneManager.LoadScene(SceneName.LEVEL_32);
    public static void LoadLevel33() => SceneManager.LoadScene(SceneName.LEVEL_33);
    public static void LoadLevel34() => SceneManager.LoadScene(SceneName.LEVEL_34);
    public static void LoadLevel35() => SceneManager.LoadScene(SceneName.LEVEL_35);
    public static void LoadLevel36() => SceneManager.LoadScene(SceneName.LEVEL_36);
    public static void LoadLevel37() => SceneManager.LoadScene(SceneName.LEVEL_37);
    public static void LoadLevel38() => SceneManager.LoadScene(SceneName.LEVEL_38);
    public static void LoadLevel39() => SceneManager.LoadScene(SceneName.LEVEL_39);

}
