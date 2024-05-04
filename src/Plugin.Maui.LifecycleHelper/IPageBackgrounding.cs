namespace Plugin.Maui.LifecycleHelper;

/// <summary>
/// Provides the ability to call a method when a <see cref="Window"> instance raises lifecycle event <see cref="Window.Backgrounding"/>.
/// </summary>
public interface IPageBackgrounding
{
    /// <summary>
    /// Raised on iOS and Mac Catalyst when the window is closed or enters a background state.
    /// </summary>
    /// <param name="state">A persisted state dictionary.</param>
    void OnBackgrounding(IPersistedState state);
}