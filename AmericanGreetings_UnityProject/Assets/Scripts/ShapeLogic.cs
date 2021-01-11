using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShapeLogic : MonoBehaviour, IPointerDownHandler
{
    public AudioSource colorChangeSound;
    public Image colorChangeImage;
    float lastClickTime = -999;
    float doubleClickTime = .5f;
    Image image;

    void Start()
    {
        image = GetComponent<Image>();
        image.alphaHitTestMinimumThreshold = .5f;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(Time.time - lastClickTime < doubleClickTime)
        {
            lastClickTime = -999;
            Color newColor = new Color(
                Random.Range(0f, 1f), 
                Random.Range(0f, 1f), 
                Random.Range(0f, 1f)
            );
            colorChangeImage.color = newColor;
            colorChangeSound.Play();
        }
        else
        {
            lastClickTime = Time.time;
        }
    }
}