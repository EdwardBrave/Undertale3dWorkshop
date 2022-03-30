//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class CoreComponentsLookup {

    public const int SaveUserProgress = 0;
    public const int UserData = 1;
    public const int CloseScene = 2;
    public const int LoadScene = 3;
    public const int Scene = 4;
    public const int SceneLoading = 5;
    public const int SceneOffset = 6;
    public const int GlobalGameConfigs = 7;
    public const int ChangeGameState = 8;
    public const int GameState = 9;

    public const int TotalComponents = 10;

    public static readonly string[] componentNames = {
        "SaveUserProgress",
        "UserData",
        "CloseScene",
        "LoadScene",
        "Scene",
        "SceneLoading",
        "SceneOffset",
        "GlobalGameConfigs",
        "ChangeGameState",
        "GameState"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(Core.Save.SaveUserProgressComponent),
        typeof(Core.Save.UserDataComponent),
        typeof(Core.UnityScene.Components.CloseSceneComponent),
        typeof(Core.UnityScene.Components.LoadSceneComponent),
        typeof(Core.UnityScene.Components.SceneComponent),
        typeof(Core.UnityScene.Components.SceneLoadingComponent),
        typeof(Core.UnityScene.Components.SceneOffsetComponent),
        typeof(GlobalGameConfigsComponent),
        typeof(Main.ChangeGameStateComponent),
        typeof(Main.GameStateComponent)
    };
}
