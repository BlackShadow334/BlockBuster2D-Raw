using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    // config parameters
    [SerializeField] float paddle_speed;
    [SerializeField] float min_x_clamp, max_y_clamp;


    // cached referance
    private BallCollision ball; //  note: for debugging purposes;
    private GameSession game_session; // Todo: for accesing it for autoplay, so remove it when no use of auto play here;


    private void Start()
    {
        ball = FindObjectOfType<BallCollision>();
        game_session = FindObjectOfType<GameSession>();
    }

    private void Update()
    {
        Move();
    }


    private void Move()
    {
        float move_dir_x = InputKeeper.PaddleMoveReadvalueVector2().x;

        /* HACK:
         * if below [if] block is uncommented and autoplay is on, it will give effect that,
         * (when ever user move their mouse, paddle position will automatically move to required position),
         * player seems to be moving his mouse but paddle position will be at place because of autoplay,
         * paddle will not move if mouse is not moved;
         * this will work only when autoplay is on and also keep in mind of autoplay_paddle_pos_offset;
         */
        // Todo: this if block is commented to allow paddle to move , while autoplay is on, so, uncomment it when autoplay is removed.
        // if (Mathf.Abs(move_dir_x) >= 0.1f)
        // {
        move_dir_x *= paddle_speed * Time.deltaTime;
        float new_pos = move_dir_x + transform.position.x;

        if (!game_session.IsAutoPlayOn()) // NOTE:  Autoplay is for debugging purposes;
            new_pos = Mathf.Clamp(new_pos, min_x_clamp, max_y_clamp);
        else
            new_pos = Mathf.Clamp(GetAutoPosition(), min_x_clamp, max_y_clamp);

        transform.position = new Vector2(new_pos, transform.position.y);
        // }
    } // move

    private float GetAutoPosition() // NOTE:  for debuging...
    {
        return ball.transform.position.x - game_session.autoplay_paddle_pos_offset;
    }
}
