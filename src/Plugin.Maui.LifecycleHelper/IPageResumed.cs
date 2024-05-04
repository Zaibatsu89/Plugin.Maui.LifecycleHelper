namespace Plugin.Maui.LifecycleHelper;

/// <summary>
/// Provides the ability to call a method when a <see cref="Window"> instance raises lifecycle event <see cref="Window.Resumed"/>.
/// </summary>
public interface IPageResumed
{
    /// <summary>
    /// Raised when the window is resumed from a sleeping state.
    /// </summary>
    void OnResumed();
}