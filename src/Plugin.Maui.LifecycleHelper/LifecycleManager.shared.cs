namespace Plugin.Maui.LifecycleHelper;

/// <summary>
/// Implementation of <see cref="ILifecycleManager"/> providing the ability to modify a <see cref="Window"> instance.
/// </summary>
public class LifecycleManager : ILifecycleManager
{
    static ILifecycleManager? currentImplementation;

    /// <summary>
    /// Gets the current implementation of the lifecycle manager.
    /// </summary>
    public static ILifecycleManager Current => currentImplementation ??= new LifecycleManager();

    /// <inheritdoc cref="ILifecycleManager.ModifyWindow{T}(Window, T)" />
	public Window ModifyWindow<T>(Window window, T navigation)
    {
        ArgumentNullException.ThrowIfNull(window);
        ArgumentNullException.ThrowIfNull(navigation);

        window.Created += (s, e) =>
        {
            if (CurrentPage(navigation) is IPageCreated page)
            {
                page.OnCreated();
            }
        };

        window.Resumed += (s, e) =>
        {
            if (CurrentPage(navigation) is IPageResumed page)
            {
                page.OnResumed();
            }
        };

        window.Activated += (s, e) =>
        {
            if (CurrentPage(navigation) is IPageActivated page)
            {
                page.OnActivated();
            }
        };

        window.Deactivated += (s, e) =>
        {
            if (CurrentPage(navigation) is IPageDeactivated page)
            {
                page.OnDeactivated();
            }
        };

        window.Stopped += (s, e) =>
        {
            if (CurrentPage(navigation) is IPageStopped page)
            {
                page.OnStopped();
            }
        };

        window.Destroying += (s, e) =>
        {
            if (CurrentPage(navigation) is IPageDestroying page)
            {
                page.OnDestroying();
            }
        };

        window.Backgrounding += (s, e) =>
        {
            if (CurrentPage(navigation) is IPageBackgrounding page)
            {
                page.OnBackgrounding(e.State);
            }
        };

        return window;
    }

    /// <summary>
    /// Gets the current page of the <paramref name="navigation"/>.
    /// </summary>
    /// <typeparam name="T">A <see cref="Shell"/>, <see cref="NavigationPage"/> or <see cref="TabbedPage"/> containing the pages to handle.</typeparam>
    /// <param name="navigation">The <see cref="Shell"/>, <see cref="NavigationPage"/> or <see cref="TabbedPage"/> containing the pages to handle.</param>
    /// <returns><see cref="Page"/>?.</returns>
    private static Page? CurrentPage<T>(T navigation)
    {
        if (navigation is Shell s)
        {
            return s.CurrentPage;
        }
        else if (navigation is NavigationPage np)
        {
            return np.CurrentPage;
        }
        else if (navigation is TabbedPage tp)
        {
            return tp.CurrentPage;
        }

        return null;
    }
}