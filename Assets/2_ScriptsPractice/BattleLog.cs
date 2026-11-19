using UnityEngine;
using System.Collections.Generic;

public class BattleLog : MonoBehaviour
{
    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
    public int critialLine = 3000;

    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
        List<int> crit = new List<int>();

        int totalDmg = 0;
        foreach (int i in damages)
        {
            if (i >= critialLine)
            {
                crit.Add(i);
            }
            totalDmg += i;
        }
        //foreach (int i in damages)
        //{
        //    totalDmg += i;
        //}
        Debug.Log("총 데미지 : " + totalDmg +
            "\n치명타 : " + crit.Count + "회");
        for (int i = 0; i < crit.Count; i++)
        {
            Debug.Log("치명타 " + crit[i]);
        }
    }

}
