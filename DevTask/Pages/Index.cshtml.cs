using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevTask.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DevTask
{
    public class IndexModel : PageModel
    {
        public LossTypeService LossTypeService;
        public UserService UserService;
        public IEnumerable<DevLossType> LossTypes { get; private set; }
        public IEnumerable<DevUser> Users { get; private set; }

        public IndexModel(LossTypeService lossTypeService, UserService userService)
        {
            LossTypeService = lossTypeService;
            UserService = userService;
        }
        public void OnGet()
        {
            LossTypes = LossTypeService.GetLossTypes();
            Users = UserService.GetUsers();
        }
    }
}
