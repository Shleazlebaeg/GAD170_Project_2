using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crewmate : MonoBehaviour
{
    public string crewmateName;
    public string crewmateColour;
    public string crewmateJob;
    public string crewmateHobby;

    public List<int> crewmateVariable = new List<int>();

    public int Imposter;

    // Start is called before the first frame update
    void Start()
    {//Adds 10 elements to the crewmateVariable list
        crewmateVariable.Add(1);
        crewmateVariable.Add(2);
        crewmateVariable.Add(3);
        crewmateVariable.Add(4);
        crewmateVariable.Add(5);
        crewmateVariable.Add(6);
        crewmateVariable.Add(7);
        crewmateVariable.Add(8);
        crewmateVariable.Add(9);
        crewmateVariable.Add(10);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Crewmates()
    {
        
    }
}
