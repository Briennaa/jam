using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SpawnTimer
{
    private static float spawnTimer = 2f;

    public static void setSpawnTimer(float st)
    {
        spawnTimer = st;
    }

    public static float getSpawnTimer()
    {
        return spawnTimer;
    }
}
