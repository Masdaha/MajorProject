using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScriped : MonoBehaviour
{
    public enum NoteDirection
    {
        up,
        down,
        left,
        right,
        none
    }

    public float speed = 2f;
    public PlayerControles player;
    public NoteDirection direction;
    private void Start()
    {
        // finds the unity player and puts it into a global shearch
        player = GameObject.Find("Player").GetComponent<PlayerControles>();
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == NoteDirection.down)
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
        else if (direction == NoteDirection.left)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);

        }
        else if (direction== NoteDirection.right)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);

        }
        else if (direction == NoteDirection.up)
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);

        }
    }
    //note scriped collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Get access to player controller
           
            player.noteStreak += 1;
            // Increase score
            player.Score += player.ScoringSystem();
            print("Player");

            // Finally, destroy note
            Destroy(gameObject);
        }// destroys the note
        else if (collision.CompareTag("HitBox"))
        {
            // Finally, destroy note

            Destroy(gameObject);
            player.noteStreak =0;
            print("HitBox");
        }
    }

    
}
