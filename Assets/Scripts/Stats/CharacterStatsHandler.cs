using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStatsHandler : MonoBehaviour
{
    [SerializeField] private CharacterStat baseStat;
    PlayerDataManger playerDataManger;
    public Text playerName;

    public CharacterStat CurrentStat { get; private set; }

    public List<CharacterStat> statModifiers = new List<CharacterStat>();

    private void Awake()
    {
        playerDataManger = GameObject.Find("PlayerDataManger").GetComponent<PlayerDataManger>();
        UpdateCharacterStat();
    }

    private void UpdateCharacterStat()
    {
        playerName.text = playerDataManger.GetName();
        AttackSo attackSo = null;
        if(baseStat.attackSo != null)
        {
            attackSo = Instantiate(baseStat.attackSo);//값은 같지만 서로다른 2개
        }

        CurrentStat = new CharacterStat { attackSo = attackSo };
        CurrentStat.statsChangeType = baseStat.statsChangeType;
        CurrentStat.maxHealth= baseStat.maxHealth;
        CurrentStat.speed = baseStat.speed;
    }
}
