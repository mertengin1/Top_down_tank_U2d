using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int enemyCount;

    void Start()
    {
        // Başlangıçta tüm düşmanları say
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        Debug.Log("Enemy count: " + enemyCount);
    }

    public void EnemyKilled()
    {
        // Bir düşman öldürüldüğünde sayıyı azalt
        enemyCount--;

        // Tüm düşmanlar öldüğünde bir sonraki seviyeye geç
        if (enemyCount <= 0)
        {
            NextLevel();
        }
    }

    void NextLevel()
    {
        // Bir sonraki sahneyi yükle
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
