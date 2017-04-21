﻿// ----------------------------------------------------------------------------
// The MIT License
// LeopotamGroupLibrary https://github.com/Leopotam/LeopotamGroupLibraryUnity
// Copyright (c) 2012-2017 Leopotam <leopotam@gmail.com>
// ----------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UI;

namespace LeopotamGroup.SystemUi.Markup {
    [CreateAssetMenu (menuName = "LeopotamGroup/SystemUi/Create new markup theme", order = 150)]
    public sealed class MarkupTheme : ScriptableObject {
        [SerializeField]
        string _name = "NewMarkupTheme";

        [SerializeField]
        Sprite _buttonNormalSprite;

        [SerializeField]
        Sprite _buttonPressedSprite;

        [SerializeField]
        Sprite _buttonHighlightedSprite;

        [SerializeField]
        Sprite _buttonDisabledSprite;

        [SerializeField]
        Color _buttonNormalColor = Color.white;

        [SerializeField]
        Color _buttonPressedColor = Color.white;

        [SerializeField]
        Color _buttonFocusedColor = Color.white;

        [SerializeField]
        Color _buttonDisabledColor = Color.gray;

        public enum ButtonState {
            Normal,
            Pressed,
            Highlighted,
            Disabled
        }

        public string GetName () {
            return _name;
        }

        public Sprite GetButtonSprite (ButtonState state) {
            switch (state) {
                case ButtonState.Normal:
                    return _buttonNormalSprite;
                case ButtonState.Pressed:
                    return _buttonPressedSprite;
                case ButtonState.Highlighted:
                    return _buttonHighlightedSprite;
                case ButtonState.Disabled:
                    return _buttonDisabledSprite;
                default:
                    return null;
            }
        }

        public Color GetButtonColor (ButtonState state) {
            switch (state) {
                case ButtonState.Normal:
                    return _buttonNormalColor;
                case ButtonState.Pressed:
                    return _buttonPressedColor;
                case ButtonState.Highlighted:
                    return _buttonFocusedColor;
                case ButtonState.Disabled:
                    return _buttonDisabledColor;
                default:
                    return Color.black;
            }
        }
    }
}