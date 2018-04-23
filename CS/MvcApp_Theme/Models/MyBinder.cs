using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Web.Mvc;
using System.ComponentModel;
using System.Web.Mvc;

public class MyEditorsBinder : DevExpressEditorsBinder {
    protected override object GetPropertyValue(ControllerContext controllerContext,
        ModelBindingContext bindingContext, PropertyDescriptor propertyDescriptor, IModelBinder propertyBinder) {
        if (propertyDescriptor.PropertyType == typeof(CommonThemes)) {
            TypeConverter tc = propertyDescriptor.Converter;
            return tc.ConvertFrom(EditorExtension.GetValue<String>(propertyDescriptor.Name));
        }

        return base.GetPropertyValue(controllerContext, bindingContext, propertyDescriptor, propertyBinder);
    }
}

