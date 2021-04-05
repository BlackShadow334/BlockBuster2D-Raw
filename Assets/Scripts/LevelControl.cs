using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class LevelControl : MonoBehaviour
{

    // cached reference
    [SerializeField] private TextMeshProUGUI level_text;

    // state variables
    private static int number_of_breakable_blocks;

    private void Start()
    {
        Destroy(level_text, 2f);
    }


    public static void AddMeToBreakable()
    {
        number_of_breakable_blocks += 1;
    }

    public static void RemoveMeFromBreakable() // Note: it removes count of block (who calls it);
    {
        number_of_breakable_blocks -= 1;

        if (number_of_breakable_blocks <= 0)
        {
            SceneLoader.LoadNextScene();
            BallStartMechanism.is_game_on = false;
        }
    }

    public static void SetNumberOfBreakableBlocks(int num)
    {
        number_of_breakable_blocks = num;
    }

    private void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            FindObjectOfType<GameSession>().TooglePause();
        }

    }


}
