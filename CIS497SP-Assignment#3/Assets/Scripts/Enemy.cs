/* 
 * John Mordi
 * Enemy.cs
 * Assignment 3
 * Holds enemy stats and makes enemy function accordingly,
 * acts as an observer
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IObserver
{
    int speed;
    int width; // positive z boundary
    float size;

    public EnemyAdjustment enemyAdjustment;

    public void UpdateData(int tSpeed, int tWidth, float tSize)
    {
        speed = tSpeed;
        width = tWidth;
        size = tSize;
        gameObject.transform.localScale = new Vector3(size, size, size);
    }

    // Start is called before the first frame update
    void Start()
    {
        enemyAdjustment.RegisterObserver(this);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (gameObject.transform.position.z > width)
        {
            gameObject.transform.Translate(new Vector3(0, 0, -2 * width));
        }
    }
}
