using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFish : Fish
{
    public RedFish()
    {
        type = FishType.Red;
    }

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void OnTriggerEnter2D(Collider2D col)
    {
        base.OnTriggerEnter2D(col);
    }

    protected override void OnFoodTrigger(Food food)
    {
        //플레이어와 붙어있는 먹이라면
        if (food.IsPlayerFood())
        {
            //게임오버를 호출해준다
            GameManager.instance.gameover();
        }

        //먹이를 비활성화시킨다
        food.Disable();
    }

    protected override void OnPlayerTirgger()
    {
        //게임오버를 호출해준다
        GameManager.instance.gameover();
    }
}
