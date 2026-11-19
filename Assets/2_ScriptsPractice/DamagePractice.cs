using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    public int attack = 12;
    public int defence = 5;
    public bool isCritical = true;
    public bool targetIsBoss = true;

    [ContextMenu("데미지")]
    public void Clac()
    {
        int damage = Mathf.Max(attack - defence, 1);
        if (isCritical) damage = damage * 2;
        if (targetIsBoss) damage = damage / 2;

        Debug.Log(damage);
    }
    [ContextMenu("계단")]
    void Stairs()
    {
        int height = 5;
        string result = "";
        for (int row = 1; row <= height; row++)
        {
            for (int col = 0; col < row; col++)
            {
                result += "*";
            }
            result += "\n";
        }
        Debug.Log(result);
    }


}
