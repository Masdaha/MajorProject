using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScriped : MonoBehaviour
{
    public string direction = "up";
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == "down")
        {
            transform.Translate(Vector2.down * Time.deltaTime);
        }
        else if (direction == "left")
        {
            transform.Translate(Vector2.left * Time.deltaTime);
        }
        else if (direction== "right")
        {
            transform.Translate(Vector2.right * Time.deltaTime);
        }
        else if (direction == "up")
        {
            transform.Translate(Vector2.up * Time.deltaTime);
        }

    }
}
