using UnityEngine;
using Zenject;

public class PrefabHolderInstaller : MonoInstaller
{
    [SerializeField] private PrefabHolder _prefabHolder;

    public override void InstallBindings()
    {
        Container.Bind<PrefabHolder>().FromInstance(_prefabHolder).AsSingle();
    }
}
