using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{
    // config parameters
    [Range(0f, 10f)] [SerializeField] private float game_speed;

    // cached reference
    [SerializeField] TextMeshProUGUI score_text;

    // state variables
    [SerializeField] private int current_score;
    private bool is_game_paused = false;


    // Todo: autoplay is just for debugging purposes, you may have to remove it and its references;;
    [SerializeField] private bool is_autoplay_on;
    [Range(-2.4f, 2.4f)]
    [SerializeField] public float autoplay_paddle_pos_offset; //Todo: remove it when auto paly is removed;



    private void Awake()
    {
        // REVIEW: implimentation of singleten pattern
        int game_status_count = FindObjectsOfType<GameSession>().Length;
        if (game_status_count > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
            DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        score_text.text = current_score.ToString();
    }

    private void Update()
    {
        Time.timeScale = game_speed;
    }

    public void IncreaeScore(int destroy_point)
    {
        current_score += destroy_point;
        score_text.text = current_score.ToString();
    }

    public void ResetScore()
    {
        current_score = 0;
        score_text.text = current_score.ToString();
    }

    public void DestroyItsSelf() // we will need to destroy to reset score ie to reset session
    {
        Destroy(gameObject);
    }

    public bool IsAutoPlayOn()   // Todo: just for debugging purposes;
    {
        return is_autoplay_on;
    }

    public void TooglePause()
    {
        if (!is_game_paused)
        {
            game_speed = 0;
            is_game_paused = true;
        }
        else
        {
            game_speed = 1;
            is_game_paused = false;
        }
    }
}
