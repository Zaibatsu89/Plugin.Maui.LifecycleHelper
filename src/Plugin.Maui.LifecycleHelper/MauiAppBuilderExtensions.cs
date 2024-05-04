namespace Plugin.Maui.LifecycleHelper;

public static class MauiAppBuilderExtensions
{
    /// <summary>
    /// Adds the <see cref="ILifecycleHelper"/> as a singleton to the dependency injection container.
    /// </summary>
    /// <param name="mauiAppBuilder">The <see cref="MauiAppBuilder"/> to register the package with.</param>
    /// <returns>The <paramref name="mauiAppBuilder"/> supplied in order to allow for chaining of method calls.</returns>
    public static MauiAppBuilder AddLifecycleHelper(
        this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton(LifecycleManager.Current);

        return mauiAppBuilder;
    }
}
