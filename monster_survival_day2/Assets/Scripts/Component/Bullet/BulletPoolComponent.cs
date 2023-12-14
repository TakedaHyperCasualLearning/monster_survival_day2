using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPoolComponent
{
    private List<BulletEntity> bulletPool = new List<BulletEntity>();
    private int bulletActiveCount = 0;

    public List<BulletEntity> BulletPool { set => bulletPool = value; get => bulletPool; }
    public int BulletActiveCount { set => bulletActiveCount = value; get => bulletActiveCount; }
}
