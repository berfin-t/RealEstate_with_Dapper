﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.ViewComponents.AdminPage
{
    public class _AdminPageSpinnerComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
