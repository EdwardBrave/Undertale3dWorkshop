﻿using System.Collections.Generic;
using Entitas;

namespace Logic.Systems.UI
{
    public class CreateCanvasSystem: IInitializeSystem
    {

        private readonly UiContext _context;
        //private readonly List<CanvasInitData> _canvasInitList;

        public CreateCanvasSystem(Contexts contexts)
        {
            _context = contexts.ui;
            //_canvasInitList = _context;
        }

        public void Initialize()
        {

            // foreach (var canvasData in _canvasInitList)
            // {
            //     var canvasEntity = _context.CreateEntity();
            //     //canvasEntity.AddCanvas(canvasData.name, new List<UiEntity>());
            //     //canvasEntity.AddWindow(null, canvasData.name);
            //     foreach (var windowPath in canvasData.windows)
            //     {
            //         var windowEntity = _context.CreateEntity();
            //         if (windowPath.Contains("!"))
            //             windowEntity.isProtected = true;
            //         var args = windowPath.Replace("!", "").Split(':');
            //        // windowEntity.AddWindow(canvasData.name, args[0]);
            //     }
            // }
        }
    }
}