using UnityEngine;
using System.Collections;

public class pauseGamne : MonoBehaviour {

    public void OnClick()
    {
        GameController.Instance.Pause();
    }
}
