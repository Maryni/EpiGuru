using UnityEngine;
using Zenject;

public class GameControllerInstaller : MonoInstaller
{
    [SerializeField] private GameController gameController;
    
    public override void InstallBindings()
    {
        Container.Bind<GameController>().FromInstance(gameController).AsSingle();
    }
}