using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class hoverSound : MonoBehaviour,IPointerEnterHandler
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    public void OnPointerEnter(PointerEventData eventData)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
