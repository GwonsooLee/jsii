﻿using System;

namespace Amazon.JSII.Runtime.Deputy
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class JsiiTypeProxyAttribute : JsiiTypeAttributeBase
    {
        public JsiiTypeProxyAttribute(Type nativeType, string fullyQualifiedName)
            : base(nativeType, fullyQualifiedName)
        {
        }
    }
}
