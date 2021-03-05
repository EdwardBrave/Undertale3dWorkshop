//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity {

    public UI.Global.OpenWindowComponent openWindow { get { return (UI.Global.OpenWindowComponent)GetComponent(UiComponentsLookup.OpenWindow); } }
    public bool hasOpenWindow { get { return HasComponent(UiComponentsLookup.OpenWindow); } }

    public void AddOpenWindow(UnityEngine.GameObject newPrefab) {
        var index = UiComponentsLookup.OpenWindow;
        var component = (UI.Global.OpenWindowComponent)CreateComponent(index, typeof(UI.Global.OpenWindowComponent));
        component.prefab = newPrefab;
        AddComponent(index, component);
    }

    public void ReplaceOpenWindow(UnityEngine.GameObject newPrefab) {
        var index = UiComponentsLookup.OpenWindow;
        var component = (UI.Global.OpenWindowComponent)CreateComponent(index, typeof(UI.Global.OpenWindowComponent));
        component.prefab = newPrefab;
        ReplaceComponent(index, component);
    }

    public void RemoveOpenWindow() {
        RemoveComponent(UiComponentsLookup.OpenWindow);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class UiMatcher {

    static Entitas.IMatcher<UiEntity> _matcherOpenWindow;

    public static Entitas.IMatcher<UiEntity> OpenWindow {
        get {
            if (_matcherOpenWindow == null) {
                var matcher = (Entitas.Matcher<UiEntity>)Entitas.Matcher<UiEntity>.AllOf(UiComponentsLookup.OpenWindow);
                matcher.componentNames = UiComponentsLookup.componentNames;
                _matcherOpenWindow = matcher;
            }

            return _matcherOpenWindow;
        }
    }
}
