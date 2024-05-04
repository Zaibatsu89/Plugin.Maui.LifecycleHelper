namespace Plugin.Maui.LifecycleHelper;

/// <summary>
/// Provides the ability to call a method when a <see cref="Window"> instance raises lifecycle event <see cref="Window.Created"/>.
/// </summary>
public interface IPageCreated
{
    /// <summary>
    /// Raised when the window is created.
    /// </summary>
    void OnCreated();
}