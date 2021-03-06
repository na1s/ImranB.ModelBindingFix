﻿using System;
using System.Web.Mvc;

namespace ImranB.ModelBindingFix.SystemWebMvc
{
    public sealed class FixedChildActionValueProviderFactory : ValueProviderFactory
    {
        public override IValueProvider GetValueProvider(ControllerContext controllerContext)
        {
            if (controllerContext == null)
            {
                throw new ArgumentNullException("controllerContext");
            }

            return new FixedChildActionValueProvider(controllerContext);
        }
    }
}
