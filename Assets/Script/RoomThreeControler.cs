using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomThreeControler : MonoBehaviour
{
    // Start is called before the first frame update
    public int vida = 10;
    public AudioSource ouch, completed;
    public GameObject items;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(vida == 0) {
            completed.Play();
            Destroy(items);
        }
            
    }

    public void PincharOjo() { 
        ouch.Play();
        vida--;
    }
}
