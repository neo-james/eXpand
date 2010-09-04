﻿using DevExpress.Xpo;
using Xpand.ExpressApp.AdditionalViewControlsProvider.Logic;
using FeatureCenter.Base;
using Xpand.ExpressApp.Attributes;

namespace FeatureCenter.Module.LowLevelFilterDataStore.SkinFilter
{
    
    [AdditionalViewControlsRule(Captions.ViewMessage + " " + Captions.HeaderFilterDataStoreSkinFilter, "1=1", "1=1", Captions.ViewMessageFilterDataStoreSkinFilter, Position.Bottom)]
    [AdditionalViewControlsRule(Captions.Header + " " + Captions.HeaderFilterDataStoreSkinFilter, "1=1", "1=1", Captions.HeaderFilterDataStoreSkinFilter, Position.Top)]
    [XpandNavigationItem("Low Level Filter DataStore/Filter By Application Skin", "FDSSCustomer_ListView")]
    [DisplayFeatureModel("FDSSCustomer_ListView", "SkinFilter")]
    public class FDSSCustomer:CustomerBase
    {
        public FDSSCustomer(Session session) : base(session) {
        }

    }
}
