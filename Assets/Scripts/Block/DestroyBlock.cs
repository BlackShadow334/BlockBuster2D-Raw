using System;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{

    // config parameters
    [SerializeField] private AudioClip[] broke_audio_clip;
    [SerializeField] private GameObject sparkle_VFX;
    [SerializeField] private Sprite[] cracked_sprites;
    [SerializeField] private int destroy_point;

    // cached reference
    private AudioSource audio_source;
    private GameSession game_status;


    // state variables
    private int audio_clips_length;
    private int max_hit;
    [SerializeField] private int times_hit; // TODO: serialized is just for debug purposes, remove it;


    private void Start()
    {
        max_hit = cracked_sprites.Length + 1;

        LevelControl.AddMeToBreakable();

        audio_source = GetComponent<AudioSource>();
        audio_clips_length = broke_audio_clip.Length;

        game_status = FindObjectOfType<GameSession>();
    } // start

    private void OnCollisionEnter2D(Collision2D other)
    {
        times_hit += 1;
        if (times_hit >= max_hit)
        {
            HandleHit();
        }
        else
        {
            ShowNextHitSprite();
        }
    }

    private void ShowNextHitSprite()
    {
        int cracked_sprites_index = times_hit - 1;
        try
        {
            GetComponent<SpriteRenderer>().sprite = cracked_sprites[cracked_sprites_index];
        }
        catch (IndexOutOfRangeException)
        {
            Debug.LogError("Block Sprite is missing from array : " + gameObject.name);
        }
    }

    private void HandleHit()
    {
        TriggerSparkleVFX();
        PlayBlockDestroySFX();

        game_status.IncreaeScore(destroy_point);
        LevelControl.RemoveMeFromBreakable();
        Destroy(gameObject, 0.1f);
    }

    private void PlayBlockDestroySFX()
    {
        int random_clip_index = UnityEngine.Random.Range(0, audio_clips_length);
        AudioSource.PlayClipAtPoint(broke_audio_clip[random_clip_index], Camera.main.transform.position);
    }

    private void TriggerSparkleVFX()
    {
        GameObject sparkles = Instantiate(sparkle_VFX, transform.position, transform.rotation);
        Destroy(sparkles, 1f);
    }
}