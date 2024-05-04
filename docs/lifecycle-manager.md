# Lifecycle management

The `LifecycleManager` class provides you with the ability to implement lifecycle triggers for Pages of Shell, NavigationPage or TabbedPage in your .NET MAUI application. In order to modify an existing `Window` instance you can make use of the `ModifyWindow` method on the [`LifecycleManager`](../main/README.md#lifecyclemanager) class.

```csharp
public partial class App : Application
{
    public App(ILifecycleManager lifecycleManager)
    {
        this.lifecycleManager = lifecycleManager;
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);

        lifecycleManager.ModifyWindow(window, MainPage);

        return window;
    }
}
```

## LifecycleManager API

Once you have modified the `Window` you can interact with the current `Page` of a `Shell`, `NavigationPage` or `TabbedPage` in the following ways:

### Methods

A `Page` class inheriting the `IPage` interface provides the following callback methods:

#### `OnCreated()`

Raised when the window is created.

#### `OnResumed()`

Raised when the window is resumed from a sleeping state.

#### `OnActivated()`

Raised when the window is activated.

#### `OnDeactivated()`

Raised when the window is deactivated.

#### `OnStopped()`

Raised when the window is stopped.

#### `OnDestroying()`

Raised when the window is destroyed.

#### `OnBackgrounding(IPersistedState state)`

Raised on iOS and Mac Catalyst when the window is closed or enters a background state.
