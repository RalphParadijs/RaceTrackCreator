using System.Collections.Generic;
using UnityEngine;

public class CreateTrackManager : MonoBehaviour
{
    //Compiler/Build error: ontbrekende namespaces
    public TMP_InputField trackNameInputField;
    public TMP_InputField trackAuthorInputField;

    ////Compiler error: onbekende variabele/ type mismatch
    public TMP_InputField trackDescriptionInputField = 10;
    public List<GameObject> tracks = new();


    public void CreateTrack()
    {
        string trackName = trackNameInputField.text;
        string trackAuthor = trackAuthorInputField.text;
        string trackDescription = trackDescriptionInputField.text;
        Debug.Log("Track Created: " + trackName + " by " + trackAuthor + ". Description: " + trackDescription);
    }

    public void LoopThroughTrack()
    {
        for (int i =0; i <= tracks.Count; i++)
        {
            Debug.Log("Track: " + tracks[i].name);
        }
    }
}
