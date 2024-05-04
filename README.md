# Plugin.Maui.LifecycleHelper

`Plugin.Maui.LifecycleHelper` provides the ability to implement lifecycle triggers in Pages of Shell, NavigationPage or TabbedPage inside a .NET MAUI application. It is the evolution of Zaibatsu89 maui-lifecycle-helper.

## Getting Started

* Available on NuGet: <https://www.nuget.org/packages/Plugin.Maui.LifecycleHelper> [![NuGet](https://img.shields.io/nuget/v/Plugin.Maui.LifecycleHelper.svg?label=NuGet)](https://www.nuget.org/packages/Plugin.Maui.LifecycleHelper/)

## API Usage

`Plugin.Maui.LifecycleHelper` provides the `LifecycleManager` class that allows for the modification of [`Window`](docs/lifecycle-manager.md)s. The `LifecycleManager` can be used with or without dependency injection.

### `LifecycleManager`

There are two different ways in which you can interact with the `LifecycleManager` implementation provided by this plugin, they are:

#### Dependency Injection

You will first need to register the `LifecycleManager` with the `MauiAppBuilder` based on the following example:

```csharp
builder.AddLifecycleHelper();
```

You can then enable your `App` class to depend on `ILifecycleManager` as per the following example.

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

#### Straight usage

Alternatively if you want to skip using the dependency injection approach you can use the `LifecycleManager.Current` property.

```csharp
public partial class App : Application
{
    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);

        LifecycleManager.Current.ModifyWindow(window, MainPage);

        return window;
    }
}
```

Now that you know how tu use the `LifecycleManager` class, please refer to the following section:

* [Lifecycle management](docs/lifecyle-manager.md)

## Acknowledgements

This project could not have came to be without these projects and people, thank you! <3

## Plugin.Maui.Feature template

Basically the template for this plugin. We have been using this in our .NET MAUI projects with much joy and ease, so thank you so much [Gerald](https://github.com/jfversluis/) (and contributors!) for that. Find the original project [here](https://github.com/jfversluis/Plugin.Maui.Feature/) where we have based our project on and evolved it from there.

## Changelog

- Version 1.0.0
