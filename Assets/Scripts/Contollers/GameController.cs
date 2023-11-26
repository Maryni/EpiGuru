using UnityEngine;

public class GameController : MonoBehaviour
{
    #region variables

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject camera;

    [SerializeField] private MoveController moveController;
    [SerializeField] private UIController uiController;
    [SerializeField] private EntityController entityController;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private SoundController soundController;

    #endregion variables

    #region private functions

    private void Start()
    {
        SetActions();
        entityController.SetCubesOnPoints();
    }

    private void SetActions()
    {
        //int value = ;
        playerController.onCoinPickup = () => uiController.SetCoinText(Data.instance.DynamicData.CoinData.pickupValue.ToString());
        playerController.onDeathTrigger = () => uiController.DeathScene();
    }
    
    private void FixedUpdate()
    {
        moveController.MoveTarget(player);
        moveController.MoveTarget(camera);
    }

    #endregion private functions
}   
