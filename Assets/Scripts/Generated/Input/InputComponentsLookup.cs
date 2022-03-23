//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class InputComponentsLookup {

    public const int Active = 0;
    public const int BattleInput = 1;
    public const int InputControls = 2;
    public const int MotionInput = 3;
    public const int UiInput = 4;
    public const int Fire = 5;
    public const int Look = 6;
    public const int Move = 7;
    public const int GlobalEvents = 8;

    public const int TotalComponents = 9;

    public static readonly string[] componentNames = {
        "Active",
        "BattleInput",
        "InputControls",
        "MotionInput",
        "UiInput",
        "Fire",
        "Look",
        "Move",
        "GlobalEvents"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(Input.Components.ActiveComponent),
        typeof(Input.Components.BattleInputComponent),
        typeof(Input.Components.InputControlsComponent),
        typeof(Input.Components.MotionInputComponent),
        typeof(Input.Components.UiInputComponent),
        typeof(Input.Processing.Components.FireComponent),
        typeof(Input.Processing.Components.LookComponent),
        typeof(Input.Processing.Components.MoveComponent),
        typeof(Main.Globals.GlobalEventsComponent)
    };
}
