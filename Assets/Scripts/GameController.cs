using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// not complete
public class GameController : MonoBehaviour
{
    [SerializeField] int round = 1;

    [SerializeField] int totalDeaths = 0;
    [SerializeField] int totalCases = 0;

    //reference cases month by months of 2020
    //{ja     fe     mar      apr      may        june       july       aug        sep        oct        nov        dec       }
    //{0      20     450      520.000  1.350.000  1.950.000  3.260.000  5.000.000, 6.500.000  7.700.000  9.900.000  16.000.000}

    [SerializeField] double rate = 1.0;
    // Rate is used to calculate projected cases.
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public bool advanceRound ()
    {
        //Return true to indicate game finished
        if (round == 12)
            return true;

        round++;

        switch (round)
        {
            case 2:
                totalCases += 20*rate;
            case 3:
                totalCases += 430*rate;
            case 4:
                totalCases += 519550*rate;
            case 5:
                totalCases += 830000*rate;
            case 6:
                totalCases += 600000*rate;
            case 7:
                totalCases += 1310000*rate;
            case 8:
                totalCases += 1740000*rate;
            case 9:
                totalCases += 1500000*rate;
            case 10:
                totalCases += 1200000*rate;
            case 11:
                totalCases += 2200000*rate;
            case 12:
                totalCases += 6100000*rate;
        }
        
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
