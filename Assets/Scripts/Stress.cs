using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stress : MonoBehaviour
{
    [SerializeField] int stress = 100;

    [SerializeField] int threshold = 40;
    // If stress falls below threshold, quick time events will be triggered.

    [SerializeField] int DECREASE_RATE = 3;
    [SerializeField] int acceleration = 1;
    // Stressful after stressful action will hurt the player faster.

    // Start is called before the first frame update
    void Start()
    {}

    // Update is called once per frame
    void Update()
    {}

    public void decrease ()
    {
        stress -= (DECREASE_RATE*acceleration);
        acceleration++;
    }

    public void resetAcceleration ()
    {
        acceleration = 1;
    }

    public bool isTooLow ()
    {
        return (threshold > stress);
    }
}
