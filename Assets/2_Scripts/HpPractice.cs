using UnityEngine;

public class HpPractice : MonoBehaviour
{
    public int currentHp = 0;
    public int maxHp = 10;

    [ContextMenu("체력")]
    public void PrintHp()
    {
        int a = currentHp * 100 / maxHp;
        Debug.Log(a + "%");
    }


}
