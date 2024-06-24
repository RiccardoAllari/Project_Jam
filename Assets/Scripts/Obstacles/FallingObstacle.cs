using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObstacle : Obstacle
{
    [SerializeField]
    private List<Projectile> projectiles = new List<Projectile>();
    private float currentTime;
    protected override void Effect()
    {
        projectiles[0].gameObject.SetActive(true);
        projectiles.Remove(projectiles[0]);
    }
    private void Start()
    {
        currentTime = 0;
    }
    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= fireRate)
        {
            currentTime = 0;
            Effect();
        }
    }
}
