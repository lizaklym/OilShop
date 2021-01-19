﻿using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class OilsController : Controller
    {
        private IOilRepository repository;
        public OilsController(IOilRepository repo)
        {
            repository = repo;
        }
        public ViewResult List()
        {
            return View(repository.Oils); 
        }
    }
}