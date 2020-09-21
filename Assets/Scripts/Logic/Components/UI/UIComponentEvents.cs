﻿using Entitas;

namespace Logic.Components.UI
{
    [Ui]
    public class ConfirmComponent: IComponent { }
    
    [Ui]
    public class RejectComponent : IComponent { }

    [Ui]
    public class CheckComponent : IComponent
    {
        public bool state;
    }

    [Ui]
    public class CloseComponent: IComponent { }
}