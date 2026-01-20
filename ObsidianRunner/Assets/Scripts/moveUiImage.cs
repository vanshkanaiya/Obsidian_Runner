using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUiImage : MonoBehaviour
{
    public RectTransform uiTitle;
    public RectTransform uiButton;
    public Vector3 imagePos;
    public Vector3 imagePos2;
    [SerializeField] float time = 2.5f;
    void Start()
    {
        moveItem(uiTitle);
        moveButton(uiButton);
    }

    public void moveItem(RectTransform item)
    {
        LeanTween.move(
            item,imagePos,time
        ).setEaseInOutBack();
        
    }

    public void moveButton(RectTransform item) {
        LeanTween.move(
            item, imagePos2, time
        ).setEaseInOutBack();
    }
}
