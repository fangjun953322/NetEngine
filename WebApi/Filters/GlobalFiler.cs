﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Methods.Json;

namespace WebApi.Filters
{
    public class GlobalFiler : Attribute, IActionFilter
    {

        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {

        }


        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {
            if (context.HttpContext.Response.StatusCode == 400)
            {
                string errMsg = context.HttpContext.Items["errMsg"].ToString();

                context.Result = new JsonResult(new { errMsg = errMsg });
            }
        }
    }
}