namespace Plugin.Maui.LifecycleHelper;

/// <summary>
/// Provides the ability to call a method when a <see cref="Window"> instance raises lifecycle event <see cref="Window.Stopped"/>.
/// </summary>
public interface IPageStopped
{
    /// <summary>
    /// Raised when the window is stopped.
    /// </summary>
    void OnStopped();
}