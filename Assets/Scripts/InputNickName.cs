using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputNickName : MonoBehaviour
{
    [SerializeField] public GameObject _inputfield;
    [SerializeField] private PlayerName _playerName;

    public void GiveNickName()
    {
        _playerName._playerName = _inputfield.GetComponent<Text>().text;
    }
}
