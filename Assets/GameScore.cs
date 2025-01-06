using UnityEngine;

[CreateAssetMenu]
public class GameScore : ScriptableObject
{
    [SerializeField] int coins;
    [SerializeField] int time;

    Clock clock;

    public void StartGame(Clock clock)
    {
        Cursor.visible = false;
        coins = 0;
        time = 0;
        this.clock = clock;
    }

    public void AddCoin()
    {
        coins++;
    }

    public void CollectCoin()
    {
        coins--;
        if (coins == 0)
        {
            clock.Stop();
            Debug.Log($"Coins collected in {time} seconds");
        }
    }

    public void AddSecond()
    {
        time++;
    }
}
