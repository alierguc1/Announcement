using AnnouncementAPI.Entities.Dto;
using AnnouncementAPI.Repositories.Interface;
using AnnouncementAPI.Utils;
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
    public class AddAnnouchmentWorker : AsyncPeriodicBackgroundWorkerBase
    {
        private readonly IAnnouncementRepositories _annouchmentAppService;
        public AddAnnouchmentWorker(AbpAsyncTimer timer, IAnnouncementRepositories annouchmentAppService, IServiceScopeFactory serviceScopeFactory) : base(timer, serviceScopeFactory)
        {
            _annouchmentAppService = annouchmentAppService;
            //Timer.Period = 3600000; //1 Saat
            Timer.Period = 60000; //1 Saat
        }

        protected async override Task DoWorkAsync(PeriodicBackgroundWorkerContext workerContext)
        {
            Logger.LogInformation("Starting: Annouchement Add Background Worker");
            AddAnnouchment addAnnouchment = new AddAnnouchment
            {
                Title = RandomCreateWord.RandomWord(),
                Content = RandomCreateWord.RandomWord()
            };

            _annouchmentAppService.AddAnnouchement(addAnnouchment);
            Logger.LogInformation("Finished: Annouchement Add Background Worker");
        }
    }
}
