using Autofac;
using FriendOrganizer.DataAccess;
using FriendOrganizer.Ui.Data;
using FriendOrganizer.Ui.ViewModels;

namespace FriendOrganizer.Ui.Startup
{
    public class Bootstrapper
    {
        public IContainer BootStrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<FriendOrganizerDbContext>().AsSelf();

            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<FriendDataService>().As<IFriendDataService>();
            return builder.Build();
        }
    }
}
