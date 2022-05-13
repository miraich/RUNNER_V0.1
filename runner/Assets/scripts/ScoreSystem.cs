using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        
        GameManager.inst.IncrementScore();

    }

}
