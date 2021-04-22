using Microsoft.AspNetCore.Mvc;
using MvcCoreAWSBlank.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAWSBlank.Controllers
{
    public class DepartamentosController : Controller
    {
        RepositoryDepartamentos repo;

        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(repo.GetDepartamentos());
        }
    }
}
