using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionRoomOne : MonoBehaviour
{

    public RoomOneControler room;
    public void Start() {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
        room = GameObject.Find("RoomOneController").GetComponent<RoomOneControler>();
    }
    public void ToggleColor() {
        if (!room.first && gameObject.tag=="spheres") {
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }

        if (room.first && !room.second && gameObject.tag == "cubes") {
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }

        if (room.second && !room.third && gameObject.tag == "cylins") {
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }

    }
}
