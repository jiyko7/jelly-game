using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] JellySpriteList;
    public string[] JellyNameList;
    public int[] JellyJelatinList;
    public int[] JellyGoldList;
    public int[] NumGoldList;
    public int[] ClickGoldList;

    public Vector3[] PointList;

    public RuntimeAnimatorController[] LevelAc;

    public void ChangeAc(Animator anim, int level)
    {
        anim.runtimeAnimatorController = LevelAc[level - 1];
    }
}
