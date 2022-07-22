using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ShootController
{
    private BattleFieldView BattleFieldView { get; }
    private Model Model { get; }
    private int? prevCellId;
    private int targetId;


    public ShootController(BattleFieldView fieldView, Model model)
    {
        BattleFieldView = fieldView;
        Model = model;
        BattleFieldView.ShootButtonDownAction += Shoot;
        BattleFieldView.EnemyFieldOnPosAction += SetShootingCrossRandomPos;
    }

    private void SetShootingCrossRandomPos()
    {
        int x = Random.Range(0,9);
        int y = Random.Range(0, 9);
        int idPos = FormgId(x, y);

        if (Model.GetEnemyCellState(idPos) == CellState.Clear)
        {
            prevCellId = null;
            SetShootingCrossPos(idPos);
        }
        else
        {
            SetShootingCrossRandomPos();
        }
    }
    private int FormgId(int x, int y)
    {
        if (x == 0)
        {
            return y;
        }

        return x * 10 + y;
    }

    public void SetShootingCrossPos(int id)
    {
        if (Model.GetEnemyCellState(id) == CellState.Clear)
        {
            var enemyTile =  BattleFieldView.enemyViewObjects[id];
            var sprite = BattleFieldView.GetCrossImage();
            enemyTile.SetStateIcon(sprite);

            targetId = id;

            if (prevCellId != id && prevCellId != null)
            {
                CellState prevCellState = Model.GetEnemyCellState((int)prevCellId);

                if (prevCellState == CellState.Clear)
                {
                    BattleFieldView.enemyViewObjects[(int)prevCellId].DeactivateStateTile();
                }
            }
            prevCellId = id;
        }
        

    }

    public void Shoot()
    {
        // Send CellID for check if get target
        // if got target need to get ID and state arti
        // shoot again or enemy shoot
        
        

        BattleFieldView.enemyViewObjects[targetId].DeactivateStateTile();
        DOVirtual.DelayedCall(1, () => BattleFieldView.SwapFields());

    }

   
}
