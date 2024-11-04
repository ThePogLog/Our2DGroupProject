using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.Tilemaps;

public class EnemyKillCount : MonoBehaviour
{
    public TMP_Text KillCount; // Use TMP_Text for TextMeshPro
    private int killCount = 0;
    public Tilemap fakewall;
    public Tilemap Walloff;

    void Start()
    {
        UpdateKillCountText();
    }

    public void EnemyDestroyed()
    {
        killCount += 1;
        Debug.Log("Enemy destroyed. Current kill count: " + killCount); 
        UpdateKillCountText();
        PlatformDestroy();
    }

    void UpdateKillCountText()
    {
        KillCount.text = killCount.ToString();
    }

    public void PlatformDestroy()
    {
        if (killCount == 15)
        {
            KillCount.color = Color.green;
            Destroy(fakewall.gameObject);
            Destroy(Walloff.gameObject);
        }
    }
}

public class Enemy : MonoBehaviour
{
    public EnemyKillCount killCountScript;

    void Start()
    {
        if (killCountScript == null)
        {
            killCountScript = FindObjectOfType<EnemyKillCount>();
        }
    }

    void OnDestroy()
    {
        if (killCountScript != null)
        {
            killCountScript.EnemyDestroyed();
        }
    }
}
