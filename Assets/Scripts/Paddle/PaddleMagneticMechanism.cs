using UnityEngine;

public class PaddleMagneticMechanism : MonoBehaviour
{
    // config parameters
    [SerializeField] private float magnetic_power;

    // cahed reference
    [SerializeField] private Transform ball_transform;
    [SerializeField] private Rigidbody2D ball_rb;

    // state variables


    private void Update()
    {
        if (InputKeeper.PaddleTapBool())
        {
            Vector2 ball_current_pos = ball_transform.position;
            Vector2 paddle_current_pos = new Vector2(transform.position.x, transform.position.y + 0.1f);

            Vector2 ball_magnetic_velocity = ball_current_pos - paddle_current_pos;

            ball_rb.velocity -= ball_magnetic_velocity * Time.deltaTime;
        }
    }

}
