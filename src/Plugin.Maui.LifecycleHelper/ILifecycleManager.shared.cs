namespace Plugin.Maui.LifecycleHelper;

/// <summary>
/// Provides the ability to handle lifecycle events.
/// </summary>
public interface ILifecycleManager
{
    /// <summary>
    /// Modifies an existing <see cref="Window"/> ready to handle.
    /// </summary>
    /// <typeparam name="T">A <see cref="Shell"/>, <see cref="NavigationPage"/> or <see cref="TabbedPage"/> containing the pages to handle.</typeparam>
    /// <param name="window">An existing <see cref="Window"/>.</param>
    /// <param name="navigation">The <see cref="Shell"/>, <see cref="NavigationPage"/> or <see cref="TabbedPage"/> containing the pages to handle.</param>
    /// <returns>A modified <see cref="Window"/> ready to handle.</returns>
    Window ModifyWindow<T>(Window window, T navigation);
}