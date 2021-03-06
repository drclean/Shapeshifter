﻿namespace Shapeshifter.WindowsDesktop.Services.Keyboard.Interfaces
{
    public interface IKeyboardPasteCombinationStateService
    {
        bool IsCombinationFullyHeldDown { get; }
        bool IsCombinationPartiallyHeldDown { get; }
    }
}