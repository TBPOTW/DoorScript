using UnityEngine;

public class Door : MonoBehaviour
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
        if (!isLocked) // Если возможно открыть дверь
        {
            isOpen = !isOpen; // Меняем состояние на противоположное
            anim.SetBool("isOpen", isOpen); // Проигрываем нужную анимацию
            transform.GetComponent<BoxCollider>().enabled = false; // отключаем BoxCollider, чтобы дверь не двигала игрока
            Invoke("SetBox", 0.27f); // Возвращаем BoxCollider спустя 0.27 секунд
            if (isOpen) // Проигрываем звук открывания
                playSound(sounds[0], volume: 0.7f, p1: 1f, p2: 1.25f);
            else // Проигрываем звук закрывания
                playSound(sounds[1], volume: 0.7f, p1: 1f, p2: 1.25f);
        } 
        // Если дверь открыть нельзя
        else
        {
            Debug.Log("It is locked!");
        }
    }
    // Функция, которая возвращает BoxCollider
    void SetBox()
    {
        transform.GetComponent<BoxCollider>().enabled = true;
    }
}
