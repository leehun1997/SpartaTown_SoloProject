using UnityEngine;

public enum StatChangeType
{
    Add,
    Multiple,
    Override
}

[System.Serializable]

public class CharacterStat
{
    public StatChangeType statsChangeType;
    [Range(0, 100)] public int maxHealth;
    [Range(0f, 20f)] public float speed;
    public AttackSo attackSo;
}
