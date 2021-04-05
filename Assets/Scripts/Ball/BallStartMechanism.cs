using UnityEngine;

public class BallStartMechanism : MonoBehaviour
{
    // config parameters
    [SerializeField] private Vector2 start_offset_wrt_paddle;
    [SerializeField] private Vector2 initial_velocity;

    // cached reference
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform paddle1;

    // state variables
    public static bool is_game_on;

    private void Start()
    {
        is_game_on = false;
    }


    private void Update()
    {
        if (!is_game_on)
        {
            LockBallToPaddle();
            // if player tap or click mouse ,  then ball will launch;
            if (InputKeeper.PaddleTapBool()) LaunchBall();
        }
    }

    private void LockBallToPaddle()
    {
        transform.position = new Vector2(paddle1.position.x, paddle1.position.y) + start_offset_wrt_paddle;

        // rotation is kept 0 , because if not ball will start to rotate while ball is locked;
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    private void LaunchBall()
    {
        is_game_on = true;
        rb.velocity = initial_velocity;
    }
}
