using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacementManager : MonoBehaviour
{
    public GameObject objectToPlace;
    public List<GameObject> placedObjects = new();

    public void PlaceObject()
    {
        var placedObject = Instantiate(objectToPlace);
        var draggableObject = placedObject.GetComponent<Draggable>();
        draggableObject.StartDragging();

        draggableObject.trans = placedObject.transform;

    }

    public void PlaceObjectByIndex(int index)
    {
        var placedObject = Instantiate(placedObjects[index]);
        var draggableObject = placedObject.GetComponent<Draggable>();
        draggableObject.StartDragging();

        draggableObject.trans = placedObject.transform;

    }
}
