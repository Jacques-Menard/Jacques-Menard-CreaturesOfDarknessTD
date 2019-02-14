﻿using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Gold;
    public int startGold = 200;

    public static int Lives;
    public int startLives = 5;

    public static int Waves;

    private void Start()
    {
        Gold = startGold;
        Lives = startLives;
        Waves = 0;
    }

    public static void TakeLives(int damage)
    {
        if (Lives - damage > 0)
        {
            Lives -= damage;
        }else
        {
            Lives = 0;
        }

    }
}
