using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type objType = obj.GetType();
            PropertyInfo[] propertyInfos = objType.GetProperties();

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                // List<Attribute> allAttributes = propertyInfo.GetCustomAttributes().ToList();
                
                List<MyValidationAttribute> allMyAttributes = propertyInfo.GetCustomAttributes<MyValidationAttribute>().ToList();

                object propertyObj = propertyInfo.GetValue(obj);

                foreach (var myValidationAttribute in allMyAttributes)
                {
                    bool isValid = myValidationAttribute.isValid(propertyObj);

                    if(!isValid)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}