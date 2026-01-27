using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeAnimation : MonoBehaviour
{
    void Start()
    {
        LeanTween.init();
    }

    void Update()
    {
        spikeAnimations();
    }

    public void spikeAnimations()
    {
        //LeanTween.move(gameObject,Vector2.down,2);
    }
}
