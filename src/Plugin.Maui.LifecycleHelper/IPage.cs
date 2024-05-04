namespace Plugin.Maui.LifecycleHelper;

/// <summary>
/// Provides the ability to call methods when a <see cref="Window"> instance raises lifecycle events.
/// </summary>
public interface IPage : IPageCreated, IPageResumed, IPageActivated, IPageDeactivated, IPageStopped, IPageDestroying, IPageBackgrounding
{
    
}