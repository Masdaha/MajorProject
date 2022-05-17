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

    public float speed = 100f;

    public NoteDirection direction;


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
}
