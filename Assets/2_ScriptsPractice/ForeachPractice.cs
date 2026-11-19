using UnityEngine;

public class ForeachPractice : MonoBehaviour
{

    [ContextMenu("foreach 실습")]
    void CountAlive()
    {
        int[] monsterHps = { 0, 35, 0, 80, 12 };

        foreach (int monster in monsterHps)
        {
            
            //Debug.Log("aaa" + (monster > 0));
        }

        foreach (int monster in monsterHps)
        {
            if (monster <= 0) continue;

        }
    }
    [ContextMenu("foreach 실습 정답")]
    void CountAliveAnswer()
    {
        int[] monsterHps = { 0, 35, 0, 80, 12 };
        int aliveCount = 0;
        int hpSum = 0;

        foreach (int monster in monsterHps)
        {
            if (monster >= 0)
            {
                aliveCount++;
                hpSum += monster;
            }
        }
        Debug.Log("살아있는 몬스터 : " + aliveCount + "마리" +
            "\n남은 체력 합 : " + hpSum);
    }

}
