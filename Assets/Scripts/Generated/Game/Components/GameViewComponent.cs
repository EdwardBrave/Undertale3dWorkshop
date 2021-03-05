//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Game.ViewComponent view { get { return (Game.ViewComponent)GetComponent(GameComponentsLookup.View); } }
    public bool hasView { get { return HasComponent(GameComponentsLookup.View); } }

    public void AddView(UnityEngine.GameObject newObj, UnityEngine.Vector3 newPosition, UnityEngine.Vector3 newRotation, UnityEngine.Vector3 newScale) {
        var index = GameComponentsLookup.View;
        var component = (Game.ViewComponent)CreateComponent(index, typeof(Game.ViewComponent));
        component.obj = newObj;
        component.Position = newPosition;
        component.Rotation = newRotation;
        component.Scale = newScale;
        AddComponent(index, component);
    }

    public void ReplaceView(UnityEngine.GameObject newObj, UnityEngine.Vector3 newPosition, UnityEngine.Vector3 newRotation, UnityEngine.Vector3 newScale) {
        var index = GameComponentsLookup.View;
        var component = (Game.ViewComponent)CreateComponent(index, typeof(Game.ViewComponent));
        component.obj = newObj;
        component.Position = newPosition;
        component.Rotation = newRotation;
        component.Scale = newScale;
        ReplaceComponent(index, component);
    }

    public void RemoveView() {
        RemoveComponent(GameComponentsLookup.View);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherView;

    public static Entitas.IMatcher<GameEntity> View {
        get {
            if (_matcherView == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.View);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherView = matcher;
            }

            return _matcherView;
        }
    }
}
