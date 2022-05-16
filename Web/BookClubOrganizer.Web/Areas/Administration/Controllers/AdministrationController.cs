namespace BookClubOrganizer.Web.Areas.Administration.Controllers
{
    using BookClubOrganizer.Common;
    using BookClubOrganizer.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
