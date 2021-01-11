using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationEvents : MonoBehaviour
{
    Sprite nextSprite;
    public Image image;
    public AudioSource pageTurnSound;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void SetNextSprite(Sprite newSprite)
    {
        nextSprite = newSprite;
        animator.SetTrigger("Swap");
        pageTurnSound.Play();
    }

    public void SwapSprite()
    {
        image.sprite = nextSprite;
    }
}
