using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    private int _index;
    [SerializeField] public GameObject[] characters;

    void Start()
    {
        _index = 0;
        this.SelectBird();
    }

    public void NextButton()
    {
        if (_index < characters.Length - 1) _index++;
        this.SelectBird();
    }
    public void PrevButton()
    {
        if (_index > 0) _index--;
        this.SelectBird();
    }

    private void SelectBird()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            if (_index == i)
            {
                characters[i].SetActive(true);
            }
            else
            {
                characters[i].SetActive(false);
            }
        }
    }
}
