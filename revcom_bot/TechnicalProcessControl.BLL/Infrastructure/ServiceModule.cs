using TechnicalProcessControl.BLL.Services;
using TechnicalProcessControl.BLL.Interfaces;
using TerminalMKTelegramBot.Services;
using Ninject.Modules;
using TechnicalProcessControl.DAL.Interfaces;

namespace TerminalMKTelegramBot.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
            
            Bind<IBotService>().To<BotService>();
            Bind<IControlPanelService>().To<ControlPanelService>();
            Bind<IMySqlService>().To<MySqlService>();
            Bind<IDrawingService>().To<DrawingService>();
            Bind<IReportService>().To<ReportService>();
        }
    }
}
