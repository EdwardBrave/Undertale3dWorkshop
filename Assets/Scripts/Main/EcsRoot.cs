﻿using UnityEngine;
#if UNITY_EDITOR
using Sirenix.OdinInspector;
#endif

namespace Main
{
    [DisallowMultipleComponent]
    public sealed class EcsRoot : MonoBehaviour
    {
        ////////////////////////////////////////////////////////////////////
        #region Variables
        
        private static EcsRoot _instance;
        
#if UNITY_EDITOR
        [OnValueChanged(nameof(OnStateChanged))]
#endif
        [SerializeField] private RegisteredGameState gameState;
        [SerializeField] private ChangeGameStateComponent.StateMode stateMode;
        
        private RootStateMachine _rootStateMachine;

        #endregion
        ////////////////////////////////////////////////////////////////////
        #region Implementation

#if UNITY_EDITOR
        private void OnStateChanged()
        {
            if (Application.isPlaying)
            {
                Contexts.sharedInstance.core.gameStateEntity.AddChangeGameState(gameState, stateMode);
            }
        }
#endif
        
        private void Awake()
        {
            var contexts = Contexts.sharedInstance;
            if (_instance)
            {
                
                if (contexts.core.gameState.type != gameState)
                {
                    contexts.core.gameStateEntity.AddChangeGameState(gameState, stateMode);
                }
                Destroy(this);
            }
            else
            {
                _instance = this;
                DontDestroyOnLoad(this);
                
                contexts.Reset();
                contexts.game.isGlobalEvents = true;
                contexts.ui.isGlobalEvents = true;
                contexts.core.isGlobalEvents = true;
                contexts.input.isGlobalEvents = true;
            
                _rootStateMachine = new RootStateMachine(gameState, Contexts.sharedInstance);
            }
        }
        
        private void Update()
        {
            _rootStateMachine.Execute();
        }
        
        private void LateUpdate()
        {
            _rootStateMachine.Cleanup();
        }
        
        #endregion
        ////////////////////////////////////////////////////////////////////
    }
}
