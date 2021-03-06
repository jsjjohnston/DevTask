using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTask.Services
{
	public class LossTypeService
	{
        public LossTypeService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public IEnumerable<DevLossType> GetLossTypes()
        {
            using var ctx = new InterviewContext();

            var result = ctx.DevLossTypes.ToList();
            return result;
        }

    }
}

