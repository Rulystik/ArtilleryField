using DG.Tweening;
using UnityEngine;

public class Controller
{
    public View View { get; }
    public Model Model{ get; }
    public MenuBehavior MenuBehavior { get; }
    public BattleFieldView BattleFieldView { get; }
    private ShootController shootController;
    
    public Controller(View view, MenuBehavior menuBehavior, BattleFieldView fieldView)
    {
        Model = new Model();
        View = view;
        MenuBehavior = menuBehavior;
        BattleFieldView = fieldView;
        shootController = new ShootController(BattleFieldView, Model);
        
        View.SingleButtonAction += StartSingleGame;
        View.MultiButtonAction += StartMultiGame;
        View.ExitButtonAction += ExitGame;
        
        Model.EnemyCellStateChanged += fieldView.SetImageOnEnemyField;
        Model.PlayerCellStateChanged += fieldView.SetImageOnPlayerField;
        
        BattleFieldView.ShootMarkAction += shootController.SetShootingCrossPos;
    }

    private void StartSingleGame()
    {
        MenuBehavior.MenuMoving();
        Model.ClearDataForNewGame();
        DOVirtual.DelayedCall(0.3f, Model.ClearDataForNewGame).OnComplete(()=> BattleFieldView.BattleFieldActiveOnOff());
    }

    private void StartMultiGame()
    {
        //TO DO
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
