using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;


    [Header("Progress")]
    public bool gateADetsroyed, gateBdestroyed, gateCdestroyed;
    public float timerA, timerB, timerC;

    [Header("References")]
    public BackgroundScroll scroll;
    public Player player;
    public GameObject gateA, gateB, gateC;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
