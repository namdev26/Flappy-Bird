using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Init : MonoBehaviour
{
    void Start()
    {
        GameObject selectCharacter = SelectCharacter.selectCharacter;
        GameObject palyer = Instantiate(selectCharacter, transform.position, Quaternion.identity);
    }
}
