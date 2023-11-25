using UnityEngine;
using Zenject;

public class SoundControllerInstaller : MonoInstaller
{
    [SerializeField] private SoundController soundController;
    public override void InstallBindings()
    {
        Container.Bind<SoundController>().FromInstance(soundController).AsSingle();
    }
}