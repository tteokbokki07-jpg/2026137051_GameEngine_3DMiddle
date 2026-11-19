using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string playerName = "123";
    public int level = 1;
    public float attack = 2;
    public bool isBoss = false;

    [ContextMenu("스탯")]
    public void ShowStat()
    {
        Debug.Log("이름 : " + playerName + "  레벨 : " + level +
            "\n공격 : " + attack + "  보스? : " + isBoss);
    }

}
