using UnityEngine;


[CreateAssetMenu]
public class CardSO : ScriptableObject
{
    public Color cardColor;
    public Sprite art;
    //Power card options are Jump,...
    public GameAction power;

    public void UsePower()
    {
        power.RaiseAction();
    }
}
