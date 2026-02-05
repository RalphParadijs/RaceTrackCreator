using UnityEngine;

public class RaceCreatorScreenLogic : MonoBehaviour
{
    public GameObject CreateTrackManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnEnabled()
    {
        var tracks = CreateTrackManager.GetComponent<CreateTrackManager>().tracks;
        for (int i = 0; i <= tracks.Count; i++)
        {
            Debug.Log("Track: " + tracks[i].name);
        }
    }
}
