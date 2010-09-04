﻿using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using Xpand.ExpressApp.Attributes;
using Xpand.Persistent.Base.General;

namespace FeatureCenter.Module {
    public abstract class CreateObjectAttributesController:ViewController {
        public override void CustomizeTypesInfo(ITypesInfo typesInfo)
        {
            base.CustomizeTypesInfo(typesInfo);
            var typeInfo = typesInfo.FindTypeInfo(GetTypeToDecorate());
            
            if (typeInfo != null) {
                var displayFeatureModelAttribute = GetDisplayFeatureModelAttribute();
                AddAttribute(typeInfo, displayFeatureModelAttribute);
                CloneViewAttribute cloneViewAttribute = GetCloneViewAttribute();
                AddAttribute(typeInfo, cloneViewAttribute);
                XpandNavigationItemAttribute xpandNavigationItemAttribute=GetNavigationItemAttribute();
                AddAttribute(typeInfo, xpandNavigationItemAttribute);
            }
        }

        protected virtual XpandNavigationItemAttribute GetNavigationItemAttribute() {
            return null;
        }

        protected virtual CloneViewAttribute GetCloneViewAttribute() {
            return null;
        }

        void AddAttribute(ITypeInfo typeInfo, ISupportViewId attribute) {
            if (attribute == null) return;
            var attributes = typeInfo.FindAttributes<Attribute>().OfType<ISupportViewId>();
            if (attributes.Where(attr =>attr.GetType()==attribute.GetType()&& attr.ViewId == attribute.ViewId).FirstOrDefault() == null)
                typeInfo.AddAttribute((Attribute) attribute);
        }

        protected abstract string GetTypeToDecorate();

        protected abstract DisplayFeatureModelAttribute GetDisplayFeatureModelAttribute();

        
    }
}