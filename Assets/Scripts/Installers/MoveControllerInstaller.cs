using UnityEngine;
using Zenject;

public class MoveControllerInstaller : MonoInstaller
{
    [SerializeField] private MoveController moveController;
    
    public override void InstallBindings()
    {
        Container.Bind<MoveController>().FromInstance(moveController).AsSingle();
    }
}