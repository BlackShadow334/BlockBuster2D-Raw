using UnityEngine;

public class LooseBoundryDetect : MonoBehaviour
{

    // if ball hits lower boundry (wall) which is a trigger for this event
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneLoader.LoadOverScene();

        // number_of_breakable_blocks is set to 0,  in case plyer loses ie cannot destroy all blocks
        LevelControl.SetNumberOfBreakableBlocks(0);
        BallStartMechanism.is_game_on = false;

        FindObjectOfType<GameSession>().ResetScore();
    }
}
