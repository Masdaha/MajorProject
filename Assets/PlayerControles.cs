using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControles : MonoBehaviour
{
    // square sprites and there positions 
    public GameObject LeftSquare;
    public GameObject RightSquare;
    public GameObject UpSquare;
    public GameObject BottomSquare;
    public GameObject CenterSquare;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = LeftSquare.transform.position;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = RightSquare.transform.position;
        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = UpSquare.transform.position;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = BottomSquare.transform.position;
        }
        else
        {
            transform.position = CenterSquare.transform.position;
        }
    }
}