using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreateTrackManager : MonoBehaviour
{
    //Compiler/Build error: ontbrekende namespaces
    public TMP_InputField trackNameInputField;
    public TMP_InputField trackAuthorInputField;
    public List<GameObject> tracks = new();


    public void CreateTrack()
    {
        string trackName = trackNameInputField.text;
        string trackAuthor = trackAuthorInputField.text;
        Debug.Log("Track Created: " + trackName + " by " + trackAuthor );
    }

    
}
