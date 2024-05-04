namespace Plugin.Maui.LifecycleHelper;

/// <summary>
/// Provides the ability to call a method when a <see cref="Window"> instance raises lifecycle event <see cref="Window.Destroying"/>.
/// </summary>
public interface IPageDestroying
{
    /// <summary>
    /// Raised when the window is destroyed.
    /// </summary>
    void OnDestroying();
}