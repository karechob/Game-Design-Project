using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// not complete
public class GameController : MonoBehaviour
{
    [SerializeField] int round = 1;
    [SerializeField] int totalCases = 0;

    //reference cases month by month
    //{ja fe  mar  apr      may        june       july       aug        sep        oct        nov        dec       }
    //{0, 20, 464, 521'632, 1'303'629, 1'935'202, 3'259'748, 5'001'075, 6'515'345, 7'733'693, 9'920'253, 16'012'396}
    [SerializeField] double rate = 1.0;
    // Rate is used to calculate projected cases.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
