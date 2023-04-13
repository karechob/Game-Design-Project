using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StressHandler : MonoBehaviour
{
    [SerializedField] int stress = 100;
    //This will be treated as health.

    [SerializedField] int threshold = 20;
    // If the stress levels falls below this, quick time events should be initiated.

    void Start()
    {}

    void Update()
    {}

    public void decrease (int value)
    {
        stress -= value;
    }

    /* Should we allow recovery (ex. after rounds)?
    public void recover (int value)
    {
        stress += value;
    }
    */

    public boolean isTooLow ()
    {
        return (threshold > stress);
    }

}
