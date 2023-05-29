using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomOneControler : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform[] spheres, cubes, cylins;
    public bool first, second, third = false;
    public int sphereCount, cubeCount, cylinCount;
    public GameObject player;
    public Transform newRoom;
    public GameObject roomTwo;
    public GameObject posesRoomTwo;

    public AudioSource ok, completed;
    // Update is called once per frame
    private void Start() {
        sphereCount = spheres.Length;
        cubeCount = cubes.Length;
        cylinCount = cylins.Length;
    }
    void Update()
    {
        if (!first) {
            int cont = 0;
            foreach (var item in spheres) {
                Color current = item.gameObject.GetComponent<Renderer>().material.color;
                if (current == Color.red) {
                    cont++;
                } else {
                    break;
                }
            }
            if (cont == sphereCount) {
                first = true;
                ok.Play();
                foreach (var item in spheres) {
                    Destroy(item.gameObject);
                }
            }
        }

        if (!second && first) {
            int cont = 0;
            foreach (var item in cubes) {
                Color current = item.gameObject.GetComponent<Renderer>().material.color;
                if (current == Color.red) {
                    cont++;
                } else {
                    break;
                }
            }

             if (cont == cubeCount) {
                second = true;
                ok.Play();
                foreach (var item in cubes) {
                    Destroy(item.gameObject);
                }
             }
            
        }

        if (!third && second) {
            int cont = 0;
            foreach (var item in cylins) {
                Color current = item.gameObject.GetComponent<Renderer>().material.color;
                if (current == Color.red) {
                    cont++;
                } else {
                    break;
                }
            }

            if (cont == cylinCount) {
                third = true;
                ok.Play();
                foreach (var item in cylins) {
                    Destroy(item.gameObject);
                }
            }
        }

        if (third) {
            player.transform.position = newRoom.position;
            roomTwo.SetActive(true);
            posesRoomTwo.SetActive(true);
            completed.Play();
            Destroy(gameObject);
        }
    }
}
