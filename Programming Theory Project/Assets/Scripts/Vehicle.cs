using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    private const int defaultNoOfDoors = 4;

    public int YearMake { get; private set; }
    public int NoOfDoors { get; set; }
    public bool Registerd { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        NoOfDoors = defaultNoOfDoors;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BlinkLeftSignal()
    {
        // TODO blink left signal
    }

    public void BlickLeftSignal(bool includeSideMirror)
    {
        BlinkLeftSignal();

        if (includeSideMirror == true)
        {
            // TODO blink left side mirror signal
        }
    }

    public void BlinkRightSignal()
    {
        // TODO blick right signal
    }

    public void BlinkRightSignal(bool includeSideMirror)
    {
        BlinkRightSignal();

        if (includeSideMirror == true)
        {
            // TODO blink right side mirror signal
        }
    }
}
