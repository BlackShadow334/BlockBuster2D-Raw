using UnityEngine;

public class BallCollision : MonoBehaviour
{
    // config parameters
    [SerializeField] private AudioClip paddle_audio_clip;
    [SerializeField] private AudioClip wall_audio_clip;
    [SerializeField] private AudioClip breakable_block_audio_clip;
    [SerializeField] private AudioClip unbreakble_block_audio_clip;
    [SerializeField] private float random_angle_velocity_factor;
    // [SerializeField] private Vector2 min_ball_velocity; // NOTE: this is for testing in order to remove a bug;

    // cached reference
    private Rigidbody2D rb;
    private AudioSource audio_source;

    // state variables


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        audio_source = GetComponent<AudioSource>();
    }


    private void Update()
    {
        ManageVelocityIfMuchLess();
    }

    private void ManageVelocityIfMuchLess() // FIXME: Ball somethime goes very slow , and somethime it stops
    {   // solution for bug that cause, ball to stop in air and things like that
        // if (Mathf.Abs(rb.velocity.x) < min_ball_velocity.x)
        // {
        //     if (rb.velocity.x >= 0)
        //         rb.velocity = new Vector2(min_ball_velocity.x, rb.velocity.y);
        //     else
        //         rb.velocity = new Vector2(min_ball_velocity.x * -1, rb.velocity.y);
        // }
        // if (Mathf.Abs(rb.velocity.y) < min_ball_velocity.y)
        // {
        //     if (rb.velocity.x >= 0)
        //         rb.velocity = new Vector2(min_ball_velocity.y, rb.velocity.y);
        //     else
        //         rb.velocity = new Vector2(min_ball_velocity.y * -1, rb.velocity.y);
        // }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        PlayAudioClip(other);
        AddSomeRandomVelocity();
    }

    private void AddSomeRandomVelocity() //Note: not currently in use (its set to 0), due to introduction of magnetic effect;
    {
        Vector2 velocity_tweak = new Vector2(
            Random.Range(0f, random_angle_velocity_factor),
            Random.Range(0f, random_angle_velocity_factor));

        rb.velocity += velocity_tweak;
    }

    private void PlayAudioClip(Collision2D other)
    {
        // AudioClip audio = audio_clips[Random.Range(0, audio_clip_length)];
        // audio_source.PlayOneShot(audio);

        if (other.gameObject.tag == Tags.BREAKABLE_TAG)
        {
            audio_source.PlayOneShot(breakable_block_audio_clip);
        }
        if (other.gameObject.tag == Tags.UNBREAKABLE_TAG)
        {
            audio_source.PlayOneShot(unbreakble_block_audio_clip);
        }
        if (other.gameObject.tag == Tags.PADDLE_TAG)
        {
            audio_source.PlayOneShot(paddle_audio_clip);
        }
        if (other.gameObject.tag == Tags.WALL_TAG)
        {
            audio_source.PlayOneShot(wall_audio_clip);
        }
    }
}