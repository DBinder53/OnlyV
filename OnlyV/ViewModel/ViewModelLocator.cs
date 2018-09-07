using OnlyV.Services.DisplayWindow;

namespace OnlyV.ViewModel
{
    using CommonServiceLocator;
    using GalaSoft.MvvmLight.Ioc;
    using OnlyV.Services.Bible;
    using OnlyV.Services.CommandLine;
    using OnlyV.Services.Images;
    using OnlyV.Services.Monitors;
    using OnlyV.Services.Options;

    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    internal class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<DisplayViewModel>();
            SimpleIoc.Default.Register<ScripturesViewModel>();
            SimpleIoc.Default.Register<SettingsViewModel>();
            SimpleIoc.Default.Register<PreviewViewModel>();

            SimpleIoc.Default.Register<ICommandLineService, CommandLineService>();
            SimpleIoc.Default.Register<IBibleVersesService, BibleVersesService>();
            SimpleIoc.Default.Register<IOptionsService, OptionsService>();
            SimpleIoc.Default.Register<IImagesService, ImagesService>();
            SimpleIoc.Default.Register<IMonitorsService, MonitorsService>();
            SimpleIoc.Default.Register<IDisplayWindowService, DisplayWindowService>();
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

        public DisplayViewModel Display => ServiceLocator.Current.GetInstance<DisplayViewModel>();

        public ScripturesViewModel Scriptures => ServiceLocator.Current.GetInstance<ScripturesViewModel>();

        public SettingsViewModel Settings => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        public PreviewViewModel Preview => ServiceLocator.Current.GetInstance<PreviewViewModel>();
    }
}