using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VerifyCode.Core;

namespace VerifyCodeSlide.Web.Controllers
{
    /// <summary>
    /// 验证码控制器端
    /// </summary>
    public class VerificationCodeController : Controller
    {
        static readonly StaicMemoryCache cache = new StaicMemoryCache();
        VerifyCodeService verifyCodeService;
        public VerificationCodeController()
        {
            verifyCodeService = new VerifyCodeService(cache, GuiGe.S200_100);
        }

        [HttpPost]
        public ActionResult Generation()
        {
            var result = verifyCodeService.GenerateVerificationCode("xxg");
            return Json(result);
        }

        [HttpPost]
        public ActionResult Check(VerifyImageParametersDto verifyImageParametersDto)
        {
            var result = verifyCodeService.CheckCode(verifyImageParametersDto);
            return Json(result);
        }
    }
}