using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;
    public float expRate = 1.5f;

    [ContextMenu("정산")]
    public void Settle()
    {
        int hour = playSeconds / 60 / 60;
        int min = (playSeconds / 60) % 60; //문제의 구간
        int sec = playSeconds % 60;
        Debug.Log("플레이타임 : " + playSeconds + "초" +
            "\n플레이타임 : " + hour + ":" + min + ":" + sec);
        Debug.Log("플레이타임 : " + hour + ":" +
            (min / 10) + (min % 10) + ":" + (sec / 10) + (sec % 10));

        int pg = gold / members;
        int lg = gold % members;
        Debug.Log("인당 " + pg + "G, 리더 보너스 " + lg);

        int xp = kills * expPerKill;
        float xpr = xp * expRate;
        int lxp = (int)xpr;  //소수점버림경험치
        //Debug.Log("경험치 " + lxp + "(기본 " + xp + ")");

        int lv = lxp / 100 + 1;
        int lvp = 100 - (lxp % 100);
        //Debug.Log("LV " + lv + ", 다음 레벨까지 " + lvp);
        
        Debug.Log("경험치 " + lxp + "(기본 " + xp + ")"
            + "\nLV " + lv + ", 다음 레벨까지 " + lvp);
        
        float dps = ((float)totalDamage / (float)hits);
        Debug.Log("평균 데미지 : " + dps);


    }



}
