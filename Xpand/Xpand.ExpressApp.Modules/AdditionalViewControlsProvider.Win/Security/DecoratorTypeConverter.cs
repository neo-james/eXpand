﻿using System;
using Xpand.ExpressApp.AdditionalViewControlsProvider.Security;

namespace Xpand.ExpressApp.AdditionalViewControlsProvider.Win.Security {
    public class DecoratorTypeConverter:XpandReferenceConverter {
        protected override Type GetTypeInfo() {
            return typeof(AdditionalViewControlsProviderDecorator);
        }
    }
}