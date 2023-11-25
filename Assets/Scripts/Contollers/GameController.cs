using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject camera;

    [SerializeField] private MoveController moveController;
    [SerializeField] private UIController uiController;
    [SerializeField] private EntityController entityController;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private SoundController soundController;

    private void Start()
    {
        SetActions();
        soundController.SetSound(entityController.GetCoins(), SoundType.Coin);
        
        moveController.MoveTarget(player);
        moveController.MoveTarget(camera);
    }

    private void SetActions()
    {
        int value = Data.instance.DynamicData.CoinData.pickupValue;
        playerController.onCoinPickup = () => uiController.SetCoinText(value.ToString());
    }
}
