using UnityEngine;
using System.Collections;

public class WinVolume : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            Debug.Log("Trigger is hit!");
            GameController.Instance.WinGame();
    }
}
