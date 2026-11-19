using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int expPerKill = 35000;
    public int killCount = 3;

    [ContextMenu("레벨 계산")]
    public void CalculateLevel()
    {
        int level = 1;
        int exp = 0;

        for (int i = 1; i <= killCount; i++)
        {
            exp = exp + expPerKill;
            while (exp >= level * 10000)
            {
                exp -= level * 10000;
                level++;
                Debug.Log(" 레벨업! LV " + level + " (" + i + "마리)");
            }
        }
        Debug.Log(" 최종 LV " + level + ", 경험치 " + exp + " / " + level * 10000);


        
        
        //for (int i = 1; i <= killCount; i++)
        //{
        //    exp = exp + expPerKill;
        //}
        //Debug.Log("킬카운트 " + killCount);

        //while (exp >= level * 10000)
        //{
        //    exp -= level * 10000;
        //    level++;
        //    Debug.Log(" 레벨업! LV " + level + " (" + "마리)");
        //}
        //Debug.Log(" 최종 LV " + level + ", 경험치 " + exp + " / " + level * 10000);
    }




}
