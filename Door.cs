using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : SoundManager
{
    private Animator anim;
    public bool isOpen;
    public bool isHasSomeSounds;
    public bool isLocked;
    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isOpen", isOpen);
    }

    public void setState()
    {
        if (!isLocked)
        {
            isOpen = !isOpen;
            anim.SetBool("isOpen", isOpen);
            transform.GetComponent<BoxCollider>().enabled = false;
            Invoke("SetBox", 0.27f);
            if (isHasSomeSounds)
            {
                if (isOpen) playSound(sounds[0], volume: 0.7f, p1: 1f, p2: 1.25f);
                else playSound(sounds[1], volume: 0.7f, p1: 1f, p2: 1.25f);
            }
            else playSound(sounds[0], volume: 0.7f, p1: 1f, p2: 1.25f);
        }
        else
        {
            PlayerInteract.Instance.messageText.text = "I cant open this";
        }
    }
    void SetBox()
    {
        transform.GetComponent<BoxCollider>().enabled = true;
    }
}
