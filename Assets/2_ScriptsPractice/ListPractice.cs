using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework.Constraints;

public class ListPractice : MonoBehaviour
{

    [ContextMenu("List실습")]
    void ShowInventory()
    {
        List<string> iv = new List<string>();
        iv.Add("포션");
        iv.Add("화살");
        iv.Add("포션");
        iv.Add("열쇠");
        iv.Remove("포션");

        Debug.Log("아이템 " +  iv.Count + "개" +
            "\n열쇠 있음 : " + iv.Contains("열쇠"));

        for (int i = 0; i < iv.Count; i++)
        {
            Debug.Log(i + "번 : " + iv[i]);
        }
    }


}
