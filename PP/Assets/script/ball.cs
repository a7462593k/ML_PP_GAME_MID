using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    ///<summary>
    ///足球是否進入球門
    ///</summary>
    public static bool complete;

    ///<summary>
    ///觸發開始事件 : 碰到勾選 Is Trigger 物件會執行一次
    ///</summary>
    ///<param name="other">碰到的物件碰撞資訊</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "球拍")
        {
            complete = true;
        }
    }
}
