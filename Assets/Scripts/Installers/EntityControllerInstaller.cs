using UnityEngine;
using Zenject;

public class EntityControllerInstaller : MonoInstaller
{
    [SerializeField] private EntityController entityController;
    
    public override void InstallBindings()
    {
        Container.Bind<EntityController>().FromInstance(entityController).AsSingle();
    }
}