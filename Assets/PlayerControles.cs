using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControles : MonoBehaviour
{
    // square sprites and there positions 
    public GameObject LeftSquare;
    public GameObject RightSquare;
    public GameObject UpSquare;
    public GameObject BottomSquare;
    public GameObject CenterSquare;


    public int noteStreak = 0;
    public int multiplier = 1;
    public int Score = 10;
    public Text ScoreText;
    public Text MultiplierText;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // this section disabes colider when the square is occupied by the player.
            transform.position = LeftSquare.transform.position;
            LeftSquare.GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = RightSquare.transform.position;
            RightSquare.GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = UpSquare.transform.position;
            UpSquare.GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = BottomSquare.transform.position;
            BottomSquare.GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            // this enabels the colieders when the player is not occupiering the square.
            transform.position = CenterSquare.transform.position;
            UpSquare.GetComponent<BoxCollider2D>().enabled = true;
            BottomSquare.GetComponent<BoxCollider2D>().enabled = true;
            LeftSquare.GetComponent<BoxCollider2D>().enabled = true;
            RightSquare.GetComponent<BoxCollider2D>().enabled = true;




        } ScoreText.text = Score.ToString();
    }
    // this is the scoring system, you earn a multiplyer baced on the 
    public int ScoringSystem()
    {
        if (noteStreak == 0)
        {
            multiplier = 1;
        }
        else if (noteStreak == 1)
        {
            multiplier = 2;
        }
        else if (noteStreak == 3)
        {
            multiplier = 5;
        }
        else if (noteStreak == 4)
        {
            multiplier = 12;
        }

        MultiplierText.text = multiplier.ToString();
        return multiplier;
    }


}      
