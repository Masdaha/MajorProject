using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public GameObject Player;
    
    public List<NoteScriped.NoteDirection> directions = new List<NoteScriped.NoteDirection>();
    public float tempo = 120f;
    public GameObject note;
    public List<GameObject> spawnPoints = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NextNote());
    }

    public IEnumerator NextNote()
    {

        while(directions.Count > 0)
        {
            NoteScriped.NoteDirection noteDirection = directions[0];

            if (noteDirection != NoteScriped.NoteDirection.none)
            {
                GameObject newNote = Instantiate(note);
                newNote.GetComponent<NoteScriped>().direction = noteDirection;
                newNote.transform.position = spawnPoints[(int)noteDirection].transform.position;
            }

            directions.RemoveAt(0);
            yield return new WaitForSeconds(60f / tempo);
        }       

        

    }

}