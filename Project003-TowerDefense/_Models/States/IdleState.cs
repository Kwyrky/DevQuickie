namespace Project003;

public class IdleState : GameState
{
    public IdleState(GameManager gm) : base(gm)
    {
    }

    public override void Update()
    {
        _gm.monsterManager.Update();
        _gm.map.Update();
        _gm.button.Update();
    }

    public override void Draw()
    {
        _gm.map.Draw();
        _gm.monsterManager.Draw();
        _gm.button.Draw();
    }
}
