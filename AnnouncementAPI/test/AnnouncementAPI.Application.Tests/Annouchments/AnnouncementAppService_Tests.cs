using AnnouncementAPI.Entities.Dto;
using AnnouncementAPI.Repositories.Interface;
using AnnouncementAPI.Samples;
using AnnouncementAPI.Services;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Xunit;

namespace AnnouncementAPI.Annouchments;

public abstract class AnnouncementAppService_Tests<TStartupModule> : AnnouncementAPIApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
    private readonly IAnnouchmentAppService _annouchmentAppService;

    protected AnnouncementAppService_Tests()
    {
        _annouchmentAppService = GetRequiredService<IAnnouchmentAppService>();
    }

    [Fact]
    public async Task GET_ALL_ANNOUCHEMENTS_TEST_OK()
    {
        var result = _annouchmentAppService.GetAllAnnouchment();
        result[0].Id.ShouldNotBe(-1);
    }

    [Fact]
    public async Task ADD_ANNOUCHMENT_TEST_OK()
    {
        AddAnnouchment addAnnouchment = new AddAnnouchment
        {
            Content = "TESTING_CONTENT",
            Title = "TESTING_TITLE"
        };

        var result = _annouchmentAppService.AddAnnouchement(addAnnouchment);
        result.Content.ShouldBe("TESTING_CONTENT");
    }

    [Fact]
    public async Task ADD_ANNOUCHMENT_TEST_NOT_OK()
    {
        AddAnnouchment addAnnouchment = new AddAnnouchment
        {
            Content = "TESTING_CONTENT_NOT_OK",
            Title = "TESTING_CONTENT_NOT_OK"
        };

        var result = _annouchmentAppService.AddAnnouchement(addAnnouchment);
        result.Content.ShouldNotBe("TESTING_CONTENT");
    }

    [Fact]
    public async Task ADD_ANNOUCHMENT_EMPTY_TITLE_TEST_OK()
    {
        AddAnnouchment addAnnouchment = new AddAnnouchment
        {
            Content = "TESTING_CONTENT_NOT_OK",
            Title = ""
        };

        var result = _annouchmentAppService.AddAnnouchement(addAnnouchment);
        result.Content.ShouldNotBe("TESTING_CONTENT");
    }
}