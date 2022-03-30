//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class UiComponentsLookup {

    public const int Close = 0;
    public const int Protected = 1;
    public const int Container = 2;
    public const int MainScreen = 3;
    public const int View = 4;
    public const int UiEvent = 5;
    public const int CreateWindow = 6;

    public const int TotalComponents = 7;

    public static readonly string[] componentNames = {
        "Close",
        "Protected",
        "Container",
        "MainScreen",
        "View",
        "UiEvent",
        "CreateWindow"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(UI.Close.CloseComponent),
        typeof(UI.Close.ProtectedComponent),
        typeof(UI.Common.ContainerComponent),
        typeof(UI.Common.MainScreenComponent),
        typeof(UI.Common.ViewComponent),
        typeof(UI.Events.UiEventComponent),
        typeof(UI.Open.CreateWindowComponent)
    };
}
