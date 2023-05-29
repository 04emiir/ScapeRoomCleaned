using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTwoControler : MonoBehaviour
{
    public int contador = 3;
    public GameObject player;
    public Transform newRoom;
    public GameObject roomThree;
    public AudioSource ok, completed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (contador == 0) {
            player.transform.position = newRoom.position;
            roomThree.SetActive(true);
            completed.Play();
            Destroy(gameObject);
        }
    }

    public void QuitarCuadro(string nombre) {
        foreach (var item in GameObject.FindGameObjectsWithTag(nombre)) {
            Destroy(item.gameObject);

        }
        ok.Play();
        contador--;
    }
}
