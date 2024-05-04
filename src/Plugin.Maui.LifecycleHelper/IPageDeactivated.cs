namespace Plugin.Maui.LifecycleHelper;

/// <summary>
/// Provides the ability to call a method when a <see cref="Window"> instance raises lifecycle event <see cref="Window.Deactivated"/>.
/// </summary>
public interface IPageDeactivated
{
    /// <summary>
    /// Raised when the window is deactivated.
    /// </summary>
    void OnDeactivated();
}