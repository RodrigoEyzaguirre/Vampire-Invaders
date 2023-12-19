using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shooter : MonoBehaviour
{
    public int maximumBullet;
    int bulletCount;
    // reference to the original prefab to instatiate
    public GameObject projectilePrefab;
    public GameObject gameOverPanel;
    public TMP_Text DaggerCount;

    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        bulletCount = maximumBullet;
    }

    // Update is called once per frame
    void Update()
    {
        DaggerCount.text = bulletCount.ToString();
        if (Input.GetButtonDown("Jump") && bulletCount > 0)
        {
            Shoot();
            bulletCount--;
        }
        if (bulletCount <= 0)
        {
            gameOverPanel.SetActive(true);
        }
    }

    void Shoot()
    {
        // We instantiate the prefab at the same position as the player,
        // since this script is on the player GameObject
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}