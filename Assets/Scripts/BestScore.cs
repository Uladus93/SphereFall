using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_TextMeshPro;
    void Start()
    {
        m_TextMeshPro.text = $"BEST SCORE: {TopList.Instance.YourNickName} - {TopList.Instance.YourScore}";
    }
}
