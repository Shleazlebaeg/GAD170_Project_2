using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrewmateManager : MonoBehaviour
{
    public Crewmate crewmate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            crewmate.Crewmates();
        }
    }
}
