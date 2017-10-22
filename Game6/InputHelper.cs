using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

public class InputHelper
{
    public MouseState currentMouseState, previousMouseState;
    public KeyboardState currentKeyboardState, previousKeyboardState;

    double timeSinceLastKeyPress;

    double keyPressInterval;

    public InputHelper()
    {
        keyPressInterval = 100;
        timeSinceLastKeyPress = 0;
    }

    public void Update(GameTime gameTime)
    {
        Keys[] prevKeysDown = previousKeyboardState.GetPressedKeys();
        Keys[] currKeysDown = currentKeyboardState.GetPressedKeys();

        if (currKeysDown.Length != 0 && (prevKeysDown.Length == 0 || timeSinceLastKeyPress > keyPressInterval))
            timeSinceLastKeyPress = 0;
        else
            timeSinceLastKeyPress += gameTime.ElapsedGameTime.TotalMilliseconds;

        previousMouseState = currentMouseState;
        previousKeyboardState = currentKeyboardState;
        currentMouseState = Mouse.GetState();
        currentKeyboardState = Keyboard.GetState();
    }

    public bool KeyPressed(Keys k, bool detecthold = true)
    {
        return currentKeyboardState.IsKeyDown(k) && (previousKeyboardState.IsKeyUp(k) || (timeSinceLastKeyPress > keyPressInterval && detecthold));
    }

    public bool IsKeyDown(Keys k)
    {
        return currentKeyboardState.IsKeyDown(k);
    }
}