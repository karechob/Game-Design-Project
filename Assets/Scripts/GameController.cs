using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// not complete
public class GameController : MonoBehaviour
{
    [SerializeField] int round = 1;

    [SerializeField] int totalDeaths = 0;
    [SerializeField] int totalCases = 0;

    //reference cases, then deaths month by months of 2020
    //{ja     fe     mar      apr      may        june       july       aug        sep        oct        nov        dec       }
    //{0      20     450      520.000  1.350.000  1.950.000  3.260.000  5.000.000, 6.500.000  7.700.000  9.900.000  16.000.000}
    //{0      0      19       23.000   79.000     111.000    138.000    167.000    198.000    217.000    240.000    305.000   }

    [SerializeField] double caseRate = 1.0;
    [SerializeField] double deathRate = 1.0;
    // Rate is used to calculate projected cases.
    // Start is called before the first frame update

    void Start()
    {
        
    }

    public void decide (int identity)
    {
        //change rate based on identity of the decision:
        // each decision should have a unique number towards it
        // so not all decisions are treated as equal.

        /*
        switch (identity)
        {
            case specific card:
                decrease rate by 0.10;
            case another, negative decision:
                increase rate by 0.2;
        }

        something like the above
        */    
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
                totalCases += (int)(20*caseRate);
                break;
            case 3:
                totalCases += (int)(430*caseRate);
                totalDeaths += (int)(19*deathRate);
                break;
            case 4:
                totalCases += (int)(519550*caseRate);
                totalDeaths += (int)(22981*deathRate);
                break;
            case 5:
                totalCases += (int)(830000*caseRate);
                totalDeaths += (int)(56000*deathRate);
                break;
            case 6:
                totalCases += (int)(600000*caseRate);
                totalDeaths += (int)(32000*deathRate);
                break;
            case 7:
                totalCases += (int)(1310000*caseRate);
                totalDeaths += (int)(27000*deathRate);
                break;
            case 8:
                totalCases += (int)(1740000*caseRate);
                totalDeaths += (int)(29000*deathRate);
                break;
            case 9:
                totalCases += (int)(1500000*caseRate);
                totalDeaths += (int)(31000*deathRate);
                break;
            case 10:
                totalCases += (int)(1200000*caseRate);
                totalDeaths += (int)(19000*deathRate);
                break;
            case 11:
                totalCases += (int)(2200000*caseRate);
                totalCases += (int)(23000*deathRate);
                break;
            case 12:
                totalCases += (int)(6100000*caseRate);
                totalDeaths += (int)(65000*deathRate);
                break;
            default:
                break; //should NEVER reach here
        }
        
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
