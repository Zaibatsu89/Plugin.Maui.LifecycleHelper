namespace Plugin.Maui.LifecycleHelper;

/// <summary>
/// Provides the ability to call a method when a <see cref="Window"> instance raises lifecycle event <see cref="Window.Activated"/>.
/// </summary>
public interface IPageActivated
{
    /// <summary>
    /// Raised when the window is activated.
    /// </summary>
    void OnActivated();
}