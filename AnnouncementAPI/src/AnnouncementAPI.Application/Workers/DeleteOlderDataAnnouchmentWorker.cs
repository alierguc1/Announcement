using AnnouncementAPI.Repositories.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Threading;

namespace AnnouncementAPI.Workers
{
    public class DeleteOlderDataAnnouchmentWorker : AsyncPeriodicBackgroundWorkerBase
    {
        private readonly IAnnouncementRepositories _annouchementRepositories;

        public DeleteOlderDataAnnouchmentWorker(
            AbpAsyncTimer timer,
            IAnnouncementRepositories annouchementRepositories,
            IServiceScopeFactory serviceScopeFactory) : base(timer, serviceScopeFactory)
        {
            Timer.Period = 86400000; //1 Gün
            _annouchementRepositories = annouchementRepositories;
        }

        protected async override Task DoWorkAsync(PeriodicBackgroundWorkerContext workerContext)
        {
            Logger.LogInformation("Starting: Annouchement Delete Older Data Background Worker");
            _annouchementRepositories.DeleteOlderAnnouchement();
            Logger.LogInformation("Finished: Annouchement Delete Older Data Background Worker");
        }
    }
}
