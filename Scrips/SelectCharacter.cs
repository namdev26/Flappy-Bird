using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCharacter : MonoBehaviour
{
    [SerializeField] private int _index;
    [SerializeField] public GameObject[] characters;
    [SerializeField] public GameObject[] charactersPrefabs;
    public static GameObject selectCharacter;

    void Start()
    {
        _index = 0;
        this.SelectBird();
    }

    public void NextButton()
    {
        if (_index < characters.Length-1) _index++;
        this.SelectBird();
    }
    public void PrevButton()
    {
        if (_index > 0) _index--;
        this.SelectBird();
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("GamePlay");
    }

    private void SelectBird()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            if (_index == i)
            {
                characters[i].SetActive(true);
                selectCharacter = charactersPrefabs[i];
            }
            else
            {
                characters[i].SetActive(false);
            }
        }
    }
}
